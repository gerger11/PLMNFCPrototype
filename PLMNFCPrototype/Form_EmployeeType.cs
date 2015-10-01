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
    public partial class Form_EmployeeType : Form
    {
        string conect = String.Empty;
        string strEditHolder = String.Empty;

        private string strUserIDval;
        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }
        public Form_EmployeeType()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;
        }

        private void Form_EmployeeType_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;

            tbEmpTypeID.Enabled = false;
            tbEmpTypeName.Enabled = false;

            lblUserID_EmpType.Text = "" + strUserIDval;
            views();
        }//FormLoad Method

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_Type_ID, Employee_Type_Name FROM EMPLOYEETYPE WHERE Employee_Type_Name LIKE '%'+@name+'%'", con);
            da.SelectCommand.Parameters.Add(new SqlParameter("@name", tbSearch.Text));
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }//tbSearch TextChanged method

        void views()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_Type_ID, Employee_Type_Name FROM EMPLOYEETYPE", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Columns[0].Visible = true;
            con.Close();
        }//views() method - used to query contents of EMPLOYEETYPE table

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = true;

            tbEmpTypeID.Enabled = false;
            tbEmpTypeName.Enabled = false;
            tbEmpTypeID.Text = dataGridView1.SelectedRows[0].Cells["Employee_Type_ID"].Value.ToString();
            tbEmpTypeName.Text = dataGridView1.SelectedRows[0].Cells["Employee_Type_Name"].Value.ToString();
        }//dataGrid Cell Click Method

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = true;
            tbEmpTypeID.Enabled = false;
            tbEmpTypeID.Text = dataGridView1.SelectedRows[0].Cells["Employee_Type_ID"].Value.ToString();
            tbEmpTypeName.Text = dataGridView1.SelectedRows[0].Cells["Employee_Type_Name"].Value.ToString();
        }//dataGrid KeyDown Method

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = true;
            tbEmpTypeID.Enabled = false;
            tbEmpTypeID.Text = dataGridView1.SelectedRows[0].Cells["Employee_Type_ID"].Value.ToString();
            tbEmpTypeName.Text = dataGridView1.SelectedRows[0].Cells["Employee_Type_Name"].Value.ToString();
        }//dataGrid KeyUp Method


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbEmpTypeID.Text.Length == 0 && tbEmpTypeName.Text.Length == 0)
            {
                MainForm mainForm = new MainForm();
                mainForm.strPassedUserID = lblUserID_EmpType.Text; 
                mainForm.Show();
                this.Close();
            }//if
            else
            {
                DialogResult dialog = MessageBox.Show("There are unsaved data in the form. Close this form?", "Close Employee Type Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.strPassedUserID = lblUserID_EmpType.Text; 
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    //Do Nothing
                }
            }//else
        }//Close Button

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEmpTypeID.Clear();
            tbEmpTypeName.Clear();

            btnClear.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            tbEmpTypeID.Enabled = false;
            tbEmpTypeName.Enabled = false;

            lblEdit.Text = "-----";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbEmpTypeID.Text) || string.IsNullOrWhiteSpace(tbEmpTypeName.Text) || string.IsNullOrEmpty(tbEmpTypeID.Text) || string.IsNullOrEmpty(tbEmpTypeName.Text))
                {
                    MessageBox.Show("The fields should not be null or empty. Supply valid data.", "Add Employee Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender, e);
                }

                else if (lblEdit.Text == strEditHolder)
                {
                    SqlConnection con = new SqlConnection(conect);
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    //SqlCommand cmd1 = new SqlCommand("UPDATE Employee SET FName = @fname, Mname = @midname, Lname = @Lastname , landlineno = @landline, mobileno = @mobileno, emailadd = @email,Gender = '" + strGender + "', birthdate = '" + dtpBirthDate.Value.ToShortDateString() + "', licenseNo =  '" + txtLicense.Text + "', dateofEmployment = '" + dtpEmployment.Value.ToShortDateString() + "', employeetypeid = '" + strEmployeeType + "' WHERE EmployeeId = '" + lblEmpID.Text + "'", con);

                    DialogResult dialog = MessageBox.Show("Do you want to update the record for this Course?\nEMPLOYEE TYPE : " + tbEmpTypeName.Text, "Update Employee Type", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        SqlCommand updateCourseCMD = new SqlCommand("UPDATE EMPLOYEETYPE SET Employee_Type_ID = '" + tbEmpTypeID.Text + "', Employee_Type_Name = '" + tbEmpTypeName.Text + "' WHERE Employee_Type_ID = '" + lblEdit.Text + "'", con);
                        updateCourseCMD.Parameters.AddWithValue("@EMPTYPEID", tbEmpTypeID.Text);
                        updateCourseCMD.Parameters.AddWithValue("@EMPTYPENAME", tbEmpTypeName.Text);

                        int ctr = updateCourseCMD.ExecuteNonQuery();
                        MessageBox.Show("Employee Type Record for " + tbEmpTypeID.Text + " has been updated!", "Update Employee Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear_Click(sender, e);
                        tbSearch_TextChanged(sender, e);
                    }
                    else
                    {
                        //Do Nothing
                    }
                }

                else if (lblEdit.Text == "-----")
                {
                    SqlConnection con = new SqlConnection(conect);
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        SqlCommand insertEmpTypeCMD = new SqlCommand("INSERT INTO EMPLOYEETYPE(Employee_Type_ID, Employee_Type_Name) VALUES (@EMPTYPEID, @EMPTYPENAME)", con);
                        insertEmpTypeCMD.Parameters.AddWithValue("@EMPTYPEID", tbEmpTypeID.Text);
                        insertEmpTypeCMD.Parameters.AddWithValue("@EMPTYPENAME", tbEmpTypeName.Text);
                      

                        int ctr = insertEmpTypeCMD.ExecuteNonQuery();
                        MessageBox.Show(ctr.ToString() + " record(s) saved");
                        btnClear_Click(sender, e);
                        tbSearch_TextChanged(sender, e);
                    }
                    else
                    {
                        con.Close();
                    }
                }
            }//try
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            strEditHolder = tbEmpTypeID.Text;
            lblEdit.Text = tbEmpTypeID.Text;

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            tbEmpTypeID.Enabled = true;
            tbEmpTypeName.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;

            tbEmpTypeID.Enabled = true;
            tbEmpTypeName.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Are you sure you want to delete this data?", "Deletion Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); 
            if (diag == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from EMPLOYEETYPE WHERE Employee_Type_ID = '" + tbEmpTypeID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is deleted.", "Deletion Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
                tbSearch_TextChanged(sender, e);
            }
        }


    }
}
