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
    public partial class Form_CardDeactivation : Form
    {
        string conect = String.Empty;
        string strSmartcardStat = String.Empty;
        string strSmartcardStatForSTAT = String.Empty;
        string strSmartcardRemarks = String.Empty;
        string strSmartcardStatReason = String.Empty;
        string strEditHolder = String.Empty;

        private string strUserIDval;
        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }

        public Form_CardDeactivation()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;
        }

        private void Form_CardDeactivation_Load(object sender, EventArgs e)
        {
            lblUserID_CardDeactive.Text = "" + strUserIDval;
            viewSmartcardStats();
        }
        void viewSmartcardStats()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Student.Student_ID, Student.Student_FName, Student.Student_LName, SMARTCARD.Smartcard_UID, SMARTCARDSTATUS.Smartcard_Status, SMARTCARDSTATUS.Smartcard_Status_Reason, SMARTCARDSTATUS.Smartcard_Remarks FROM STUDENT, SMARTCARD, SMARTCARDSTATUS WHERE STUDENT.Smartcard_UID = SMARTCARD.Smartcard_UID AND SMARTCARD.Smartcard_UID = SMARTCARDSTATUS.Smartcard_UID", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Columns[0].Visible = true;
            con.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();

            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = true;

            tbStudentNo.Enabled = false;
            tbSmartcardUID.Enabled = false;
            rbActivate.Enabled = false;
            rbDeactivate.Enabled = false;
            rbDamaged.Enabled = false;
            rbLost.Enabled = false;
            rbStolen.Enabled = false;
            dateTimePicker1.Enabled = false;


            tbStudentNo.Text = dataGridView1.SelectedRows[0].Cells["Student_ID"].Value.ToString();
            tbSmartcardUID.Text = dataGridView1.SelectedRows[0].Cells["Smartcard_UID"].Value.ToString();

            strSmartcardStat = dataGridView1.SelectedRows[0].Cells["Smartcard_Status"].Value.ToString();
            if (strSmartcardStat == "Activated")
            {
                rbActivate.Checked = true;
                rbDeactivate.Checked = false;
                rbLost.Checked = false;
                rbStolen.Checked = false;
                rbDamaged.Checked = false;
            }
            else
            {
                rbDeactivate.Checked = true;
            }

            strSmartcardStatReason = dataGridView1.SelectedRows[0].Cells["Smartcard_Status_Reason"].Value.ToString();
                if(strSmartcardStatReason == "Currently Active")
                {
                    rbDeactivate.Checked = false;
                    rbDamaged.Checked = false;
                    rbLost.Checked = false;
                    rbStolen.Checked = false;
                }
                else if (strSmartcardStatReason == "Damaged")
                {
                    rbDeactivate.Checked = true;
                    rbDamaged.Checked = true;
                    rbLost.Checked = false;
                    rbStolen.Checked = false;
                }
                else if (strSmartcardStatReason == "Lost")
                {
                    rbDeactivate.Checked = true;
                    rbDamaged.Checked = false;
                    rbLost.Checked = true;
                    rbStolen.Checked = false;
                }
                else if (strSmartcardStatReason == "Stolen")
                {
                    rbDeactivate.Checked = true;
                    rbDamaged.Checked = false;
                    rbLost.Checked = false;
                    rbStolen.Checked = true;
                }

            tbRemarks.Text = dataGridView1.SelectedRows[0].Cells["Smartcard_Remarks"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            strEditHolder = tbSmartcardUID.Text;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            tbStudentNo.Enabled = false;
            tbSmartcardUID.Enabled = false;
            rbActivate.Enabled = true;
            rbDeactivate.Enabled = true;
            lblEdit.Text = tbSmartcardUID.Text;
        }

        private void rbDeactivate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeactivate.Checked == true)
            {
                rbActivate.Checked = false;
                grpDeactivationReason.Enabled = true;
                rbLost.Enabled = true;
                rbDamaged.Enabled = true;
                rbStolen.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
        }

        private void rbActivate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActivate.Checked == true)
            {
                rbDeactivate.Checked = false;
                grpDeactivationReason.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblEdit.Text == strEditHolder)
                {
                    SqlConnection con = new SqlConnection(conect);
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    DialogResult dialog = MessageBox.Show("Do you want to deactivate this Smartcard? Note that this will also update the smartcard record from main table and set it to DEACTIVATED status.\nSMARTCARD : " + tbSmartcardUID.Text + "\nSTUDENT NUMBER :" + tbStudentNo.Text, "Deactivate Smartcard", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        if (rbActivate.Checked == true)
                        {
                            strSmartcardStat = "Activated";
                            strSmartcardStatForSTAT = "Currently Active";

                        }
                        else if (rbDeactivate.Checked == true)
                        {
                            strSmartcardStat = "Deactivated";
                            strSmartcardStatForSTAT = "Deactivated";
                            if (rbDamaged.Checked == true)
                            {
                                rbLost.Checked = false;
                                rbStolen.Checked = false;
                                strSmartcardStatReason = rbDamaged.Text;
                            }
                            else if (rbLost.Checked == true)
                            {
                                rbDamaged.Checked = false;
                                rbStolen.Checked = false;
                                strSmartcardStatReason = rbLost.Text;
                            }
                            else if (rbStolen.Checked == true)
                            {
                                rbDamaged.Checked = false;
                                rbLost.Checked = false;
                                strSmartcardStatReason = rbStolen.Text;
                            }//rbStolen
                        }//Deactivate Tail

                        SqlCommand updateSmartcardCMD = new SqlCommand("UPDATE SMARTCARDSTATUS SET Smartcard_Status = '" + strSmartcardStatForSTAT + "', Smartcard_Status_Reason = '" + strSmartcardStatReason + "', Smartcard_Remarks = '" + strSmartcardStatReason + " - Reported " + dateTimePicker1.Value.ToShortDateString() + "' WHERE Smartcard_UID = '" + lblEdit.Text + "'", con);
                        updateSmartcardCMD.Parameters.AddWithValue("@STATFORSTAT", strSmartcardStatForSTAT);
                        updateSmartcardCMD.Parameters.AddWithValue("@STATREASON", strSmartcardStatReason);
                        updateSmartcardCMD.Parameters.AddWithValue("@REMARKS", strSmartcardRemarks);
                        int ctr = updateSmartcardCMD.ExecuteNonQuery();
                        MessageBox.Show("Smartcard Record for " + tbStudentNo.Text + " has been updated!", "Card Deactivation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlCommand updateMainTable = new SqlCommand("UPDATE SMARTCARD SET Student_ID = '" + tbStudentNo.Text + "', Smartcard_Status = '" + strSmartcardStat + "' WHERE Smartcard_UID = '" + lblEdit.Text + "'", con);
                        updateMainTable.Parameters.AddWithValue("@STUDNO", tbStudentNo.Text);
                        updateMainTable.Parameters.AddWithValue("@STAT", strSmartcardStat);
                        int cmd2 = updateMainTable.ExecuteNonQuery();
                        MessageBox.Show("Smartcard Record for " + tbStudentNo.Text + " has been updated in the main table!", "Card Deactivation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewSmartcardStats();
                        
                        //btnClear_Click(sender, e);
                        //tbSearch_TextChanged(sender, e);
                    }
                    else
                    {
                        //Do Nothing
                    }
                }
            }//try
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.strPassedUserID = lblUserID_CardDeactive.Text;
            mainForm.Show();
            this.Close();
        }
    }
}


