namespace MIni_Digital_Wallet_system_Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiPanel1 = new Sunny.UI.UIPanel();
            txtPassword = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            lblDHAA = new Label();
            linkRegister = new Sunny.UI.UILinkLabel();
            chkRemember = new Sunny.UI.UICheckBox();
            linkForgot = new Sunny.UI.UILinkLabel();
            btnLogin = new Sunny.UI.UIButton();
            lblEmail = new Sunny.UI.UILabel();
            lblPassword = new Sunny.UI.UILabel();
            lblSubTitle = new Sunny.UI.UILabel();
            pictureBox1 = new PictureBox();
            lblTitle = new Sunny.UI.UILabel();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(txtPassword);
            uiPanel1.Controls.Add(txtEmail);
            uiPanel1.Controls.Add(lblDHAA);
            uiPanel1.Controls.Add(linkRegister);
            uiPanel1.Controls.Add(chkRemember);
            uiPanel1.Controls.Add(linkForgot);
            uiPanel1.Controls.Add(btnLogin);
            uiPanel1.Controls.Add(lblEmail);
            uiPanel1.Controls.Add(lblPassword);
            uiPanel1.Controls.Add(lblSubTitle);
            uiPanel1.Controls.Add(pictureBox1);
            uiPanel1.Controls.Add(lblTitle);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(182, 2);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(699, 919);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.Location = new Point(42, 489);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(477, 44);
            txtPassword.Symbol = 61475;
            txtPassword.TabIndex = 3;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "Enter your password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(42, 371);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(477, 44);
            txtEmail.Symbol = 61443;
            txtEmail.TabIndex = 14;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "Enter your email";
            // 
            // lblDHAA
            // 
            lblDHAA.AutoSize = true;
            lblDHAA.Location = new Point(50, 688);
            lblDHAA.Name = "lblDHAA";
            lblDHAA.Size = new Size(257, 29);
            lblDHAA.TabIndex = 13;
            lblDHAA.Text = "Don't have an account?";
            lblDHAA.Click += lblDHAA_Click;
            // 
            // linkRegister
            // 
            linkRegister.ActiveLinkColor = Color.FromArgb(80, 160, 255);
            linkRegister.Font = new Font("Microsoft Sans Serif", 12F);
            linkRegister.ForeColor = Color.FromArgb(48, 48, 48);
            linkRegister.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkRegister.Location = new Point(410, 688);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(109, 25);
            linkRegister.TabIndex = 10;
            linkRegister.TabStop = true;
            linkRegister.Text = "Register";
            linkRegister.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            linkRegister.Click += linkRegister_Click;
            // 
            // chkRemember
            // 
            chkRemember.Font = new Font("Microsoft Sans Serif", 12F);
            chkRemember.ForeColor = Color.FromArgb(48, 48, 48);
            chkRemember.Location = new Point(42, 566);
            chkRemember.MinimumSize = new Size(1, 1);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(225, 34);
            chkRemember.TabIndex = 9;
            chkRemember.Text = "Remember Me";
            // 
            // linkForgot
            // 
            linkForgot.ActiveLinkColor = Color.FromArgb(80, 160, 255);
            linkForgot.Font = new Font("Microsoft Sans Serif", 12F);
            linkForgot.ForeColor = Color.FromArgb(48, 48, 48);
            linkForgot.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkForgot.Location = new Point(309, 566);
            linkForgot.Name = "linkForgot";
            linkForgot.Size = new Size(210, 34);
            linkForgot.TabIndex = 8;
            linkForgot.TabStop = true;
            linkForgot.Text = "Forgot Password?";
            linkForgot.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            linkForgot.Click += linkForgot_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F);
            btnLogin.Location = new Point(42, 618);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(477, 47);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLogin.Click += btnLogin_Click;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F);
            lblEmail.ForeColor = Color.FromArgb(48, 48, 48);
            lblEmail.Location = new Point(42, 332);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 34);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Microsoft Sans Serif", 12F);
            lblPassword.ForeColor = Color.FromArgb(48, 48, 48);
            lblPassword.Location = new Point(42, 450);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(122, 34);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblSubTitle
            // 
            lblSubTitle.Font = new Font("Microsoft Sans Serif", 12F);
            lblSubTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblSubTitle.Location = new Point(141, 253);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(302, 29);
            lblSubTitle.TabIndex = 2;
            lblSubTitle.Text = "Login to access your wallet\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(195, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 136);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F);
            lblTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblTitle.Location = new Point(195, 211);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome Back!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 1008);
            Controls.Add(uiPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "LOGIN";
            Load += Form1_Load;
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private PictureBox pictureBox1;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblEmail;
        private Sunny.UI.UILabel lblPassword;
        private Sunny.UI.UILabel lblSubTitle;
        private Sunny.UI.UIButton btnLogin;
        private Sunny.UI.UILinkLabel linkForgot;
        private Sunny.UI.UICheckBox chkRemember;
        private Sunny.UI.UILinkLabel linkRegister;
        private Label lblDHAA;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtEmail;
    }
}
