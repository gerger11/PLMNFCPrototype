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
    public partial class Form_ViolationInfo : Form
    {
        string conect = String.Empty;
        string strEditHolder = String.Empty;

        private string strUserIDval;
        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }

        public Form_ViolationInfo()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;
        }

        void views()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Violation_Name_ID, Violation_Name, Violation_Type, Violation_SanctionPenalty FROM VIOLATIONINFO", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //     dataGridView1.ClearSelection();
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

            tbViolationInfoID.Enabled = false;
            tbViolationName.Enabled = false;
            cbxViolationType.Enabled = false;
            tbSanction.Enabled = false;

            tbViolationInfoID.Text = dataGridView1.SelectedRows[0].Cells["Violation_Name_ID"].Value.ToString();
            tbViolationName.Text = dataGridView1.SelectedRows[0].Cells["Violation_Name"].Value.ToString();
            cbxViolationType.SelectedValue = dataGridView1.SelectedRows[0].Cells["Violation_Type"].Value.ToString();
            tbSanction.Text = dataGridView1.SelectedRows[0].Cells["Violation_SanctionPenalty"].Value.ToString();
            //implement combobox fetching here
           
        }

        private void Form_ViolationInfo_Load(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);

            lblUserID_ViolationInfo.Text = "" + strUserIDval;
            views();
            comboBoxContents();
        }
        void comboBoxContents()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            try
            {
                string cbxSQL = "SELECT DISTINCT Violation_Type FROM VIOLATIONINFO";
                SqlCommand cmd = new SqlCommand(cbxSQL, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cbxViolationType.DataSource = dt;
                    cbxViolationType.DisplayMember = "Violation_Type";
                    cbxViolationType.ValueMember = "Violation_Type";
                }//if
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "ComboBox for Violation Exception");
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Violation_Name_ID, Violation_Name, Violation_Type, Violation_SanctionPenalty FROM VIOLATIONINFO WHERE Violation_Name LIKE '%'+@name+'%' OR Violation_Type LIKE '%'+@type+'%'", con);
            da.SelectCommand.Parameters.Add(new SqlParameter("@name", tbSearch.Text));
            da.SelectCommand.Parameters.Add(new SqlParameter("@type", tbSearch.Text));
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbViolationInfoID.Text.Length == 0 && tbViolationName.Text.Length == 0 && tbSanction.Text.Length == 0)
            {
                
                MainForm mainForm = new MainForm();
                mainForm.strPassedUserID = lblUserID_ViolationInfo.Text; 
                mainForm.Show();
                this.Close();
            }//if
            else
            {
                DialogResult dialog = MessageBox.Show("There are unsaved data in the form. Close this form?", "Close Violation Information Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.strPassedUserID = lblUserID_ViolationInfo.Text; 
                    mainForm.Show();
                    this.Close();
                }
                else
                {

                }
            }//else
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;

            tbViolationInfoID.Enabled = true;
            tbViolationName.Enabled = true;
            cbxViolationType.Enabled = true;
            tbSanction.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbViolationInfoID.Text) || string.IsNullOrEmpty(tbViolationName.Text) || string.IsNullOrEmpty(tbSanction.Text) || string.IsNullOrWhiteSpace(tbViolationInfoID.Text) || string.IsNullOrWhiteSpace(tbViolationName.Text) || string.IsNullOrWhiteSpace(tbSanction.Text))
                {
                    MessageBox.Show("The fields should not be null or empty. Supply valid data.", "Add Violation Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender, e);
                }
                else if (lblEdit.Text == strEditHolder)
                {
                    SqlConnection con = new SqlConnection(conect);
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    //SqlCommand cmd1 = new SqlCommand("UPDATE Employee SET FName = @fname, Mname = @midname, Lname = @Lastname , landlineno = @landline, mobileno = @mobileno, emailadd = @email,Gender = '" + strGender + "', birthdate = '" + dtpBirthDate.Value.ToShortDateString() + "', licenseNo =  '" + txtLicense.Text + "', dateofEmployment = '" + dtpEmployment.Value.ToShortDateString() + "', employeetypeid = '" + strEmployeeType + "' WHERE EmployeeId = '" + lblEmpID.Text + "'", con);

                    DialogResult dialog = MessageBox.Show("Do you want to update the record for this Violation Information?\nVIOLATION INFO : " + tbViolationName.Text, "Update Violation Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        SqlCommand updateViolationInfCMD = new SqlCommand("UPDATE VIOLATIONINFO SET Violation_Name_ID = '" + tbViolationInfoID.Text + "', Violation_Name = '" + tbViolationName.Text + "', Violation_Type = '" + cbxViolationType.SelectedValue + "', Violation_SanctionPenalty = '" + tbSanction.Text + "' WHERE Violation_Name_ID = '" + lblEdit.Text + "'", con);
                        updateViolationInfCMD.Parameters.AddWithValue("@VIOINFID", tbViolationInfoID.Text);
                        updateViolationInfCMD.Parameters.AddWithValue("@VIONAME", tbViolationName.Text);
                        updateViolationInfCMD.Parameters.AddWithValue("@VIOTYPE", cbxViolationType.SelectedValue);
                        updateViolationInfCMD.Parameters.AddWithValue("@VIOSANCTION", tbSanction.Text);

                        int ctr = updateViolationInfCMD.ExecuteNonQuery();
                        MessageBox.Show("Course Record for " + tbViolationInfoID.Text + " has been updated!", "Update Violation Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        SqlCommand insertViolationInfoCMD = new SqlCommand("INSERT INTO VIOLATIONINFO(Violation_Name_ID, Violation_Name, Violation_Type, Violation_SanctionPenalty) VALUES (@VIOINFID, @VIONAME, @VIOTYPE, @VIOSANCTION)", con);
                        insertViolationInfoCMD.Parameters.AddWithValue("@VIOINFID", tbViolationInfoID.Text);
                        insertViolationInfoCMD.Parameters.AddWithValue("@VIONAME", tbViolationName.Text);
                        insertViolationInfoCMD.Parameters.AddWithValue("@VIOTYPE", cbxViolationType.SelectedValue);
                        insertViolationInfoCMD.Parameters.AddWithValue("@VIOSANCTION", tbSanction.Text);

                        int ctr = insertViolationInfoCMD.ExecuteNonQuery();
                        MessageBox.Show(ctr.ToString() + " record(s) saved");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            tbViolationInfoID.Clear();
            tbViolationName.Clear();
            tbSanction.Clear();

            tbViolationInfoID.Enabled = false;
            tbViolationName.Enabled = false;
            tbSanction.Enabled = false;
            cbxViolationType.Enabled = false;
            lblEdit.Text = "-----";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            strEditHolder = tbViolationInfoID.Text;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            tbViolationInfoID.Enabled = true;
            tbViolationName.Enabled = true;
            tbSanction.Enabled = true;
            cbxViolationType.Enabled = true;
            lblEdit.Text = tbViolationInfoID.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Are you sure you want to delete this data?", "Deletion Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diag == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from VIOLATIONINFO WHERE Violation_Name_ID = '" + tbViolationInfoID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is deleted.", "Deletion Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
                tbSearch_TextChanged(sender, e);
            }
        }
    }
}
