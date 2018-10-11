using DSTools.MSSqlToCRMImport.AppCode;
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

namespace DSTools.MSSqlToCRMImport.Forms
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
            if (txtConnectionString.Visible == false)
            {
                if (cmbauth.SelectedItem.ToString().Contains("Windows"))
                {
                    connetionString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + txtDBName.Text + ";Integrated Security=True";
                }
                else
                {
                    connetionString = @"Data Source=" + txtServerName.Text + ";Initial Catalog=" + txtDBName.Text + ";User ID=" + txtUserName.Text + ";Password=" + txtPassword.Text + "";
                }
            }
            else
            {
                connetionString = txtConnectionString.Text.Trim();
            }

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
            Connection.Database = cnn.Database;
            Connection.ServerName = cnn.DataSource;
            try
            {
                Connection.UserID = cnn.Credential.UserId;
                Connection.Password = cnn.Credential.Password;
            }
            catch { }

            cnn.Close();
            this.DialogResult = DialogResult.OK;
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblConnectionString.Visible == false)
            {
                lblDBName.Visible = false;
                lblPassword.Visible = false;
                lblServerName.Visible = false;
                lblUserName.Visible = false;
                txtDBName.Visible = false;
                txtPassword.Visible = false;
                txtServerName.Visible = false;
                txtUserName.Visible = false;

                lblConnectionString.Visible = true;
                txtConnectionString.Visible = true;
                lblauth.Visible = false;
                cmbauth.Visible = false;
                llblConnection.Text = "Using Server Details";
            }
            else
            {
                lblDBName.Visible = true;
                lblPassword.Visible = false;
                lblServerName.Visible = true;
                lblUserName.Visible = false;
                txtDBName.Visible = true;
                txtPassword.Visible = false;
                txtServerName.Visible = true;
                txtUserName.Visible = false;
                lblauth.Visible = true;
                cmbauth.Visible = true;
                lblConnectionString.Visible = false;
                txtConnectionString.Visible = false;
                cmbauth.SelectedIndex =0;
                llblConnection.Text = "Using Connection String";
            }
        }

        private void GetConnection_Load(object sender, EventArgs e)
        {
            txtConnectionString.Visible = false;
            lblConnectionString.Visible = false;
            cmbauth.SelectedIndex = 0;
        }

        private void cmbauth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbauth.SelectedItem.ToString().Contains("Windows"))
            {
                lblUserName.Visible = false;
                lblPassword.Visible = false;
                txtPassword.Visible = false;
                txtUserName.Visible = false;
            }
            else
            {
                lblUserName.Visible = true;
                lblPassword.Visible = true;
                txtPassword.Visible = true;
                txtUserName.Visible = true;
            }
        }
    }
}
