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
            btnCNA = new Sunny.UI.UIButton();
            lblOR = new Sunny.UI.UILabel();
            txtPassword = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            chkRemember = new Sunny.UI.UICheckBox();
            linkForgot = new Sunny.UI.UILinkLabel();
            btnLogin = new Sunny.UI.UIButton();
            lblEmail = new Sunny.UI.UILabel();
            lblPassword = new Sunny.UI.UILabel();
            uiPanel2 = new Sunny.UI.UIPanel();
            lblSEasy = new Sunny.UI.UIPanel();
            lblSubTitle = new Sunny.UI.UILabel();
            pictureBox2 = new PictureBox();
            lblTitle = new Sunny.UI.UILabel();
            lblSecure = new Sunny.UI.UILabel();
            lblFast = new Sunny.UI.UILabel();
            lblEasy = new Sunny.UI.UILabel();
            lblMSecure = new Label();
            lblSFast = new Label();
            label2 = new Label();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            lblSEasy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(btnCNA);
            uiPanel1.Controls.Add(lblOR);
            uiPanel1.Controls.Add(txtPassword);
            uiPanel1.Controls.Add(txtEmail);
            uiPanel1.Controls.Add(chkRemember);
            uiPanel1.Controls.Add(linkForgot);
            uiPanel1.Controls.Add(btnLogin);
            uiPanel1.Controls.Add(lblEmail);
            uiPanel1.Controls.Add(lblPassword);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(582, 14);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(544, 919);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnCNA
            // 
            btnCNA.Font = new Font("Microsoft Sans Serif", 12F);
            btnCNA.Location = new Point(42, 704);
            btnCNA.MinimumSize = new Size(1, 1);
            btnCNA.Name = "btnCNA";
            btnCNA.Size = new Size(452, 52);
            btnCNA.TabIndex = 16;
            btnCNA.Text = "Create  New Account";
            btnCNA.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCNA.Click += btnCNA_Click;
            // 
            // lblOR
            // 
            lblOR.Font = new Font("Microsoft Sans Serif", 12F);
            lblOR.ForeColor = Color.FromArgb(48, 48, 48);
            lblOR.Location = new Point(235, 632);
            lblOR.Name = "lblOR";
            lblOR.Size = new Size(52, 34);
            lblOR.TabIndex = 15;
            lblOR.Text = "OR";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.Location = new Point(42, 400);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(452, 44);
            txtPassword.Symbol = 61475;
            txtPassword.TabIndex = 3;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "Enter your password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(42, 253);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(452, 44);
            txtEmail.Symbol = 61443;
            txtEmail.TabIndex = 14;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "Enter your email";
            // 
            // chkRemember
            // 
            chkRemember.Font = new Font("Microsoft Sans Serif", 12F);
            chkRemember.ForeColor = Color.FromArgb(48, 48, 48);
            chkRemember.Location = new Point(42, 467);
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
            linkForgot.Location = new Point(284, 467);
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
            btnLogin.Location = new Point(42, 542);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(452, 47);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLogin.Click += btnLogin_Click;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F);
            lblEmail.ForeColor = Color.FromArgb(48, 48, 48);
            lblEmail.Location = new Point(42, 200);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 34);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Microsoft Sans Serif", 12F);
            lblPassword.ForeColor = Color.FromArgb(48, 48, 48);
            lblPassword.Location = new Point(42, 348);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(122, 34);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(lblSEasy);
            uiPanel2.Controls.Add(lblSubTitle);
            uiPanel2.Controls.Add(pictureBox2);
            uiPanel2.Controls.Add(lblTitle);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(30, 14);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(544, 919);
            uiPanel2.TabIndex = 15;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblSEasy
            // 
            lblSEasy.Controls.Add(label2);
            lblSEasy.Controls.Add(lblSFast);
            lblSEasy.Controls.Add(lblMSecure);
            lblSEasy.Controls.Add(lblEasy);
            lblSEasy.Controls.Add(lblFast);
            lblSEasy.Controls.Add(lblSecure);
            lblSEasy.Font = new Font("Microsoft Sans Serif", 12F);
            lblSEasy.Location = new Point(42, 542);
            lblSEasy.Margin = new Padding(4, 5, 4, 5);
            lblSEasy.MinimumSize = new Size(1, 1);
            lblSEasy.Name = "lblSEasy";
            lblSEasy.Size = new Size(444, 326);
            lblSEasy.TabIndex = 3;
            lblSEasy.Text = " ";
            lblSEasy.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Font = new Font("Microsoft Sans Serif", 12F);
            lblSubTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblSubTitle.Location = new Point(52, 176);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(434, 29);
            lblSubTitle.TabIndex = 2;
            lblSubTitle.Text = "Login to access your Mini Digital wallet\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(141, 253);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 231);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F);
            lblTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblTitle.Location = new Point(166, 107);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome Back!";
            // 
            // lblSecure
            // 
            lblSecure.Font = new Font("Microsoft Sans Serif", 12F);
            lblSecure.ForeColor = Color.FromArgb(48, 48, 48);
            lblSecure.Location = new Point(40, 28);
            lblSecure.Name = "lblSecure";
            lblSecure.Size = new Size(96, 35);
            lblSecure.TabIndex = 1;
            lblSecure.Text = "Secure";
            // 
            // lblFast
            // 
            lblFast.Font = new Font("Microsoft Sans Serif", 12F);
            lblFast.ForeColor = Color.FromArgb(48, 48, 48);
            lblFast.Location = new Point(40, 128);
            lblFast.Name = "lblFast";
            lblFast.Size = new Size(63, 35);
            lblFast.TabIndex = 2;
            lblFast.Text = "Fast";
            // 
            // lblEasy
            // 
            lblEasy.Font = new Font("Microsoft Sans Serif", 12F);
            lblEasy.ForeColor = Color.FromArgb(48, 48, 48);
            lblEasy.Location = new Point(40, 221);
            lblEasy.Name = "lblEasy";
            lblEasy.Size = new Size(70, 35);
            lblEasy.TabIndex = 3;
            lblEasy.Text = "Easy";
            // 
            // lblMSecure
            // 
            lblMSecure.AutoSize = true;
            lblMSecure.Location = new Point(40, 72);
            lblMSecure.Name = "lblMSecure";
            lblMSecure.Size = new Size(345, 29);
            lblMSecure.TabIndex = 4;
            lblMSecure.Text = "Your transaction are 100% safe";
            // 
            // lblSFast
            // 
            lblSFast.AutoSize = true;
            lblSFast.Location = new Point(40, 172);
            lblSFast.Name = "lblSFast";
            lblSFast.Size = new Size(364, 29);
            lblSFast.TabIndex = 4;
            lblSFast.Text = "Send and receiw money instantly\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 265);
            label2.Name = "label2";
            label2.Size = new Size(343, 58);
            label2.TabIndex = 5;
            label2.Text = "Simple and user-friendly wallet\r\n\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 1008);
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "LOGIN";
            Load += Form1_Load;
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            lblSEasy.ResumeLayout(false);
            lblSEasy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel lblEmail;
        private Sunny.UI.UILabel lblPassword;
        private Sunny.UI.UIButton btnLogin;
        private Sunny.UI.UILinkLabel linkForgot;
        private Sunny.UI.UICheckBox chkRemember;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel lblOR;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel lblSubTitle;
        private PictureBox pictureBox2;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UIButton btnCNA;
        private Sunny.UI.UIPanel lblSEasy;
        private Label lblMSecure;
        private Sunny.UI.UILabel lblEasy;
        private Sunny.UI.UILabel lblFast;
        private Sunny.UI.UILabel lblSecure;
        private Label label2;
        private Label lblSFast;
    }
}
