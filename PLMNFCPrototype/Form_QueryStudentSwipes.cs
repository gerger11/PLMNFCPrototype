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
    public partial class Form_QueryStudentSwipes : Form
    {
        string conect = String.Empty;
        private string strUserIDval;
        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }

        public Form_QueryStudentSwipes()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;

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
            dataGridView1.Columns[0].Visible = true;
            con.Close();
        }

        private void Form_QueryStudentSwipes_Load(object sender, EventArgs e)
        {
            views();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Student_ID, Student_FName, Student_LName FROM STUDENT WHERE Student_ID LIKE '%'+@STUDNO+'%' OR Student_LName LIKE '%'+@LNAME+'%'", con);
                da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", tbSearch.Text));
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblStudentNumber.Text = dataGridView1.SelectedRows[0].Cells["Student_ID"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void btnGenerateResult_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("You cannot choose a bigger date value for End date. Date picker for Start date should always be lesser than End date");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(conect);
                    con.Open();

                    string strQuery = "SELECT Smartcard_LogID, Student_ID, Student_FullName, Smartcard_UID, LogDate FROM SMARTCARDLOGS WHERE Student_ID ='" + lblStudentNumber.Text + "' AND LogDate BETWEEN '" + dateTimePicker1.Value.Date.ToString() + "' AND '" + dateTimePicker2.Value.Date.ToString() + "'";

                    SqlDataAdapter da = new SqlDataAdapter("SELECT Smartcard_LogID, Student_ID, Student_FullName, Smartcard_UID, LogDate FROM SMARTCARDLOGS WHERE Student_ID LIKE '%'+@STUDNO+'%' AND LogDate BETWEEN @DATE1 AND @DATE2", con);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@STUDNO", lblStudentNumber.Text));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@DATE1", dateTimePicker1.Value.Date.ToString()));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@DATE2", dateTimePicker2.Value.Date.ToString()));

                    SqlCommand cmd = new SqlCommand(strQuery, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();
                    if (!rdr.HasRows)
                    {
                        MessageBox.Show("No Rows returned for this student.", "Student Swipes Query", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0].DefaultView;
                        con.Close();
                    }

                    else if (rdr.HasRows)
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0].DefaultView;
                        con.Close();
                    }

                }

                catch (Exception ex)
                {
                    // MessageBox.Show(ex.GetBaseException().Message);
                }
            }
        }
    }
}
