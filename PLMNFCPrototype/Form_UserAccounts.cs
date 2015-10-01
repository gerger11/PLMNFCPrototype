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
    public partial class Form_UserAccounts : Form
    {
        string conect = String.Empty;
        string strAccountIsActive = "";

        private string strUserIDval;
        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }

        public Form_UserAccounts()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;
        }

        private void Form_UserAccounts_Load(object sender, EventArgs e)
        {
            lblUserID_UserAccounts.Text = "" + strUserIDval;
            views();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                tbEmployee.Enabled = false;
                tbEmployee.Text = dataGridView2.SelectedRows[0].Cells["Employee ID"].Value.ToString();
                tbSearchAccounts.Text = dataGridView2.SelectedRows[0].Cells["Employee ID"].Value.ToString();
               // trackAndCountViolation();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        void views()
        {
            try
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT USERACCOUNTS.Account_ID, EMPLOYEE.Employee_ID, EMPLOYEE.Employee_Fname, EMPLOYEE.Employee_LName, USERACCOUNTS.Password, USERACCOUNTS.Status FROM USERACCOUNTS, EMPLOYEE WHERE EMPLOYEE.Employee_ID = USERACCOUNTS.Employee_ID", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                //     dataGridView1.ClearSelection();
                dataGridView1.Columns[0].Visible = true;

                SqlDataAdapter da2 = new SqlDataAdapter("SELECT EMPLOYEE.Employee_ID AS [Employee ID], EMPLOYEE.Employee_LName AS [Last Name], EMPLOYEE.Employee_FName AS [First Name] FROM EMPLOYEE", con);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                dataGridView2.DataSource = ds2.Tables[0].DefaultView;
                //     dataGridView1.ClearSelection();
                dataGridView2.Columns[0].Visible = true;
                con.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
            
        }

        //Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conect);
                if (con.State != ConnectionState.Open)
                {
                    if (lblValidatePassword.Text == "Password matched!")
                    {
                        con.Open();
                        if (chkIsActiveAccount.Checked == true)
                            strAccountIsActive = "Active";
                        else
                            strAccountIsActive = "Inactive";

                        SqlCommand insertViolationCMD = new SqlCommand("INSERT INTO USERACCOUNTS(Account_ID, Employee_ID, Password, Status) VALUES (@ACCTID, @EMPLID, @PASS, @STAT)", con);
                        insertViolationCMD.Parameters.AddWithValue("@ACCTID", tbUsername.Text);
                        insertViolationCMD.Parameters.AddWithValue("@EMPLID", tbEmployee.Text);
                        insertViolationCMD.Parameters.AddWithValue("@PASS", tbPassword.Text);
                        insertViolationCMD.Parameters.AddWithValue("@STAT", strAccountIsActive);

                        int ctr = insertViolationCMD.ExecuteNonQuery();
                        MessageBox.Show(ctr.ToString() + " record(s) saved", "User Accounts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("All fields are required. Do not forget to validate password before saving.", "User Accounts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tbEmployee.Text.Length == 0)
            {

                MainForm mainForm = new MainForm();
                mainForm.strPassedUserID = lblUserID_UserAccounts.Text; 

                mainForm.Show();
                this.Close();


            }//if
            else
            {
                DialogResult dialog = MessageBox.Show("There are unsaved data in the form. Close this form?", "Close User Accounts Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    //Do Nothing
                }
            }//else
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID AS [Employee ID], Employee_LName AS [Last Name], Employee_FName AS [First Name] FROM EMPLOYEE WHERE Employee_LName LIKE '%'+@lastname+'%' OR Employee_ID LIKE '%'+@emplid+'%'", con);
                da.SelectCommand.Parameters.Add(new SqlParameter("@lastname", tbSearchEmployee.Text));
                da.SelectCommand.Parameters.Add(new SqlParameter("@emplid", tbSearchEmployee.Text));
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

        private void tbSearchAccounts_TextChanged(object sender, EventArgs e)
        {

            //DEV COMMENTS:
            //Implement Datagrid Cell Click, Feed to Textboxes

            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT USERACCOUNTS.Account_ID, EMPLOYEE.Employee_ID, EMPLOYEE.Employee_Fname, EMPLOYEE.Employee_LName, USERACCOUNTS.Password, USERACCOUNTS.Status FROM USERACCOUNTS, EMPLOYEE WHERE EMPLOYEE.Employee_ID = USERACCOUNTS.Employee_ID AND USERACCOUNTS.Employee_ID = " + "'" + tbSearchAccounts.Text + "'", con);
            
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("There is no user account record for this employee. You can add a user account from this module.", "User Accounts", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (tbPassword.Text != tbRetypePassword.Text)
            {
                lblValidatePassword.Show();
                lblValidatePassword.ForeColor = Color.Red;
                lblValidatePassword.Text = "Password did not match!";
            }

            if (tbPassword.Text == tbRetypePassword.Text)
            {
                if (tbPassword.Text.Length > 0 && tbRetypePassword.Text.Length > 0)
                {
                    lblValidatePassword.Show();
                    lblValidatePassword.ForeColor = Color.Green;
                    lblValidatePassword.Text = "Password matched!";
                }

                else if (!string.IsNullOrEmpty(tbPassword.Text) == !string.IsNullOrEmpty(tbRetypePassword.Text))
                {
                    lblValidatePassword.Show();
                    lblValidatePassword.ForeColor = Color.Red;
                    lblValidatePassword.Text = "Password fields null or empty!";
                }
                
            }
           
        }

        private void chkIsActiveAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsActiveAccount.Checked == true)
                strAccountIsActive = "Active";
            else
                strAccountIsActive = "Inactive";
        }
    }
}
