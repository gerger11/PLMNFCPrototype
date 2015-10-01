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
    public partial class Form_Login : Form
    {
        string conect = String.Empty;
        public Form_Login()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(conect);
            //con.Open();

            if (tbUsername.Text == "admin" && tbPassword.Text == "admin123")
            {
                MessageBox.Show("Welcome!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainForm mnFrm = new MainForm();
                mnFrm.strPassedUserID = tbUsername.Text;
                mnFrm.Show();
            }
            else
            {
                SqlConnection con = new SqlConnection(conect);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM USERACCOUNTS WHERE Account_ID = '" + tbUsername.Text + "' AND Password = '" + tbPassword.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Welcome!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainForm mnFrm = new MainForm();
                    mnFrm.strPassedUserID = tbUsername.Text;
                    mnFrm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials. Please try again.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbUsername.Clear();
                    tbPassword.Clear();
                }
            }
            
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
        }
    }
}
