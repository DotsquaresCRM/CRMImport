using DSTools.SqlToCRMImport.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSTools.SqlToCRMImport.Forms
{
    public partial class GetConnection : Form
    {
        public GetConnection()
        {
            InitializeComponent();
        }

        private void btnCreateConn_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=" + txtServerName.Text + ";Initial Catalog=" + txtDBName.Text + ";User ID=" + txtUserName.Text + ";Password=" + txtPassword.Text + "";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            List<string> lstDB = new List<string>();
            using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", cnn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lstDB.Add(dr[0].ToString());
                    }
                }
            }
            Connection.ConnectionString = connetionString;
            Connection.Database = txtDBName.Text;
            Connection.ServerName = txtServerName.Text;
            Connection.UserID = txtUserName.Text;
            Connection.Password = txtPassword.Text;

            cnn.Close();
            this.DialogResult = DialogResult.OK;
            this.Hide();
            
        }
    }
}
