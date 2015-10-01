using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;


namespace PLMNFCPrototype
{
    public partial class MainForm : Form
    {
        string conect = String.Empty;
        private string strUserIDval;
        

        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }

        int retCode;
        int hCard;
        int hContext;
        int Protocol;
        public bool connActive = false;
        string readername = "ACS ACR122 0";      // change depending on reader
        public byte[] SendBuff = new byte[263];
        public byte[] RecvBuff = new byte[263];
        public int SendLen, RecvLen, nBytesRet, reqType, Aprotocol, dwProtocol, cbPciLength;
        public ModWinsCard.SCARD_READERSTATE RdrState;
        public ModWinsCard.SCARD_IO_REQUEST pioSendRequest;
        //-----NFC Declarations
        public MainForm()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;

            //---------textboxinit
            string strCurrentText = "--------";
            //textBox1.Text = strCurrentText;
            //pictureBox1.Image = null;
            //Device Connection Establishment
            SelectDevice();
            establishContext();
            //view();
            //newView();
            //init reader
            this.RdrState = new ModWinsCard.SCARD_READERSTATE();
        }

        void userAccessVerification()
        {
            if (lblUserType.Text == "USG")
            {
                coursesToolStripMenuItem.Enabled = false;
                collegesToolStripMenuItem.Enabled = false;
                employeeTypeToolStripMenuItem.Enabled = false;
                violationInformationToolStripMenuItem.Enabled = false;
                accountsToolStripMenuItem.Enabled = false;
                emToolStripMenuItem.Enabled = false;
                studentInformationToolStripMenuItem.Enabled = false;
                cardActivationToolStripMenuItem.Enabled = false;
                cardDeactivationToolStripMenuItem.Enabled = false;
                runSQLScriptsToolStripMenuItem.Enabled = false;

            }

            else if (lblUserType.Text == "OSDS")
            {
                coursesToolStripMenuItem.Enabled = false;
                collegesToolStripMenuItem.Enabled = false;
                employeeTypeToolStripMenuItem.Enabled = false;
                violationInformationToolStripMenuItem.Enabled = false;
                accountsToolStripMenuItem.Enabled = false;
                emToolStripMenuItem.Enabled = false;
            }
        }
        
        void showEmployeeDetails()
        {
            SqlConnection con = new SqlConnection(conect);
            try
            {
                string strQuery = "SELECT EMPLOYEE.Employee_LName, EMPLOYEETYPE.Employee_Type_Name, EMPLOYEE.Employee_Image, USERACCOUNTS.Account_ID FROM EMPLOYEE, EMPLOYEETYPE, USERACCOUNTS WHERE EMPLOYEE.Employee_Type_ID = EMPLOYEETYPE.Employee_Type_ID AND EMPLOYEE.Employee_ID = USERACCOUNTS.Employee_ID AND USERACCOUNTS.Account_ID ='" + lblUserID.Text + "'";
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand(strQuery, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {
                    lblEmpLastName.Text = rdr[0].ToString();
                    lblUserType.Text = rdr[1].ToString();
    
                    byte[] img = (byte[])(rdr[2]);
                    if (img == null)
                        pbEmployee.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pbEmployee.Image = Image.FromStream(ms);
                    }
                    con.Close();
                }//if

            }//try

            catch (Exception ex)
            {
               // MessageBox.Show(ex.GetBaseException().Message);
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = System.DateTime.Now.ToLongDateString();
            lblLongTime.Text = System.DateTime.Now.ToLongTimeString();
            //label1.Text = "-----STUDID------";
            //label2.Text = "-----STDNAME-----";
            //label3.Text = "-----COLLEGE-----";
            //label4.Text = "-----COURSE------";
            lblUserID.Text = "" +strPassedUserID;
            //pictureBox1.Image = null;
            showEmployeeDetails();
            userAccessVerification();
        }

     

        public void SelectDevice()
        {
            List<string> availableReaders = this.ListReaders();
            this.RdrState = new ModWinsCard.SCARD_READERSTATE();
            readername = availableReaders[0].ToString();//selecting first device
            this.RdrState.RdrName = readername;
        }//
        public List<string> ListReaders()
        {
            int ReaderCount = 0;
            List<string> AvailableReaderList = new List<string>();

            //Make sure a context has been established before 
            //retrieving the list of smartcard readers.
            retCode = ModWinsCard.SCardListReaders(hContext, null, null, ref ReaderCount);
            if (retCode != ModWinsCard.SCARD_S_SUCCESS)
            {
                MessageBox.Show(ModWinsCard.GetScardErrMsg(retCode));
                //connActive = false;
            }

            byte[] ReadersList = new byte[ReaderCount];

            //Get the list of reader present again but this time add sReaderGroup, retData as 2rd & 3rd parameter respectively.
            retCode = ModWinsCard.SCardListReaders(hContext, null, ReadersList, ref ReaderCount);
            if (retCode != ModWinsCard.SCARD_S_SUCCESS)
            {
                MessageBox.Show(ModWinsCard.GetScardErrMsg(retCode));
            }

            string rName = "";
            int indx = 0;
            if (ReaderCount > 0)
            {
                // Convert reader buffer to string
                while (ReadersList[indx] != 0)
                {

                    while (ReadersList[indx] != 0)
                    {
                        rName = rName + (char)ReadersList[indx];
                        indx = indx + 1;
                    }

                    //Add reader name to list
                    AvailableReaderList.Add(rName);
                    rName = "";
                    indx = indx + 1;

                }
            }
            return AvailableReaderList;
        }

        internal void establishContext()
        {
            retCode = ModWinsCard.SCardEstablishContext(ModWinsCard.SCARD_SCOPE_SYSTEM, 0, 0, ref hContext);
            if (retCode != ModWinsCard.SCARD_S_SUCCESS)
            {
                MessageBox.Show("Check your device and please restart again", "Reader not connected");
                connActive = false;
                return;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblLongTime.Text = System.DateTime.Now.ToLongTimeString();
        }//Dynamic Time Function


        //===========================================================================
        //       End of NFC Implementation on Main Form 
        //===========================================================================
        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateReportForStudentViolationPerCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void collegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Colleges frmColleges = new Form_Colleges();
            frmColleges.strPassedUserID = lblUserID.Text;
            frmColleges.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Courses frmCourses = new Form_Courses();
            frmCourses.strPassedUserID = lblUserID.Text;
            frmCourses.Show();
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_StudentInformation frmStudInfo = new Form_StudentInformation();
            frmStudInfo.strPassedUserID = lblUserID.Text;
            frmStudInfo.Show();
        }

        private void violationInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ViolationInfo frmViolationInfo = new Form_ViolationInfo();
            frmViolationInfo.strPassedUserID = lblUserID.Text;
            frmViolationInfo.Show();
        }

        private void employeeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EmployeeType frmEmpType = new Form_EmployeeType();
            frmEmpType.strPassedUserID = lblUserID.Text;
            frmEmpType.Show();
        }//employeeTypeMenustrip

        private void studentViolationMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ViolationMemo frmVioMemo = new Form_ViolationMemo();
            frmVioMemo.strPassedUserID = lblUserID.Text;
            frmVioMemo.Show();
        }

        private void studentViolationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_StudentViolation frmStudViolation = new Form_StudentViolation();
            frmStudViolation.strPassedUserID = lblUserID.Text;
            frmStudViolation.Show();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_UserAccounts frmUserAccounts = new Form_UserAccounts();
            frmUserAccounts.strPassedUserID = lblUserID.Text;
            frmUserAccounts.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void emToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EmployeeInformation frmEmployeeInformation = new Form_EmployeeInformation();
            frmEmployeeInformation.strPassedUserID = lblUserID.Text;
            frmEmployeeInformation.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to logout to PLM-SIMS?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                try
                {
                    Form_RunSQLScripts f2 = (Form_RunSQLScripts)Application.OpenForms["Form_RunSQLScripts"];
                    f2.Close();
                }
                catch (NullReferenceException ne)
                {}

                try
                {
                    Form_QueryStudentSwipes f3 = (Form_QueryStudentSwipes)Application.OpenForms["Form_QueryStudentSwipes"];
                    f3.Close();
                }
                catch (NullReferenceException ne)
                {}

                try
                {
                    Form_About f4 = (Form_About)Application.OpenForms["Form_About"];
                    f4.Close();
                }
                catch (NullReferenceException ne)
                {}

                this.Hide();
                Form_Login loginForm = new Form_Login();
                loginForm.Show();
            }
            else
            {
                //Do Nothing
            }
        }

        private void cardActivationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CardActivation frmCardActive = new Form_CardActivation();
            frmCardActive.strPassedUserID = lblUserID.Text;
            frmCardActive.Show();
        }

        private void cardDeactivationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CardDeactivation frmCardDeactive = new Form_CardDeactivation();
            frmCardDeactive.strPassedUserID = lblUserID.Text;
            frmCardDeactive.Show();
        }

        private void aboutPLMSIMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_About frmAbout = new Form_About();
            frmAbout.Show();
        }


        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblLongTime_Click(object sender, EventArgs e)
        {

        }

        private void studentSwipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QueryStudentSwipes frmStudSwipes = new Form_QueryStudentSwipes();
            frmStudSwipes.Show();
        }

        private void runSQLScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RunSQLScripts frmSQLScripts = new Form_RunSQLScripts();
            frmSQLScripts.strPassedUserID = lblUserID.Text;
            frmSQLScripts.Show();
        }
    }
}
