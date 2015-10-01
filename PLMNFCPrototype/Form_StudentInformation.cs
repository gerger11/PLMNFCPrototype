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
    public partial class Form_StudentInformation : Form
    {
        string conect = String.Empty;
        string imageLoc = "";
        string strEditHolder = String.Empty;

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

        public Form_StudentInformation()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;

            SelectDevice();
            establishContext();
        }

        void views()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Student_ID, Student_FName, Student_MName, Student_LName, Student_Gender, Student_Birthdate, Student_Add_Street, Student_Add_Subdivision, Student_Add_CityProvince, Student_Add_ZipCode, Student_ContactNo, Student_EmailAdd, Student_Acad_Status, College_ID, Course_ID, Smartcard_UID, Student_Image FROM STUDENT", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //     dataGridView1.ClearSelection();
            dataGridView1.Columns[0].Visible = true;
            con.Close();
        }

        void disableFieldsOnLoad()
        {
            tbStudentNumber.Enabled = false;
            tbFName.Enabled = false;
            tbMName.Enabled = false;
            tbLName.Enabled = false;
            rbMale.Enabled = false;
            rbFemale.Enabled = false;
            dateTimePicker1.Enabled = false;
            tbStreet.Enabled = false;
            tbSubdivision.Enabled = false;
            tbCity.Enabled = false;
            tbZipcode.Enabled = false;
            tbAcadStatus.Enabled = false;
            cbCollege.SelectedItem = "";
            cbCourse.SelectedItem = "";
            cbCollege.Enabled = false;
            cbCourse.Enabled = false;
            tbSmartcard.Enabled = false;
            tbContactNo.Enabled = false;
            tbEmailAdd.Enabled = false;
        }

        private void Form_StudentInformation_Load(object sender, EventArgs e)
        {
            lblUserID_StudentInfo.Text = "" + strUserIDval;
            views();
            comboBoxContents();
            disableFieldsOnLoad();
            btnClear_Click(sender, e);
        }

        //=======================================================================================
        //                        Smartcard UID Fetching Implementation
        //=======================================================================================
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
        private void btnGetSmartcardUID_Click(object sender, EventArgs e)
        {
            if (connectCard())
            {
                string cardUID = getcardUID();
                tbSmartcard.Text = cardUID; //displaying on text block
            }
        }
        public bool connectCard()
        {
            connActive = true;

            retCode = ModWinsCard.SCardConnect(hContext, readername, ModWinsCard.SCARD_SHARE_SHARED,
                      ModWinsCard.SCARD_PROTOCOL_T0 | ModWinsCard.SCARD_PROTOCOL_T1, ref hCard, ref Protocol);

            if (retCode != ModWinsCard.SCARD_S_SUCCESS)
            {
                MessageBox.Show(ModWinsCard.GetScardErrMsg(retCode), "Card not available");
                tbSmartcard.Clear();
                connActive = false;
                return false;
            }

            return true;

        }
        private string getcardUID()//only for mifare 1k cards
        {
            string cardUID = "";
            byte[] receivedUID = new byte[256];
            ModWinsCard.SCARD_IO_REQUEST request = new ModWinsCard.SCARD_IO_REQUEST();
            request.dwProtocol = ModWinsCard.SCARD_PROTOCOL_T1;
            request.cbPciLength = System.Runtime.InteropServices.Marshal.SizeOf(typeof(ModWinsCard.SCARD_IO_REQUEST));
            byte[] sendBytes = new byte[] { 0xFF, 0xCA, 0x00, 0x00, 0x00 }; //get UID command      for Mifare cards
            int outBytes = receivedUID.Length;
            int status = ModWinsCard.SCardTransmit(hCard, ref request, ref sendBytes[0], sendBytes.Length, ref request, ref receivedUID[0], ref outBytes);

            if (status != ModWinsCard.SCARD_S_SUCCESS)
            {
                cardUID = "Error";
            }
            else
            {
                cardUID = BitConverter.ToString(receivedUID.Take(4).ToArray()).Replace("-", string.Empty).ToLower();
            }
            return cardUID;
        }
        private int getCardState()
        {
            connActive = true;

            retCode = ModWinsCard.SCardConnect(hContext, readername, ModWinsCard.SCARD_SHARE_SHARED,
                      ModWinsCard.SCARD_PROTOCOL_T0 | ModWinsCard.SCARD_PROTOCOL_T1, ref hCard, ref Protocol);

            //retCode = ModWinsCard.SCardState();

            return retCode;
        }

        //=======================================================================================
        //                        Smartcard UID Fetching Implementation
        //=======================================================================================


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowsePic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select student image";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imageLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imageLoc;
                }

                byte[] img = null;
                FileStream fStream = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
                BinaryReader binRead = new BinaryReader(fStream);
                img = binRead.ReadBytes((int)fStream.Length); //image parsing
                MemoryStream ms = new MemoryStream(img);
                if (img != null)
                {
                    pictureBox1.Image = Image.FromStream(ms);
                    btnUploadPic.Enabled = true;
                }
                else if (img == null)
                {
                    ms = null;
                    pictureBox1.Image = Image.FromStream(ms);
                }

            }//try

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }//catch
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnBrowsePic.Enabled = true;
            btnUploadPic.Enabled = false;

            tbStudentNumber.Enabled = true;
            tbFName.Enabled = true;
            tbMName.Enabled = true;
            tbLName.Enabled = true;
            rbFemale.Enabled = true;
            rbMale.Enabled = true;
            dateTimePicker1.Enabled = true;
            tbStreet.Enabled = true;
            tbSubdivision.Enabled = true;
            tbCity.Enabled = true;
            tbZipcode.Enabled = true;
            tbAcadStatus.Enabled = true;
            cbCollege.Enabled = true;
            cbCourse.Enabled = true;
            tbSmartcard.Enabled = false;
            tbContactNo.Enabled = true;
            tbEmailAdd.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tbFName.Text.Length == 0 && tbMName.Text.Length == 0 && tbLName.Text.Length == 0)
            {
               
                MainForm mainForm = new MainForm();
                mainForm.strPassedUserID = lblUserID_StudentInfo.Text;
                mainForm.Show();
                this.Close();
            }//if
            else
            {
                DialogResult dialog = MessageBox.Show("There are unsaved data in the form. Close this form?", "Close Colleges Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.strPassedUserID = lblUserID_StudentInfo.Text;
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    //Do Nothing
                }
            }//else
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbStudentNumber.Text) || string.IsNullOrEmpty(tbFName.Text) || string.IsNullOrEmpty(tbMName.Text) || string.IsNullOrEmpty(tbLName.Text) || string.IsNullOrEmpty(tbStreet.Text) || string.IsNullOrEmpty(tbSubdivision.Text) || string.IsNullOrEmpty(tbCity.Text) || string.IsNullOrEmpty(tbZipcode.Text) || string.IsNullOrWhiteSpace(tbStudentNumber.Text) || string.IsNullOrWhiteSpace(tbFName.Text) || string.IsNullOrWhiteSpace(tbMName.Text) || string.IsNullOrWhiteSpace(tbLName.Text) || string.IsNullOrWhiteSpace(tbStreet.Text) || string.IsNullOrWhiteSpace(tbSubdivision.Text) || string.IsNullOrWhiteSpace(tbCity.Text) || string.IsNullOrWhiteSpace(tbZipcode.Text))
            {
                MessageBox.Show("The fields should not be null or empty. Supply valid data.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
            }

            else if (lblEdit.Text == strEditHolder)
            {
                try
                {
                    string strGender;
                    if (rbMale.Checked == true)
                    {
                        rbFemale.Checked = false;
                        strGender = rbMale.Text;
                    }

                    else
                    {
                        rbMale.Checked = false;
                        strGender = rbFemale.Text;
                    }//Gender

                    SqlConnection con = new SqlConnection(conect);
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    
                    DialogResult dialog = MessageBox.Show("Do you want to update the record for this Student?\nStudent : " + tbFName.Text + " " + tbLName.Text, "Update Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        SqlCommand updateStudCMD = new SqlCommand("UPDATE STUDENT SET Student_ID = '" + tbStudentNumber.Text + "', Student_FName = '" + tbFName.Text + "', Student_MName = '" + tbMName.Text + "', Student_LName = '" + tbLName.Text + "', Student_Gender = '" + strGender + "', Student_Birthdate = '" + dateTimePicker1.Value + "', Student_Add_Street = '" + tbStreet.Text + "', Student_Add_Subdivision = '" + tbSubdivision.Text + "', Student_Add_CityProvince = '" + tbCity.Text + "', Student_Add_ZipCode = '" + tbZipcode.Text + "', Student_ContactNo = '" + tbContactNo.Text + "', Student_EmailAdd = '" + tbEmailAdd.Text + "', Student_Acad_Status = '" + tbAcadStatus.Text + "', College_ID = '" + cbCollege.SelectedValue + "', Course_ID = '" + cbCourse.SelectedValue + "', Smartcard_UID = '" + tbSmartcard.Text +  "' WHERE Student_ID = '" + lblEdit.Text + "'", con);
                        updateStudCMD.Parameters.AddWithValue("@STUDNO", tbStudentNumber.Text);
                        updateStudCMD.Parameters.AddWithValue("@FNAME", tbFName.Text);
                        updateStudCMD.Parameters.AddWithValue("@MNAME", tbMName.Text);
                        updateStudCMD.Parameters.AddWithValue("@LNAME", tbLName.Text);
                        updateStudCMD.Parameters.AddWithValue("@GENDER", strGender);
                        updateStudCMD.Parameters.AddWithValue("@BDAY", dateTimePicker1.Value);
                        updateStudCMD.Parameters.AddWithValue("@STREET", tbStreet.Text);
                        updateStudCMD.Parameters.AddWithValue("@SUBDIV", tbSubdivision.Text);
                        updateStudCMD.Parameters.AddWithValue("@CITYPROV", tbCity.Text);
                        updateStudCMD.Parameters.AddWithValue("@ZIP", tbZipcode.Text);
                        updateStudCMD.Parameters.AddWithValue("@CONTACTNO", tbContactNo.Text);
                        updateStudCMD.Parameters.AddWithValue("@EMAIL", tbEmailAdd.Text);
                        updateStudCMD.Parameters.AddWithValue("@ACADSTAT", tbAcadStatus.Text);
                        updateStudCMD.Parameters.AddWithValue("@COLID", cbCollege.SelectedValue);
                        updateStudCMD.Parameters.AddWithValue("@COURID", cbCourse.SelectedValue);
                        updateStudCMD.Parameters.AddWithValue("@SCARDUID", tbSmartcard.Text);
                       
                        MessageBox.Show("Student Record for " + tbStudentNumber.Text + " has been updated!", "Update Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int ctr = updateStudCMD.ExecuteNonQuery();
                        btnClear_Click(sender, e);
                        tbSearch_TextChanged(sender, e);
                    }
                }//try

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                }
            }

            else if(lblEdit.Text == "-----")
            {
                try
                {
                    byte[] img = null;
                    
                    FileStream fStream = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader binRead = new BinaryReader(fStream);
                    img = binRead.ReadBytes((int)fStream.Length); //image parsing
                    MemoryStream ms = new MemoryStream(img);


                    string strGender;
                    if(rbMale.Checked == true)
                    {
                        rbFemale.Checked = false;
                        strGender = rbMale.Text;
                    }

                    else 
                    {
                        rbMale.Checked = false;
                        strGender = rbFemale.Text;
                    }//Gender

                SqlConnection con = new SqlConnection(conect);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand insertStudCMD = new SqlCommand("INSERT INTO STUDENT(Student_ID, Student_FName, Student_MName, Student_LName, Student_Gender, Student_Birthdate, Student_Add_Street, Student_Add_Subdivision, Student_Add_CityProvince, Student_Add_ZipCode, Student_ContactNo, Student_EmailAdd, Student_Acad_Status, College_ID, Course_ID, Smartcard_UID, Student_Image) VALUES (@STUDNO, @FNAME, @MNAME, @LNAME, @GENDER, @BDAY, @STREET, @SUBDIV, @CITYPROV, @ZIP, @CONTACTNO, @EMAIL, @ACADSTAT, @COLID, @COURID, @SCARDUID, @STDPIC)", con);
                    insertStudCMD.Parameters.AddWithValue("@STUDNO", tbStudentNumber.Text);
                    insertStudCMD.Parameters.AddWithValue("@FNAME", tbFName.Text);
                    insertStudCMD.Parameters.AddWithValue("@MNAME", tbMName.Text);
                    insertStudCMD.Parameters.AddWithValue("@LNAME", tbLName.Text);
                    insertStudCMD.Parameters.AddWithValue("@GENDER", strGender);
                    insertStudCMD.Parameters.AddWithValue("@BDAY", dateTimePicker1.Value);
                    insertStudCMD.Parameters.AddWithValue("@STREET", tbStreet.Text);
                    insertStudCMD.Parameters.AddWithValue("@SUBDIV", tbSubdivision.Text);
                    insertStudCMD.Parameters.AddWithValue("@CITYPROV", tbCity.Text);
                    insertStudCMD.Parameters.AddWithValue("@ZIP", tbZipcode.Text);
                    insertStudCMD.Parameters.AddWithValue("@CONTACTNO", tbContactNo.Text);
                    insertStudCMD.Parameters.AddWithValue("@EMAIL", tbEmailAdd.Text);
                    insertStudCMD.Parameters.AddWithValue("@ACADSTAT", tbAcadStatus.Text);
                    insertStudCMD.Parameters.AddWithValue("@COLID", cbCollege.SelectedValue);
                    insertStudCMD.Parameters.AddWithValue("@COURID", cbCourse.SelectedValue);
                    insertStudCMD.Parameters.AddWithValue("@SCARDUID", tbSmartcard.Text);
                    
                    insertStudCMD.Parameters.AddWithValue("@STDPIC", img);
                    //test ms

                    int ctr = insertStudCMD.ExecuteNonQuery();
                    MessageBox.Show(ctr.ToString() + " record(s) saved");
                }
                else
                {
                    con.Close();
                }

                //implement insert query here
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                //con.Close();
                }//catch
            
            }
        }

        void comboBoxContents()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();

            //SqlDataAdapter da = new SqlDataAdapter("SELECT Course_ID, Course_Name, Course_Abbrev, College_ID FROM COURSE", con);
            //DataSet ds = new DataSet();
            try
            {
                string cbxSQL = "SELECT College_ID, College_Name, '['+ College_Abbreviation + '] ' + College_Name AS COLLEGENAME FROM COLLEGE";
                SqlCommand cmd = new SqlCommand(cbxSQL, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //cbxCollege.SelectedText = "---- Please select from Colleges ----";
                    cbCollege.DataSource = dt;
                    cbCollege.DisplayMember = "COLLEGENAME";
                    cbCollege.ValueMember = "College_ID";
                }//if
            }//try

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "ComboBox for College Exception");
                con.Close();
            }

            //SqlDataAdapter da = new SqlDataAdapter("SELECT Course_ID, Course_Name, Course_Abbrev, College_ID FROM COURSE", con);
            //DataSet ds = new DataSet();
            try
            {
                string cbxSQL = "SELECT Course_ID, Course_Name, '['+ Course_Abbrev + '] ' + Course_Name AS COURSENAME FROM COURSE";
                SqlCommand cmd = new SqlCommand(cbxSQL, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //cbxCollege.SelectedText = "---- Please select from Colleges ----";
                    cbCourse.DataSource = dt;
                    cbCourse.DisplayMember = "COURSENAME";
                    cbCourse.ValueMember = "Course_ID";
                }//if
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "ComboBox for Course Exception");
            }

        }//ComboBox Data Fill

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnAdd.Enabled = false;
                btnClear.Enabled = true;

                tbStudentNumber.Enabled = false;
                tbFName.Enabled = false;
                tbMName.Enabled = false;
                tbLName.Enabled = false;
                rbMale.Enabled = false;
                rbFemale.Enabled = false;
                dateTimePicker1.Enabled = false;
                tbStreet.Enabled = false;
                tbSubdivision.Enabled = false;
                tbCity.Enabled = false;
                tbZipcode.Enabled = false;
                tbAcadStatus.Enabled = false;
                cbCollege.Enabled = false;
                cbCourse.Enabled = false;
                tbSmartcard.Enabled = false;
                //GBI - set to true if testing without NFC Reader
                tbContactNo.Enabled = false;
                tbEmailAdd.Enabled = false;

                //Feed Data to Textbox

                try
                {
                    tbStudentNumber.Text = dataGridView1.SelectedRows[0].Cells["Student_ID"].Value.ToString();
                    tbFName.Text = dataGridView1.SelectedRows[0].Cells["Student_FName"].Value.ToString();
                    tbMName.Text = dataGridView1.SelectedRows[0].Cells["Student_MName"].Value.ToString();
                    tbLName.Text = dataGridView1.SelectedRows[0].Cells["Student_LName"].Value.ToString();
                    string strGender = dataGridView1.SelectedRows[0].Cells["Student_Gender"].Value.ToString();
                    if (strGender == "Male")
                        rbMale.Checked = true;
                    else rbFemale.Checked = true;
                    //implement Gender value passing here
                    DateTime curDate;
                    if (DateTime.TryParse(dataGridView1.SelectedRows[0].Cells["Student_Birthdate"].Value.ToString(), out curDate))
                    {
                        dateTimePicker1.Value = curDate;
                    }

                    tbStreet.Text = dataGridView1.SelectedRows[0].Cells["Student_Add_Street"].Value.ToString();
                    tbSubdivision.Text = dataGridView1.SelectedRows[0].Cells["Student_Add_Subdivision"].Value.ToString();
                    tbCity.Text = dataGridView1.SelectedRows[0].Cells["Student_Add_CityProvince"].Value.ToString();
                    tbZipcode.Text = dataGridView1.SelectedRows[0].Cells["Student_Add_ZipCode"].Value.ToString();
                    tbAcadStatus.Text = dataGridView1.SelectedRows[0].Cells["Student_Acad_Status"].Value.ToString();
                    cbCollege.SelectedValue = dataGridView1.SelectedRows[0].Cells["College_ID"].Value.ToString();
                    cbCourse.SelectedValue = dataGridView1.SelectedRows[0].Cells["Course_ID"].Value.ToString();
                    tbSmartcard.Text = dataGridView1.SelectedRows[0].Cells["Smartcard_UID"].Value.ToString();
                    tbContactNo.Text = dataGridView1.SelectedRows[0].Cells["Student_ContactNo"].Value.ToString();
                    tbEmailAdd.Text = dataGridView1.SelectedRows[0].Cells["Student_EmailAdd"].Value.ToString();

                    byte[] img = (byte[])(dataGridView1.SelectedRows[0].Cells["Student_Image"].Value);
                    MemoryStream ms = new MemoryStream(img);
                    if (img != null)
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    else if (img == null)
                    {
                        //ms = null;
                        //pictureBox1.Image = Image.FromStream(ms);
                        pictureBox1.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.GetBaseException().Message, "Cell Click Exception Occured");
                }
            }//try
            catch (Exception ex)
            {
                //MessageBox.Show(ex.GetBaseException().Message);
            }
        }//DataGrid Cell Click Implementation

        //Validating Method

        private void tbStudentNumber_Validating(object sender, CancelEventArgs e)
        {
            if(tbStudentNumber.Text == string.Empty)
            {
                MessageBox.Show("Student Number is a required field.\nThis cannot be empty.", "Student Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbFName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFName.Text == string.Empty)
            {
                MessageBox.Show("First Name is a required field.\nThis cannot be empty.", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbLName_Validating(object sender, CancelEventArgs e)
        {
            if (tbLName.Text == string.Empty)
            {
                MessageBox.Show("Last Name is a required field.\nThis cannot be empty.", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbStreet_Validating(object sender, CancelEventArgs e)
        {
            if (tbStreet.Text == string.Empty)
            {
                MessageBox.Show("Street is a required field.\nThis cannot be empty.", "Address - Street", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbSubdivision_Validating(object sender, CancelEventArgs e)
        {
            if (tbSubdivision.Text == string.Empty)
            {
                MessageBox.Show("Subdivision is a required field.\nThis cannot be empty.", "Address - Subdivision", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbCity.Text == string.Empty)
            {
                MessageBox.Show("City is a required field.\nThis cannot be empty.", "Address - City", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbZipcode_Validating(object sender, CancelEventArgs e)
        {
            if (tbZipcode.Text == string.Empty)
            {
                MessageBox.Show("Zipcode is a required field.\nThis cannot be empty.", "Address - Zipcode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbAcadStatus_Validating(object sender, CancelEventArgs e)
        {
            if (tbZipcode.Text == string.Empty)
            {
                MessageBox.Show("Zipcode is a required field.\nThis cannot be empty.", "Address - Zipcode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Student_ID, Student_FName, Student_MName, Student_LName, Student_Gender, Student_Birthdate, Student_Add_Street, Student_Add_Subdivision, Student_Add_CityProvince, Student_Add_ZipCode, Student_ContactNo, Student_EmailAdd, Student_Acad_Status, College_ID, Course_ID, Smartcard_UID, Student_Image FROM STUDENT WHERE Student_ID LIKE '%'+@STUDNO+'%' OR Student_FName LIKE '%'+@FNAME+'%'OR Student_LName LIKE '%'+@LNAME+'%'", con);
                da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearch.Text));
                da.SelectCommand.Parameters.Add(new SqlParameter("@FNAME", tbSearch.Text));
                da.SelectCommand.Parameters.Add(new SqlParameter("@LNAME", tbSearch.Text));
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnUploadPic.Enabled = false;
            btnBrowsePic.Enabled = false;

            tbStudentNumber.Enabled = false;
            tbFName.Enabled = false;
            tbMName.Enabled = false;
            tbLName.Enabled = false;
            rbMale.Enabled = false;
            rbFemale.Enabled = false;
            dateTimePicker1.Enabled = false;
            tbStreet.Enabled = false;
            tbSubdivision.Enabled = false;
            tbCity.Enabled = false;
            tbZipcode.Enabled = false;
            cbCollege.Enabled = false;
            cbCourse.Enabled = false;
            tbSmartcard.Enabled = false;
            tbContactNo.Enabled = false;
            tbEmailAdd.Enabled = false;

            tbStudentNumber.Clear();
            tbFName.Clear();
            tbMName.Clear();
            tbLName.Clear();
            tbStreet.Clear();
            tbSubdivision.Clear();
            tbCity.Clear();
            tbZipcode.Clear();
            tbSmartcard.Clear();
            tbContactNo.Clear();
            tbEmailAdd.Clear();
            dateTimePicker1.Value = System.DateTime.Now;
            pictureBox1.Image = null;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            strEditHolder = tbStudentNumber.Text;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnBrowsePic.Enabled = true;
            btnUploadPic.Enabled = false;

            tbStudentNumber.Enabled = true;
            tbFName.Enabled = true;
            tbMName.Enabled = true;
            tbLName.Enabled = true;
            rbMale.Enabled = true;
            rbFemale.Enabled = true;
            dateTimePicker1.Enabled = true;
            tbStreet.Enabled = true;
            tbSubdivision.Enabled = true;
            tbCity.Enabled = true;
            tbZipcode.Enabled = true;
            cbCollege.Enabled = true;
            cbCourse.Enabled = true;
            //tbSmartcard.Enabled = true;
            //icomment out after
            
            tbContactNo.Enabled = true;
            tbEmailAdd.Enabled = true;
            lblEdit.Text = tbStudentNumber.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Are you sure you want to delete this data?", "Deletion Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diag == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from STUDENT WHERE Student_ID = '" + tbStudentNumber.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is deleted.", "Deletion Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
                tbSearch_TextChanged(sender, e);
            }
        }

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fStream = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
                BinaryReader binRead = new BinaryReader(fStream);
                img = binRead.ReadBytes((int)fStream.Length); //image parsing
                MemoryStream ms = new MemoryStream(img);

                if (img == null)
                {
                    pictureBox1.Image = null;
                }

                SqlConnection con = new SqlConnection(conect);
                if (con.State != ConnectionState.Open)
                    con.Open();

                DialogResult dialog = MessageBox.Show("Do you want to update the photo of this Student?\nStudent : " + tbFName.Text + " " + tbLName.Text, "Update Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    SqlCommand updateStudCMD = new SqlCommand("UPDATE STUDENT SET Student_Image = NULL WHERE Student_ID = '" + lblEdit.Text + "'", con);
                    updateStudCMD.ExecuteNonQuery();
                    SqlCommand insertImageCMD = new SqlCommand("UPDATE STUDENT SET Student_Image = @IMAGE WHERE Student_ID = '" + lblEdit.Text + "'", con);
                    insertImageCMD.Parameters.AddWithValue("@IMAGE", img);
         
                    insertImageCMD.ExecuteNonQuery();
                    MessageBox.Show("Student Picture for " + tbStudentNumber.Text + " has been updated!", "Update Student Display Photo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender, e);
                    tbSearch_TextChanged(sender, e);
                }
            }//try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void tbSmartcard_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
