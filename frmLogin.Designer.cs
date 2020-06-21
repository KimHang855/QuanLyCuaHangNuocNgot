namespace QuanLyCuaHangNuocNgot
{
    partial class frmLogin
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chckShow = new System.Windows.Forms.CheckBox();
            this.btLogIn = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbLogin.ForeColor = System.Drawing.Color.Red;
            this.lbLogin.Location = new System.Drawing.Point(218, 45);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(171, 29);
            this.lbLogin.TabIndex = 10;
            this.lbLogin.Text = "ĐĂNG NHẬP";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbUsername.Location = new System.Drawing.Point(39, 125);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(119, 20);
            this.lbUsername.TabIndex = 11;
            this.lbUsername.Text = "Tên đăng nhập";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPassword.Location = new System.Drawing.Point(81, 190);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 20);
            this.lbPassword.TabIndex = 12;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(193, 125);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 22);
            this.txtUsername.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(193, 190);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 22);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chckShow
            // 
            this.chckShow.AutoSize = true;
            this.chckShow.Checked = true;
            this.chckShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckShow.Location = new System.Drawing.Point(475, 192);
            this.chckShow.Margin = new System.Windows.Forms.Padding(4);
            this.chckShow.Name = "chckShow";
            this.chckShow.Size = new System.Drawing.Size(18, 17);
            this.chckShow.TabIndex = 15;
            this.chckShow.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chckShow.UseVisualStyleBackColor = true;
            this.chckShow.CheckedChanged += new System.EventHandler(this.chckShow_CheckedChanged);
            // 
            // btLogIn
            // 
            this.btLogIn.BackColor = System.Drawing.SystemColors.Control;
            this.btLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btLogIn.Location = new System.Drawing.Point(149, 275);
            this.btLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(133, 46);
            this.btLogIn.TabIndex = 16;
            this.btLogIn.Text = "Đăng nhập";
            this.btLogIn.UseVisualStyleBackColor = false;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.Control;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btExit.Location = new System.Drawing.Point(308, 275);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(137, 46);
            this.btExit.TabIndex = 17;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(161, 363);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(121, 17);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tạo tài khoản mới";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(306, 363);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(105, 17);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Quên mật khẩu";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 416);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.chckShow);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        public System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chckShow;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}