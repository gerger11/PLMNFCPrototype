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
    public partial class Form_EmployeeInformation : Form
    {
        string conect = String.Empty;
        string imageLoc = "";

        private string strUserIDval;
        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }

        public Form_EmployeeInformation()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;
        }
        void views()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID, Employee_FName, Employee_MName, Employee_LName, Employee_Gender, Employee_Birthdate, Employee_Add_Street, Employee_Add_Subdivision, Employee_Add_CityProvince, Employee_Add_Zipcode, Employee_ContactNo, Employee_EmailAdd, Employee_Type_ID, Employee_DateofEmployment, Employee_Image FROM EMPLOYEE", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Columns[0].Visible = true;
            con.Close();
        }

        void comboBoxContents()
        {
            SqlConnection con = new SqlConnection(conect);
            con.Open();
            try
            {
                string cbxSQL = "SELECT Employee_Type_ID, Employee_Type_Name FROM EMPLOYEETYPE";
                SqlCommand cmd = new SqlCommand(cbxSQL, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cbxEmployeeType.DataSource = dt;
                    cbxEmployeeType.DisplayMember = "Employee_Type_Name";
                    cbxEmployeeType.ValueMember = "Employee_Type_ID";
                }//if
            }//try

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "ComboBox for Employee Information Exception");
                con.Close();
            }
        }

        private void Form_EmployeeInformation_Load(object sender, EventArgs e)
        {
            views();
            comboBoxContents();
            lblUserID_EmpInfo.Text = "" + strUserIDval;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnBrowsePic.Enabled = true;
            btnUploadPic.Enabled = false;


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
                byte[] img = null;
                FileStream fStream = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
                BinaryReader binRead = new BinaryReader(fStream);
                img = binRead.ReadBytes((int)fStream.Length); //image parsing

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
                {
                    con.Open();
                    SqlCommand insertStudCMD = new SqlCommand("INSERT INTO EMPLOYEE(Employee_ID, Employee_FName, Employee_MName, Employee_LName, Employee_Gender, Employee_Birthdate, Employee_Add_Street, Employee_Add_Subdivision, Employee_Add_CityProvince, Employee_Add_Zipcode, Employee_Type_ID, Employee_DateofEmployment, Employee_ContactNo, Employee_EmailAdd, Employee_Image) VALUES (@EMPNO, @FNAME, @MNAME, @LNAME, @GENDER, @BDAY, @STREET, @SUBDIV, @CITYPROV, @ZIP, @EMPTYPE, @DATEMP, @CONTACTNO, @EMAIL, @EMPIC)", con);
                    insertStudCMD.Parameters.AddWithValue("@EMPNO", tbEmployeeNumber.Text);
                    insertStudCMD.Parameters.AddWithValue("@FNAME", tbFName.Text);
                    insertStudCMD.Parameters.AddWithValue("@MNAME", tbMName.Text);
                    insertStudCMD.Parameters.AddWithValue("@LNAME", tbLName.Text);
                    insertStudCMD.Parameters.AddWithValue("@GENDER", strGender);
                    insertStudCMD.Parameters.AddWithValue("@BDAY", dateTimePicker1.Value);
                    insertStudCMD.Parameters.AddWithValue("@STREET", tbStreet.Text);
                    insertStudCMD.Parameters.AddWithValue("@SUBDIV", tbSubdivision.Text);
                    insertStudCMD.Parameters.AddWithValue("@CITYPROV", tbCity.Text);
                    insertStudCMD.Parameters.AddWithValue("@ZIP", tbZipcode.Text);
                    insertStudCMD.Parameters.AddWithValue("@EMPTYPE", cbxEmployeeType.SelectedValue);
                    insertStudCMD.Parameters.AddWithValue("@DATEMP", dateTimePicker2.Value);
                    insertStudCMD.Parameters.AddWithValue("@CONTACTNO", tbContactNo.Text);
                    insertStudCMD.Parameters.AddWithValue("@EMAIL", tbEmailAdd.Text);

                    insertStudCMD.Parameters.AddWithValue("@EMPIC", img);
                    int ctr = insertStudCMD.ExecuteNonQuery();
                    MessageBox.Show(ctr.ToString() + " record(s) saved");
                }
                else
                {
                    con.Close();
                }

                //implement insert query here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
                //con.Close();
            }//catch
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

            tbEmployeeNumber.Enabled = false;
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
            tbContactNo.Enabled = false;
            tbEmailAdd.Enabled = false;
            cbxEmployeeType.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

            tbEmployeeNumber.Clear();
            tbFName.Clear();
            tbMName.Clear();
            tbLName.Clear();
            tbStreet.Clear();
            tbSubdivision.Clear();
            tbCity.Clear();
            tbZipcode.Clear();
            tbContactNo.Clear();
            tbEmailAdd.Clear();
            dateTimePicker1.Value = System.DateTime.Now;
            dateTimePicker2.Value = System.DateTime.Now;
            pictureBox1.Image = null;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tbEmployeeNumber.Text.Length == 0 && tbFName.Text.Length == 0 && tbLName.Text.Length == 0)
            {
                MainForm mainForm = new MainForm();
                mainForm.strPassedUserID = lblUserID_EmpInfo.Text;
                mainForm.Show();
                this.Close();

            }//if
            else
            {
                DialogResult dialog = MessageBox.Show("There are unsaved data in the form. Close this form?", "Close Employee Information Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.strPassedUserID = lblUserID_EmpInfo.Text;
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    //Do Nothing
                }
            }//else
        }

        private void btnBrowsePic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select student image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imageLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imageLoc;

                }
            }//try

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }//catch
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = true;

            tbEmployeeNumber.Enabled = false;
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
            cbxEmployeeType.Enabled = false;
            tbContactNo.Enabled = false;
            tbEmailAdd.Enabled = false;

            try
            {
                tbEmployeeNumber.Text = dataGridView1.SelectedRows[0].Cells["Employee_ID"].Value.ToString();
                tbFName.Text = dataGridView1.SelectedRows[0].Cells["Employee_FName"].Value.ToString();
                tbMName.Text = dataGridView1.SelectedRows[0].Cells["Employee_MName"].Value.ToString();
                tbLName.Text = dataGridView1.SelectedRows[0].Cells["Employee_LName"].Value.ToString();
                string strGender = dataGridView1.SelectedRows[0].Cells["Employee_Gender"].Value.ToString();
                if (strGender == "Male")
                    rbMale.Checked = true;
                else rbFemale.Checked = true;
                //implement Gender value passing here
                DateTime curDate;
                if (DateTime.TryParse(dataGridView1.SelectedRows[0].Cells["Employee_Birthdate"].Value.ToString(), out curDate))
                {
                    dateTimePicker1.Value = curDate;
                }
                //implement Gender value passing here
                DateTime curDate2;
                if (DateTime.TryParse(dataGridView1.SelectedRows[0].Cells["Employee_DateOfEmployment"].Value.ToString(), out curDate2))
                {
                    dateTimePicker2.Value = curDate2;
                }

                tbStreet.Text = dataGridView1.SelectedRows[0].Cells["Employee_Add_Street"].Value.ToString();
                tbSubdivision.Text = dataGridView1.SelectedRows[0].Cells["Employee_Add_Subdivision"].Value.ToString();
                tbCity.Text = dataGridView1.SelectedRows[0].Cells["Employee_Add_CityProvince"].Value.ToString();
                tbZipcode.Text = dataGridView1.SelectedRows[0].Cells["Employee_Add_ZipCode"].Value.ToString();
                cbxEmployeeType.SelectedValue = dataGridView1.SelectedRows[0].Cells["Employee_Type_ID"].Value.ToString();
                tbContactNo.Text = dataGridView1.SelectedRows[0].Cells["Employee_ContactNo"].Value.ToString();
                tbEmailAdd.Text = dataGridView1.SelectedRows[0].Cells["Employee_EmailAdd"].Value.ToString();

                byte[] img = (byte[])(dataGridView1.SelectedRows[0].Cells["Employee_Image"].Value);
                if (img == null)
                    pictureBox1.Image = null;
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Cell Click Exception Occured");
            }
            //Feed Data to Textbox

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID, Employee_FName, Employee_MName, Employee_LName, Employee_Gender, Employee_Birthdate, Employee_Add_Street, Employee_Add_Subdivision, Employee_Add_CityProvince, Employee_Add_ZipCode, Employee_ContactNo, Employee_EmailAdd, Employee_Type_ID, Employee_DateofEmployment, Employee_Image FROM EMPLOYEE WHERE Employee_ID LIKE '%'+@EMPNO+'%' OR Employee_FName LIKE '%'+@FNAME+'%'OR Student_LName LIKE '%'+@LNAME+'%'", con);
                da.SelectCommand.Parameters.Add(new SqlParameter("@EMPNO", tbSearch.Text));
                da.SelectCommand.Parameters.Add(new SqlParameter("@FNAME", tbSearch.Text));
                da.SelectCommand.Parameters.Add(new SqlParameter("@LNAME", tbSearch.Text));
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
    }
}
