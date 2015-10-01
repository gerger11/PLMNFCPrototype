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
    public partial class Form_Colleges : Form
    {
        string conect = String.Empty;
        string strEditHolder = String.Empty;

        private string strUserIDval;
        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }

        public Form_Colleges()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;
        }

        void views()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT College_ID, College_Name, College_Abbreviation FROM COLLEGE", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Columns[0].Visible = true;
            con.Close();
        }

        private void Form_Colleges_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;

            tbCollegeID.Enabled = false;
            tbCollegeName.Enabled = false;

            lblUserID_Colleges.Text = "" + strUserIDval;
            views();
        }//FormLoad Method

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = true;
            tbCollegeID.Enabled = false;
            tbCollegeName.Enabled = false;
            tbAbbreviation.Enabled = false;
            tbCollegeID.Text = dataGridView1.SelectedRows[0].Cells["College_ID"].Value.ToString();
            tbCollegeName.Text = dataGridView1.SelectedRows[0].Cells["College_Name"].Value.ToString();
            tbAbbreviation.Text = dataGridView1.SelectedRows[0].Cells["College_Abbreviation"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCollegeID.Text.Length == 0 && tbCollegeName.Text.Length == 0 && tbAbbreviation.Text.Length == 0)
            {
                MainForm mainForm = new MainForm();
                mainForm.strPassedUserID = lblUserID_Colleges.Text; 
                mainForm.Show();
                this.Close();
            }//if
            else
            {
                DialogResult dialog = MessageBox.Show("There are unsaved data in the form. Close this form?", "Close Colleges Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.strPassedUserID = lblUserID_Colleges.Text;
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
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            tbCollegeID.Clear();
            tbCollegeName.Clear();
            tbAbbreviation.Clear();
            tbCollegeID.Enabled = false;
            tbCollegeName.Enabled = false;
            tbAbbreviation.Enabled = false;
            lblEdit.Text = "-----";
        }//Clear Button

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT College_ID, College_Name, College_Abbreviation FROM COLLEGE WHERE College_Abbreviation LIKE '%'+@name+'%' OR College_Name LIKE '%'+@name2+'%'", con);
            da.SelectCommand.Parameters.Add(new SqlParameter("@name", tbSearch.Text));
            da.SelectCommand.Parameters.Add(new SqlParameter("@name2", tbSearch.Text));
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //add = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
            tbCollegeID.Enabled = true;
            tbCollegeName.Enabled = true;
            tbAbbreviation.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            strEditHolder = tbCollegeID.Text;
            btnAdd.Enabled = false;
            tbCollegeID.Enabled = true;
            tbCollegeName.Enabled = true;
            tbAbbreviation.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            lblEdit.Text = tbCollegeID.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCollegeID.Text) || string.IsNullOrEmpty(tbCollegeName.Text) || string.IsNullOrEmpty(tbAbbreviation.Text) || string.IsNullOrWhiteSpace(tbCollegeID.Text) || string.IsNullOrWhiteSpace(tbCollegeName.Text) || string.IsNullOrWhiteSpace(tbAbbreviation.Text))
            {
                MessageBox.Show("The fields should not be null or empty. Supply valid data.", "Add College", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
            }
            else if (lblEdit.Text == strEditHolder)
            {
                SqlConnection con = new SqlConnection(conect);
                if (con.State != ConnectionState.Open)
                    con.Open();

                DialogResult dialog = MessageBox.Show("Do you want to update the record for this College?\nCOLLEGE : " + tbCollegeName.Text, "Update College", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    SqlCommand updateViolationCMD = new SqlCommand("UPDATE COLLEGE SET College_ID = '" + tbCollegeID.Text + "', College_Name = '" + tbCollegeName.Text + "', College_Abbreviation = '" + tbAbbreviation.Text + "' WHERE College_ID = '" + lblEdit.Text + "'", con);
                    updateViolationCMD.Parameters.AddWithValue("@COLID", tbCollegeID.Text);
                    updateViolationCMD.Parameters.AddWithValue("@COLNAME", tbCollegeName.Text);
                    updateViolationCMD.Parameters.AddWithValue("@ABBREV", tbAbbreviation.Text);
                    int ctr = updateViolationCMD.ExecuteNonQuery();
                    MessageBox.Show("College Record for " + tbCollegeID.Text + " has been updated!", "Update Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender, e);
                    tbSearch_TextChanged_1(sender, e);
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
                    SqlCommand insertStudCMD = new SqlCommand("INSERT INTO COLLEGE(College_ID, College_Name, College_Abbreviation) VALUES (@COLID, @COLNAME, @ABBREV)", con);
                    insertStudCMD.Parameters.AddWithValue("@COLID", tbCollegeID.Text);
                    insertStudCMD.Parameters.AddWithValue("@COLNAME", tbCollegeName.Text);
                    insertStudCMD.Parameters.AddWithValue("@ABBREV", tbAbbreviation.Text);
                    int ctr = insertStudCMD.ExecuteNonQuery();
                    MessageBox.Show(ctr.ToString() + " record(s) saved");
                    btnClear_Click(sender, e);
                    tbSearch_TextChanged_1(sender, e);
                }
                else
                {
                    con.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Are you sure you want to delete this data?", "Deletion Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diag == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from COLLEGE WHERE College_ID = '" + tbCollegeID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is deleted.", "Deletion Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
                tbSearch_TextChanged_1(sender, e);
            }
        }//Search textbox
    }
}
