namespace DSTools.MSSqlToCRMImport.Forms
{
    partial class GetConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDBName = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.btnCreateConn = new System.Windows.Forms.Button();
            this.llblConnection = new System.Windows.Forms.LinkLabel();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.cmbauth = new System.Windows.Forms.ComboBox();
            this.lblauth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Location = new System.Drawing.Point(95, 61);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(87, 13);
            this.lblDBName.TabIndex = 28;
            this.lblDBName.Text = "Database Name:";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(251, 58);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(180, 20);
            this.txtDBName.TabIndex = 27;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(95, 146);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(251, 143);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPassword.TabIndex = 25;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(95, 120);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 24;
            this.lblUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(251, 117);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 20);
            this.txtUserName.TabIndex = 23;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(95, 25);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(72, 13);
            this.lblServerName.TabIndex = 22;
            this.lblServerName.Text = "Server Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(251, 22);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(180, 20);
            this.txtServerName.TabIndex = 21;
            // 
            // btnCreateConn
            // 
            this.btnCreateConn.Location = new System.Drawing.Point(163, 201);
            this.btnCreateConn.Name = "btnCreateConn";
            this.btnCreateConn.Size = new System.Drawing.Size(134, 35);
            this.btnCreateConn.TabIndex = 20;
            this.btnCreateConn.Text = "Create Connection";
            this.btnCreateConn.UseVisualStyleBackColor = true;
            this.btnCreateConn.Click += new System.EventHandler(this.btnCreateConn_Click);
            // 
            // llblConnection
            // 
            this.llblConnection.AutoSize = true;
            this.llblConnection.Location = new System.Drawing.Point(23, 272);
            this.llblConnection.Name = "llblConnection";
            this.llblConnection.Size = new System.Drawing.Size(121, 13);
            this.llblConnection.TabIndex = 29;
            this.llblConnection.TabStop = true;
            this.llblConnection.Text = "Using Connection String";
            this.llblConnection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(95, 90);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(94, 13);
            this.lblConnectionString.TabIndex = 31;
            this.lblConnectionString.Text = "Connection String:";
            this.lblConnectionString.Visible = false;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(251, 87);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(180, 20);
            this.txtConnectionString.TabIndex = 30;
            this.txtConnectionString.Visible = false;
            // 
            // cmbauth
            // 
            this.cmbauth.FormattingEnabled = true;
            this.cmbauth.Items.AddRange(new object[] {
            "Windows Authentication",
            "Sql Server Authentication"});
            this.cmbauth.Location = new System.Drawing.Point(251, 86);
            this.cmbauth.Name = "cmbauth";
            this.cmbauth.Size = new System.Drawing.Size(180, 21);
            this.cmbauth.TabIndex = 32;
            this.cmbauth.SelectedIndexChanged += new System.EventHandler(this.cmbauth_SelectedIndexChanged);
            // 
            // lblauth
            // 
            this.lblauth.AutoSize = true;
            this.lblauth.Location = new System.Drawing.Point(95, 89);
            this.lblauth.Name = "lblauth";
            this.lblauth.Size = new System.Drawing.Size(84, 13);
            this.lblauth.TabIndex = 33;
            this.lblauth.Text = "Authentication  :";
            // 
            // GetConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 297);
            this.Controls.Add(this.lblauth);
            this.Controls.Add(this.cmbauth);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.llblConnection);
            this.Controls.Add(this.lblDBName);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.btnCreateConn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetConnection";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetConnection";
            this.Load += new System.EventHandler(this.GetConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Button btnCreateConn;
        private System.Windows.Forms.LinkLabel llblConnection;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.ComboBox cmbauth;
        private System.Windows.Forms.Label lblauth;
    }
}