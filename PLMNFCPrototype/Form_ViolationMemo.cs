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
    public partial class Form_ViolationMemo : Form
    {
        string conect = String.Empty;

        private string strUserIDval;
        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }

        public Form_ViolationMemo()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;
        }

        private void Form_ViolationMemo_Load(object sender, EventArgs e)
        {

            lblUserID_VioMemo.Text = "" + strUserIDval;
            views();
        }

        private void tbSearchStudVio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT STUDENT.Student_ID, STUDENT.Student_FName, STUDENT.Student_LName FROM STUDENT WHERE Student_ID LIKE '%'+@STUDNO+'%' OR Student_LName LIKE '%'+@LASTNAME+'%'", con);

                da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearchStudVio.Text));
                da.SelectCommand.Parameters.Add(new SqlParameter("@LASTNAME", tbSearchStudVio.Text));
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        void trackAndCountViolation()
        //=======================================================================================//
        //== Method that will count pending violation of student (If there is or there is none ==//
        //=======================================================================================//
        {
            SqlConnection con = new SqlConnection(conect);
            try
            {
                string strQuery = "SELECT COUNT(DISTINCT Violation_ID) AS [NUMBER OF VIOLATIONS] FROM VIOLATION, STUDENT WHERE Violation_Status = 'Unsettled' AND STUDENT.Student_ID = VIOLATION.Student_ID AND VIOLATION.Student_ID = '" + tbMemoTo.Text + "'"; //change to textbox
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand(strQuery, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows)
                {
                    int violationCtrParse = Int32.Parse(rdr[0].ToString());
                    if (violationCtrParse.Equals(0))
                    {
                        violationCounter.ForeColor = Color.Green;
                        violationCounter.Text = violationCtrParse.ToString();
                    }
                    
                    else //if (violationCtrParse != 0)
                    {
                        violationCounter.ForeColor = Color.Red;
                        violationCounter.Text = violationCtrParse.ToString();
                        //violationCounter.Text = rdr[0].ToString();
                    }
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        void insertViolationMemo()
        {
            string strActive = "Active";
            try
            {
                SqlConnection con = new SqlConnection(conect);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand insertViolationCMD = new SqlCommand("INSERT INTO VIOLATIONMEMO(Student_ID, Violation_Memo_From, Violation_Memo_Date, Violation_Remarks, Violation_Status) VALUES (@STUDNO, @VIOMEMOFROM, @VIOMEMODATE, @VIOREMARKS, @VIOSTAT)", con);
                    insertViolationCMD.Parameters.AddWithValue("@STUDNO", tbMemoTo.Text);
                    insertViolationCMD.Parameters.AddWithValue("@VIOMEMOFROM", tbMemoFrom.Text);
                    insertViolationCMD.Parameters.AddWithValue("@VIOMEMODATE", DateTime.Now);
                    insertViolationCMD.Parameters.AddWithValue("@VIOREMARKS", tbRemarks.Text);
                    insertViolationCMD.Parameters.AddWithValue("@VIOSTAT", strActive);
                    int ctr = insertViolationCMD.ExecuteNonQuery();
                    MessageBox.Show(ctr.ToString() + " record(s) saved", "Violation Memo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
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

        void updateViolationMemoRecords()
        {
            SqlConnection con = new SqlConnection(conect);
            try
            {
                string strQuery = "SELECT Student_ID, Violation_Memo_From, Violation_Memo_Date, Violation_Remarks, Violation_Status FROM VIOLATIONMEMO Where Student_ID = '" + tbMemoTo.Text + "'"; //change to textbox
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd2 = new SqlCommand(strQuery, con);
                SqlDataReader rdr2 = cmd2.ExecuteReader();
                rdr2.Read();
                if (rdr2.HasRows)
                {
                    string strInactiveMemo = "Inactive";
                    DialogResult dialog = MessageBox.Show("Do you want to set other memo as inactive for this Student?\nSTUDENT : " + tbMemoTo.Text, "Update Violation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        SqlCommand updateViolationCMD = new SqlCommand("UPDATE VIOLATIONMEMO SET Violation_Status = '" + strInactiveMemo + "' WHERE Student_ID = '" + tbMemoTo.Text + "'", con);
                        updateViolationCMD.ExecuteNonQuery();
                        MessageBox.Show("Previous Violation Memo Record for " + tbMemoTo.Text + " has been set to Inactive!", "Update Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        insertViolationMemo();
                    }
                    else
                    {
                        //Do Nothing
                        con.Close();
                    }
                }


                else if (!rdr2.HasRows)
                {
                    //do nothing
                    con.Close();
                    insertViolationMemo();

                }
            }//try

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        void views()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Student_ID, Student_FName, Student_LName FROM STUDENT", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //     dataGridView1.ClearSelection();
            dataGridView1.Columns[0].Visible = true;

            //implement here the codes for combobox data fetching
            //SqlDataAdapter da2 = new SqlDataAdapter("SELECT College_Name from College", con);
            //DataSet ds2 = new DataSet();
            //da2.Fill(ds2);
            //cbxCollege.ValueMember = ds2.ToString() ;
            //
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                tbMemoTo.Enabled = false;
                tbMemoTo.Text = dataGridView1.SelectedRows[0].Cells["Student_ID"].Value.ToString();
                trackAndCountViolation();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void btnSaveMemo_Click(object sender, EventArgs e)
        {
            if (tbMemoTo.Text.Length > 0 || tbRemarks.Text.Length > 0)
            {
                updateViolationMemoRecords();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.strPassedUserID = lblUserID_VioMemo.Text;
            mainForm.Show();
            this.Close();
        }

       
    }
}
