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
    public partial class Form_Courses : Form
    {
        string conect = String.Empty;
        string strEditHolder = String.Empty;

        private string strUserIDval;
        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }

        public Form_Courses()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;
        }

        void views()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Course_ID, Course_Name, Course_Abbrev, College_ID FROM COURSE", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Columns[0].Visible = true;
            con.Close();
        }

        //this method is for feeding of College Names to ComboBox
        void comboBoxContents()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            try
            {
                string cbxSQL = "SELECT College_ID, College_Name FROM COLLEGE";
                SqlCommand cmd = new SqlCommand(cbxSQL, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cbxCollege.DataSource = dt;
                    cbxCollege.DisplayMember = "College_Name";
                    cbxCollege.ValueMember = "College_ID";
                }//if
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "ComboBox for College Exception");
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Course_ID, Course_Name, Course_Abbrev, College_ID FROM COURSE WHERE Course_Abbrev LIKE '%'+@abbrev+'%' OR Course_Name LIKE '%'+@name+'%' OR College_ID LIKE '%'+@colid+'%'", con);
            
            da.SelectCommand.Parameters.Add(new SqlParameter("@name", tbSearch.Text));
            da.SelectCommand.Parameters.Add(new SqlParameter("@abbrev", tbSearch.Text));
            da.SelectCommand.Parameters.Add(new SqlParameter("@colid", tbSearch.Text));
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void Form_Courses_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;

            tbCourseID.Enabled = false;
            tbCourseName.Enabled = false;
            tbAbbreviation.Enabled = false;
            cbxCollege.Enabled = false;

            lblUserID_Courses.Text = "" + strUserIDval;
            views();
            comboBoxContents();
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
            
            tbCourseID.Enabled = false;
            tbCourseName.Enabled = false;
            tbAbbreviation.Enabled = false;
            cbxCollege.Enabled = false;
            
            tbCourseID.Text = dataGridView1.SelectedRows[0].Cells["Course_ID"].Value.ToString();
            tbCourseName.Text = dataGridView1.SelectedRows[0].Cells["Course_Name"].Value.ToString();
            tbAbbreviation.Text = dataGridView1.SelectedRows[0].Cells["Course_Abbrev"].Value.ToString();
            cbxCollege.SelectedValue = dataGridView1.SelectedRows[0].Cells["College_ID"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCourseID.Text.Length == 0 && tbCourseName.Text.Length == 0 && tbAbbreviation.Text.Length == 0)
            {
                MainForm mainForm = new MainForm();
                mainForm.strPassedUserID = lblUserID_Courses.Text;
                mainForm.Show();
                this.Close();
            }//if
            else
            {
                DialogResult dialog = MessageBox.Show("There are unsaved data in the form. Close this form?", "Close Course Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                    MainForm mainForm = new MainForm();
                    mainForm.strPassedUserID = lblUserID_Courses.Text;
                    mainForm.Show();
                }
                else
                {
                    //do nothing
                }
            }//else
        }//closeButton

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCourseID.Clear();
            tbCourseName.Clear();
            tbAbbreviation.Clear();
            
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            
            tbCourseID.Enabled = false;
            tbCourseName.Enabled = false;
            tbAbbreviation.Enabled = false;
            cbxCollege.Enabled = false;
            cbxCollege.SelectedText = "";
            lblEdit.Text = "-----";
        }//clear button

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = true;
            tbCourseID.Enabled = false;
            tbCourseName.Enabled = false;
            tbAbbreviation.Enabled = false;
            cbxCollege.Enabled = false;
            tbCourseID.Text = dataGridView1.SelectedRows[0].Cells["Course_ID"].Value.ToString();
            tbCourseName.Text = dataGridView1.SelectedRows[0].Cells["Course_Name"].Value.ToString();
            tbAbbreviation.Text = dataGridView1.SelectedRows[0].Cells["Course_Abbrev"].Value.ToString();
            cbxCollege.SelectedValue = dataGridView1.SelectedRows[0].Cells["College_ID"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbCourseID.Text) || string.IsNullOrEmpty(tbCourseName.Text) || string.IsNullOrEmpty(tbAbbreviation.Text) || string.IsNullOrWhiteSpace(tbCourseID.Text) || string.IsNullOrWhiteSpace(tbCourseName.Text) || string.IsNullOrWhiteSpace(tbAbbreviation.Text))
                {
                    MessageBox.Show("The fields should not be null or empty. Supply valid data.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender, e);
                }

                else if (lblEdit.Text == strEditHolder)
                {
                    SqlConnection con = new SqlConnection(conect);
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    
                    DialogResult dialog = MessageBox.Show("Do you want to update the record for this Course?\nCOURSE : " + tbCourseName.Text, "Update College", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        SqlCommand updateCourseCMD = new SqlCommand("UPDATE COURSE SET Course_ID = '" + tbCourseID.Text + "', Course_Name = '" + tbCourseName.Text + "', Course_Abbrev = '" + tbAbbreviation.Text + "', College_ID = '" + cbxCollege.SelectedValue + "' WHERE Course_ID = '" + lblEdit.Text + "'", con);
                        updateCourseCMD.Parameters.AddWithValue("@CORID", tbCourseID.Text);
                        updateCourseCMD.Parameters.AddWithValue("@CORNAME", tbCourseName.Text);
                        updateCourseCMD.Parameters.AddWithValue("@ABBREV", tbAbbreviation.Text);
                        updateCourseCMD.Parameters.AddWithValue("@COLID", cbxCollege.SelectedValue);

                        int ctr = updateCourseCMD.ExecuteNonQuery();
                        MessageBox.Show("Course Record for " + tbCourseID.Text + " has been updated!", "Update Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        SqlCommand insertCourseCMD = new SqlCommand("INSERT INTO COURSE(Course_ID, Course_Name, Course_Abbrev, College_ID) VALUES (@CORID, @CORNAME, @ABBREV, @COLID)", con);
                        insertCourseCMD.Parameters.AddWithValue("@CORID", tbCourseID.Text);
                        insertCourseCMD.Parameters.AddWithValue("@CORNAME", tbCourseName.Text);
                        insertCourseCMD.Parameters.AddWithValue("@ABBREV", tbAbbreviation.Text);
                        insertCourseCMD.Parameters.AddWithValue("@COLID", cbxCollege.SelectedValue);

                        int ctr = insertCourseCMD.ExecuteNonQuery();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;

            tbCourseID.Enabled = true;
            tbCourseName.Enabled = true;
            tbAbbreviation.Enabled = true;
            cbxCollege.Enabled = true;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            strEditHolder = tbCourseID.Text;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            tbCourseID.Enabled = false;
            tbCourseName.Enabled = true;
            tbAbbreviation.Enabled = true;
            cbxCollege.Enabled = true;
            lblEdit.Text = tbCourseID.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Are you sure you want to delete this data?", "Deletion Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diag == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from COURSE WHERE Course_ID = '" + tbCourseID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is deleted.", "Deletion Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
                tbSearch_TextChanged(sender, e);
            }
        }
    }
}
