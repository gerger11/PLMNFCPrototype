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
    public partial class Form_StudentViolation : Form
    {
        string conect = String.Empty;
        string strViolationStat;
        string dateSettled = String.Empty;
        string strFilter;

        private string strUserIDval;
        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }

        public Form_StudentViolation()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;
        }

        private void Form_StudentViolation_Load(object sender, EventArgs e)
        {
            lblUserID_StudVio.Text = "" + strUserIDval;
            views();
            comboBoxContents();
            disableFieldsOnLoad();
        }

        private void tbSearchStud_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Student_ID, Student_FName, Student_LName FROM STUDENT WHERE Student_ID LIKE '%'+@STUDNO+'%' OR Student_LName LIKE '%'+@LASTNAME+'%'", con);

            da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearchStud.Text));
            da.SelectCommand.Parameters.Add(new SqlParameter("@LASTNAME", tbSearchStud.Text));

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void tbSearchStudVio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT VIOLATION.Violation_ID, VIOLATION.Student_ID, VIOLATION.Violation_Name_ID, VIOLATION.Violation_Date_Time, VIOLATION.Violation_Status, VIOLATION.Violation_DateSettled FROM VIOLATION, STUDENT WHERE VIOLATION.Student_ID LIKE '%'+@STUDNO+'%'", con);

                da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearchStudVio.Text));
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
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
            con.Close();
        }

        void disableFieldsOnLoad()
        {
            tbStudentNumber.Enabled = false;
            cbViolation.Enabled = false;
            dtViolationDateTime.Enabled = false;
            rbSettled.Enabled = false;
            rbUnsettled.Enabled = false;
            dtDateSettled.Enabled = false;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbViolation.Enabled = true;
            rbUnsettled.Enabled = true;
            rbSettled.Enabled = true;
            dtViolationDateTime.Enabled = true;
            dtDateSettled.Enabled = false;  
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cbViolation.Enabled = false;
            dtViolationDateTime.Enabled = false;
            rbSettled.Enabled = true;
            rbUnsettled.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStudentNumber.Clear();
            tbViolationID.Clear();
            rbSettled.Checked = false;
            rbUnsettled.Checked = false;
            tbSearchStud.Clear();
            tbSearchStudVio.Clear();
            chkUnsettled.Checked = false;
            chkSettled.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tbStudentNumber.Text.Length == 0)
            {
                MainForm mainForm = new MainForm();
                mainForm.strPassedUserID = lblUserID_StudVio.Text; 
                mainForm.Show();
                this.Close();
            }//if
            else
            {
                DialogResult dialog = MessageBox.Show("There are unsaved data in the form. Close this form?", "Close Student Violations Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.strPassedUserID = lblUserID_StudVio.Text;
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
           
                //UPDATE
            if (tbViolationID.Text.Length > 0)
                updateViolationRecord();
            else
                insertViolationRecord();   
        }

        void updateViolationRecord()
        {
            try
            {
                if (rbUnsettled.Checked == true)
                {
                    rbSettled.Checked = false;
                    strViolationStat = rbUnsettled.Text;
                    dateSettled = String.Empty;
                }
                else if (rbSettled.Checked == true)
                {
                    rbUnsettled.Checked = false;
                    strViolationStat = rbSettled.Text;
                    dateSettled = dtDateSettled.Value.ToString();
                }//ViolationStatus
          
                SqlConnection con = new SqlConnection(conect);
                if (con.State != ConnectionState.Open)
                    con.Open();
                //SqlCommand cmd1 = new SqlCommand("UPDATE Employee SET FName = @fname, Mname = @midname, Lname = @Lastname , landlineno = @landline, mobileno = @mobileno, emailadd = @email,Gender = '" + strGender + "', birthdate = '" + dtpBirthDate.Value.ToShortDateString() + "', licenseNo =  '" + txtLicense.Text + "', dateofEmployment = '" + dtpEmployment.Value.ToShortDateString() + "', employeetypeid = '" + strEmployeeType + "' WHERE EmployeeId = '" + lblEmpID.Text + "'", con);

                DialogResult dialog = MessageBox.Show("Do you want to update the record for this Violation?\nSTUDENT : " +tbStudentNumber.Text, "Update Violation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    SqlCommand updateViolationCMD = new SqlCommand("UPDATE VIOLATION SET Violation_Status = '" + strViolationStat + "', Violation_DateSettled = '" + dateSettled + "' WHERE Violation_ID = '" + tbViolationID.Text + "'", con);
                    updateViolationCMD.Parameters.AddWithValue("@VIOSTAT", strViolationStat);
                    updateViolationCMD.Parameters.AddWithValue("@DATESETTLED", dateSettled);
                    
                    //updateViolationCMD.Parameters.AddWithValue("@SMARTCARD", lblStudSmartCardUID.Text);
                    //updateViolationCMD.Parameters.AddWithValue("@DATE", DateTime.Now);
                    int ctr = updateViolationCMD.ExecuteNonQuery();
                    MessageBox.Show("Violation Record for " + tbStudentNumber.Text + " has been updated!", "Update Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // MessageBox.Show(ctr.ToString() + " record(s) saved");
                    //timer1.Start();
                }
                else
                {
                    //Do Nothing
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
                //Catch here 
            }
        }

        void insertViolationRecord()
        {
            try
            {
                if (rbUnsettled.Checked == true)
                {
                    rbSettled.Checked = false;
                    strViolationStat = rbUnsettled.Text;
                    dateSettled = String.Empty;
                }
                else if (rbSettled.Checked == true)
                {
                    rbUnsettled.Checked = false;
                    strViolationStat = rbSettled.Text;
                    dateSettled = dtDateSettled.Value.ToString();
                }//ViolationStatus

                SqlConnection con = new SqlConnection(conect);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand insertViolationCMD = new SqlCommand("INSERT INTO VIOLATION(Student_ID, Violation_Name_ID, Violation_Date_Time, Violation_Status, Violation_DateSettled) VALUES (@STUDNO, @VIONAMEID, @VIODATETIME, @VIOSTAT, @VIODATESETTLED)", con);
                    insertViolationCMD.Parameters.AddWithValue("@STUDNO", tbStudentNumber.Text);
                    insertViolationCMD.Parameters.AddWithValue("@VIONAMEID", cbViolation.SelectedValue);
                    insertViolationCMD.Parameters.AddWithValue("@VIODATETIME", dtViolationDateTime.Value);
                    insertViolationCMD.Parameters.AddWithValue("@VIOSTAT", strViolationStat);
                    insertViolationCMD.Parameters.AddWithValue("@VIODATESETTLED", dateSettled);
                    int ctr = insertViolationCMD.ExecuteNonQuery();
                    MessageBox.Show(ctr.ToString() + " record(s) saved", "Violation Adding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Close();
                    //Baka i-implement dito yung edit? not sure yet
                }

                //implement insert query here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
                //con.Close();
            }//catch
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            
           // btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            tbStudentNumber.Enabled = false;
            tbStudentNumber.Text = dataGridView1.SelectedRows[0].Cells["Student_ID"].Value.ToString();

            //Feed data to tbSearchStudVio
            tbSearchStudVio.Enabled = false;
            tbSearchStudVio.Text = tbStudentNumber.Text;
           
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();

            // btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = true;
            tbStudentNumber.Enabled = false;
            tbViolationID.Enabled = false;
            cbViolation.Enabled = false;
            dtViolationDateTime.Enabled = false;
            rbSettled.Enabled = false;
            rbUnsettled.Enabled = false;
            dtDateSettled.Enabled = false;
            tbViolationID.Text = dataGridView2.SelectedRows[0].Cells["Violation_ID"].Value.ToString();
            tbStudentNumber.Text = dataGridView2.SelectedRows[0].Cells["Student_ID"].Value.ToString();
            cbViolation.SelectedValue = dataGridView2.SelectedRows[0].Cells["Violation_Name_ID"].Value.ToString();
            //dtViolationDateTime.Value = dataGridView2.SelectedRows[0].Cells["Violation_Date_Time"].Value;
            dtViolationDateTime.Value = Convert.ToDateTime(dataGridView2.SelectedRows[0].Cells["Violation_Date_Time"].Value.ToString());
            string strViolationStat = dataGridView2.SelectedRows[0].Cells["Violation_Status"].Value.ToString();
            if (strViolationStat == "Unsettled")
            {
                rbUnsettled.Checked = true;
                dtDateSettled.Enabled = false;
            }
            else
                rbSettled.Checked = true;
                dtDateSettled.Enabled = false;

            dtDateSettled.Value = Convert.ToDateTime(dataGridView2.SelectedRows[0].Cells["Violation_DateSettled"].Value.ToString());
        }


        void comboBoxContents()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();

            try
            {
                string cbxSQL = "SELECT Violation_Name_ID, '['+ Violation_Type + '] ' + Violation_Name AS VIOLATIONS FROM VIOLATIONINFO";
                SqlCommand cmd = new SqlCommand(cbxSQL, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cbViolation.DataSource = dt;
                    cbViolation.DisplayMember = "VIOLATIONS";
                    cbViolation.ValueMember = "Violation_Name_ID";
                }//if
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "ComboBox for Violation Exception");
            }

        }

        private void rbUnsettled_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUnsettled.Checked == true)
            {
                rbSettled.Checked = false;
                dtDateSettled.Enabled = false;
            }
        }

        private void rbSettled_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSettled.Checked == true)
            {
                rbUnsettled.Checked = false;
                dtDateSettled.Enabled = true;
            }
        }

        string strQuerySettled = "SELECT DISTINCT VIOLATION.Violation_ID, VIOLATION.Student_ID, VIOLATION.Violation_Name_ID, VIOLATION.Violation_Date_Time, VIOLATION.Violation_Status, VIOLATION.Violation_DateSettled FROM VIOLATION, STUDENT WHERE VIOLATION.Student_ID LIKE '%'+@STUDNO+'%' AND Violation_Status = 'Settled'";
        string strQueryUnsettled = "SELECT DISTINCT VIOLATION.Violation_ID, VIOLATION.Student_ID, VIOLATION.Violation_Name_ID, VIOLATION.Violation_Date_Time, VIOLATION.Violation_Status, VIOLATION.Violation_DateSettled FROM VIOLATION, STUDENT WHERE VIOLATION.Student_ID LIKE '%'+@STUDNO+'%' AND Violation_Status = 'Unsettled'";
        string strQueryBothChk = "SELECT DISTINCT VIOLATION.Violation_ID, VIOLATION.Student_ID, VIOLATION.Violation_Name_ID, VIOLATION.Violation_Date_Time, VIOLATION.Violation_Status, VIOLATION.Violation_DateSettled FROM VIOLATION, STUDENT WHERE VIOLATION.Student_ID LIKE '%'+@STUDNO+'%'";

        private void chkSettled_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSettled.Checked == true)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(strQuerySettled, con);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearchStudVio.Text));
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0].DefaultView;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                }
            }

            else if (chkUnsettled.Checked == false)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(strQueryBothChk, con);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearchStudVio.Text));
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0].DefaultView;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                }
            }

            if (chkSettled.Checked == true && chkUnsettled.Checked == true)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(strQueryBothChk, con);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearchStudVio.Text));
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0].DefaultView;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                }
            }

            if (chkSettled.Checked == false && chkUnsettled.Checked == true)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(strQueryUnsettled, con);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearchStudVio.Text));
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0].DefaultView;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                }
            }


        }

        private void chkUnsettled_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnsettled.Checked == true)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(strQueryUnsettled, con);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearchStudVio.Text));
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0].DefaultView;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                }
            }

            else if (chkSettled.Checked == false)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(strQueryBothChk, con);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearchStudVio.Text));
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0].DefaultView;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                }
            }

            if (chkUnsettled.Checked == true && chkSettled.Checked == true)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(strQueryBothChk, con);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearchStudVio.Text));
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0].DefaultView;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                }
            }

            if (chkUnsettled.Checked == false && chkSettled.Checked == true)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(strQuerySettled, con);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearchStudVio.Text));
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0].DefaultView;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                }
            }


        }





       



       

       
       

       

       

    }
}
