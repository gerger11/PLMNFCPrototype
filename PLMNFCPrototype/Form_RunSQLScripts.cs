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
    public partial class Form_RunSQLScripts : Form
    {
        string conect = String.Empty;

        private string strUserIDval;
        public string strPassedUserID
        {
            get { return strUserIDval; }
            set { strUserIDval = value; }
        }
        public Form_RunSQLScripts()
        {
            InitializeComponent();
            Connection connect = new Connection();
            conect = connect.ConnectionString;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rbSelect.Checked == true && rbCreate.Checked == false)
            {
                try
                {
                    SqlConnection con = new SqlConnection(conect);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(richTextBox1.Text, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message, "ERROR IN SELECT QUERY");
                }
            }
        }
    }
}
