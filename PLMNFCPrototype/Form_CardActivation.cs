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

namespace PLMNFCPrototype
{
    public partial class Form_CardActivation : Form
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

        public Form_CardActivation()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;

            SelectDevice();
            establishContext();
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

        private void Form_CardActivation_Load(object sender, EventArgs e)
        {
            //tbSmartcard.Enabled = true;
            lblUserID_CardActive.Text = "" + strUserIDval;
            views();
        }

        void views()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Student_ID, Student_FName, Student_LName FROM STUDENT", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Student_ID, Student_FName, Student_LName FROM STUDENT WHERE Student_ID LIKE '%'+@studentid+'%' OR Student_Lname LIKE '%'+@lname+'%'", con);
            da.SelectCommand.Parameters.Add(new SqlParameter("@studentid", tbSearch.Text));
            da.SelectCommand.Parameters.Add(new SqlParameter("@lname", tbSearch.Text));
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.strPassedUserID = lblUserID_CardActive.Text;
            mainForm.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbStudentNumber.Enabled = false;
            tbStudentNumber.Text = dataGridView1.SelectedRows[0].Cells["Student_ID"].Value.ToString();
        }

        private void btnReadSmartcard_Click(object sender, EventArgs e)
        {
            if (connectCard())
            {
                string cardUID = getcardUID();
                tbSmartcard.Text = cardUID; //displaying on text block
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStudentNumber.Clear();
            tbSmartcard.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conect);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand insertStudCMD = new SqlCommand("INSERT INTO SMARTCARD(Smartcard_UID, Student_ID) VALUES (@SMART, @STUDID)", con);
                    insertStudCMD.Parameters.AddWithValue("@SMART", tbSmartcard.Text);
                    insertStudCMD.Parameters.AddWithValue("@STUDID", tbStudentNumber.Text);
                    int ctr = insertStudCMD.ExecuteNonQuery();
                    MessageBox.Show(ctr.ToString() + " record(s) saved");

                    string strSCStatus = "Activated";
                    string strSCStatReason = "Currently Active";
                    string strRemarks = "Currently Active";

                    SqlCommand insertSmartcardStatCMD = new SqlCommand("INSERT INTO SMARTCARDSTATUS(Student_ID, Smartcard_UID, Smartcard_Status, Smartcard_Status_Reason, Smartcard_Remarks) VALUES (@STUDID, @SMART, @STAT, @REASON, @REMARKS)", con);
                    insertSmartcardStatCMD.Parameters.AddWithValue("@STUDID", tbStudentNumber.Text);
                    insertSmartcardStatCMD.Parameters.AddWithValue("@SMART", tbSmartcard.Text);
                    insertSmartcardStatCMD.Parameters.AddWithValue("@STAT", strSCStatus);
                    insertSmartcardStatCMD.Parameters.AddWithValue("@REASON", strSCStatReason);
                    insertSmartcardStatCMD.Parameters.AddWithValue("@REMARKS", strRemarks);

                    int ctr2 = insertSmartcardStatCMD.ExecuteNonQuery();

                    MessageBox.Show("Data inserted to Smartcardstat table");
                }
                else
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }
    }
}
