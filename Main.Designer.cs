namespace MIni_Digital_Wallet_system_Final
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            tabMenu = new Sunny.UI.UITabControlMenu();
            tabDashboard = new TabPage();
            tabSendMoney = new TabPage();
            pnlSendMoneyCard = new Sunny.UI.UIPanel();
            btnSendMoney = new Sunny.UI.UISymbolButton();
            txtAddNote = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            txtAmount = new Sunny.UI.UITextBox();
            txtRecipientId = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            tabTransactions = new TabPage();
            tabProfile = new TabPage();
            uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            pictureBox1 = new PictureBox();
            uitxtuser = new Sunny.UI.UITextBox();
            uitxtphonenumber = new Sunny.UI.UITextBox();
            uitxtemail = new Sunny.UI.UITextBox();
            uitxtfullname = new Sunny.UI.UITextBox();
            uiButton1 = new Sunny.UI.UIButton();
            lblPhonenumber = new Sunny.UI.UILabel();
            lblEmail = new Sunny.UI.UILabel();
            lblFullname = new Sunny.UI.UILabel();
            lblUserID = new Sunny.UI.UILabel();
            Btneditprofile = new Sunny.UI.UIButton();
            uiLabel5 = new Sunny.UI.UILabel();
            lblmyprofile = new Sunny.UI.UILabel();
            imageList1 = new ImageList(components);
            tabMenu.SuspendLayout();
            tabSendMoney.SuspendLayout();
            pnlSendMoneyCard.SuspendLayout();
            tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabMenu
            // 
            tabMenu.Alignment = TabAlignment.Left;
            tabMenu.Controls.Add(tabDashboard);
            tabMenu.Controls.Add(tabSendMoney);
            tabMenu.Controls.Add(tabTransactions);
            tabMenu.Controls.Add(tabProfile);
            tabMenu.Cursor = Cursors.Hand;
            tabMenu.Dock = DockStyle.Fill;
            tabMenu.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabMenu.FillColor = Color.WhiteSmoke;
            tabMenu.Font = new Font("Microsoft Sans Serif", 12F);
            tabMenu.ImageList = imageList1;
            tabMenu.Location = new Point(0, 0);
            tabMenu.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            tabMenu.Multiline = true;
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(2139, 1089);
            tabMenu.SizeMode = TabSizeMode.Fixed;
            tabMenu.TabBackColor = Color.FromArgb(96, 43, 217);
            tabMenu.TabIndex = 0;
            tabMenu.TabUnSelectedForeColor = Color.WhiteSmoke;
            // 
            // tabDashboard
            // 
            tabDashboard.BackColor = Color.WhiteSmoke;
            tabDashboard.Cursor = Cursors.Hand;
            tabDashboard.Location = new Point(201, 0);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Size = new Size(1938, 1089);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.Click += tabDashboard_Click;
            // 
            // tabSendMoney
            // 
            tabSendMoney.BackColor = Color.WhiteSmoke;
            tabSendMoney.Controls.Add(pnlSendMoneyCard);
            tabSendMoney.Controls.Add(uiLabel1);
            tabSendMoney.Cursor = Cursors.Hand;
            tabSendMoney.Location = new Point(201, 0);
            tabSendMoney.Name = "tabSendMoney";
            tabSendMoney.Size = new Size(1938, 1089);
            tabSendMoney.TabIndex = 1;
            tabSendMoney.Text = "Send Money";
            // 
            // pnlSendMoneyCard
            // 
            pnlSendMoneyCard.BackColor = Color.Transparent;
            pnlSendMoneyCard.BackgroundImageLayout = ImageLayout.None;
            pnlSendMoneyCard.Controls.Add(btnSendMoney);
            pnlSendMoneyCard.Controls.Add(txtAddNote);
            pnlSendMoneyCard.Controls.Add(uiLabel4);
            pnlSendMoneyCard.Controls.Add(uiLabel3);
            pnlSendMoneyCard.Controls.Add(uiLabel2);
            pnlSendMoneyCard.Controls.Add(txtAmount);
            pnlSendMoneyCard.Controls.Add(txtRecipientId);
            pnlSendMoneyCard.FillColor = Color.White;
            pnlSendMoneyCard.FillColor2 = Color.FromArgb(248, 248, 248);
            pnlSendMoneyCard.Font = new Font("Microsoft Sans Serif", 12F);
            pnlSendMoneyCard.Location = new Point(155, 180);
            pnlSendMoneyCard.Margin = new Padding(7, 8, 7, 8);
            pnlSendMoneyCard.MinimumSize = new Size(2, 2);
            pnlSendMoneyCard.Name = "pnlSendMoneyCard";
            pnlSendMoneyCard.Radius = 20;
            pnlSendMoneyCard.RectColor = Color.FromArgb(230, 230, 230);
            pnlSendMoneyCard.Size = new Size(994, 974);
            pnlSendMoneyCard.Style = Sunny.UI.UIStyle.Custom;
            pnlSendMoneyCard.TabIndex = 4;
            pnlSendMoneyCard.Text = null;
            pnlSendMoneyCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnSendMoney
            // 
            btnSendMoney.FillColor = Color.FromArgb(96, 43, 217);
            btnSendMoney.FillHoverColor = Color.FromArgb(120, 60, 255);
            btnSendMoney.FillPressColor = Color.FromArgb(70, 20, 180);
            btnSendMoney.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendMoney.Location = new Point(49, 434);
            btnSendMoney.MinimumSize = new Size(1, 1);
            btnSendMoney.Name = "btnSendMoney";
            btnSendMoney.RectColor = Color.FromArgb(96, 43, 217);
            btnSendMoney.RectHoverColor = Color.FromArgb(120, 60, 255);
            btnSendMoney.RectPressColor = Color.FromArgb(70, 20, 180);
            btnSendMoney.Size = new Size(499, 52);
            btnSendMoney.Style = Sunny.UI.UIStyle.Custom;
            btnSendMoney.Symbol = 61912;
            btnSendMoney.SymbolSize = 34;
            btnSendMoney.TabIndex = 5;
            btnSendMoney.Text = "Send Money";
            btnSendMoney.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSendMoney.Click += btnSendMoney_Click;
            // 
            // txtAddNote
            // 
            txtAddNote.Font = new Font("Segoe UI", 10F);
            txtAddNote.ForeColor = Color.FromArgb(31, 41, 55);
            txtAddNote.Location = new Point(48, 340);
            txtAddNote.Margin = new Padding(4, 5, 4, 5);
            txtAddNote.MaxLength = 200;
            txtAddNote.MinimumSize = new Size(1, 16);
            txtAddNote.Name = "txtAddNote";
            txtAddNote.Padding = new Padding(5);
            txtAddNote.Radius = 6;
            txtAddNote.RectColor = Color.Gainsboro;
            txtAddNote.ShowText = false;
            txtAddNote.Size = new Size(500, 50);
            txtAddNote.Style = Sunny.UI.UIStyle.Custom;
            txtAddNote.Symbol = 61788;
            txtAddNote.SymbolColor = Color.Gainsboro;
            txtAddNote.SymbolSize = 34;
            txtAddNote.TabIndex = 3;
            txtAddNote.TextAlignment = ContentAlignment.MiddleCenter;
            txtAddNote.Watermark = "Add a note";
            txtAddNote.WatermarkActiveColor = Color.LightGray;
            txtAddNote.WatermarkColor = Color.Gainsboro;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel4.ForeColor = Color.Gray;
            uiLabel4.Location = new Point(38, 301);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(160, 34);
            uiLabel4.TabIndex = 2;
            uiLabel4.Text = "Note (optional)";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel3.ForeColor = Color.Gray;
            uiLabel3.Location = new Point(38, 70);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(150, 34);
            uiLabel3.TabIndex = 2;
            uiLabel3.Text = "Recipient ID";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.Gray;
            uiLabel2.Location = new Point(38, 187);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(150, 34);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10F);
            txtAmount.ForeColor = Color.FromArgb(31, 41, 55);
            txtAmount.Location = new Point(49, 226);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.MinimumSize = new Size(1, 16);
            txtAmount.Name = "txtAmount";
            txtAmount.Padding = new Padding(5);
            txtAmount.Radius = 6;
            txtAmount.RectColor = Color.Gainsboro;
            txtAmount.ShowText = false;
            txtAmount.Size = new Size(500, 50);
            txtAmount.Style = Sunny.UI.UIStyle.Custom;
            txtAmount.Symbol = 61781;
            txtAmount.SymbolColor = Color.Gainsboro;
            txtAmount.SymbolSize = 34;
            txtAmount.TabIndex = 3;
            txtAmount.TextAlignment = ContentAlignment.MiddleCenter;
            txtAmount.Watermark = "Enter amount";
            txtAmount.WatermarkActiveColor = Color.LightGray;
            txtAmount.WatermarkColor = Color.Gainsboro;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // txtRecipientId
            // 
            txtRecipientId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecipientId.ForeColor = Color.FromArgb(31, 41, 55);
            txtRecipientId.Location = new Point(49, 109);
            txtRecipientId.Margin = new Padding(4, 5, 4, 5);
            txtRecipientId.MinimumSize = new Size(1, 16);
            txtRecipientId.Name = "txtRecipientId";
            txtRecipientId.Padding = new Padding(5);
            txtRecipientId.Radius = 6;
            txtRecipientId.RectColor = Color.Gainsboro;
            txtRecipientId.ShowText = false;
            txtRecipientId.Size = new Size(500, 50);
            txtRecipientId.Style = Sunny.UI.UIStyle.Custom;
            txtRecipientId.Symbol = 62146;
            txtRecipientId.SymbolColor = Color.Silver;
            txtRecipientId.SymbolSize = 34;
            txtRecipientId.TabIndex = 3;
            txtRecipientId.TextAlignment = ContentAlignment.MiddleCenter;
            txtRecipientId.Watermark = "Enter recipient ID (e.g. U002)";
            txtRecipientId.WatermarkActiveColor = Color.LightGray;
            txtRecipientId.WatermarkColor = Color.Gainsboro;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(129, 84);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(382, 69);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "Send Money";
            // 
            // tabTransactions
            // 
            tabTransactions.BackColor = Color.WhiteSmoke;
            tabTransactions.Cursor = Cursors.Hand;
            tabTransactions.Location = new Point(201, 0);
            tabTransactions.Name = "tabTransactions";
            tabTransactions.Size = new Size(1938, 1089);
            tabTransactions.TabIndex = 2;
            tabTransactions.Text = "Transactions";
            // 
            // tabProfile
            // 
            tabProfile.BackColor = Color.WhiteSmoke;
            tabProfile.Controls.Add(uiLinkLabel1);
            tabProfile.Controls.Add(pictureBox1);
            tabProfile.Controls.Add(uitxtuser);
            tabProfile.Controls.Add(uitxtphonenumber);
            tabProfile.Controls.Add(uitxtemail);
            tabProfile.Controls.Add(uitxtfullname);
            tabProfile.Controls.Add(uiButton1);
            tabProfile.Controls.Add(lblPhonenumber);
            tabProfile.Controls.Add(lblEmail);
            tabProfile.Controls.Add(lblFullname);
            tabProfile.Controls.Add(lblUserID);
            tabProfile.Controls.Add(Btneditprofile);
            tabProfile.Controls.Add(uiLabel5);
            tabProfile.Controls.Add(lblmyprofile);
            tabProfile.Cursor = Cursors.Hand;
            tabProfile.Location = new Point(201, 0);
            tabProfile.Name = "tabProfile";
            tabProfile.RightToLeft = RightToLeft.No;
            tabProfile.Size = new Size(1938, 1089);
            tabProfile.TabIndex = 3;
            tabProfile.Text = "Profile";
            // 
            // uiLinkLabel1
            // 
            uiLinkLabel1.ActiveLinkColor = Color.FromArgb(80, 160, 255);
            uiLinkLabel1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLinkLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLinkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            uiLinkLabel1.Location = new Point(92, 453);
            uiLinkLabel1.Margin = new Padding(7, 0, 7, 0);
            uiLinkLabel1.Name = "uiLinkLabel1";
            uiLinkLabel1.Size = new Size(206, 41);
            uiLinkLabel1.TabIndex = 16;
            uiLinkLabel1.TabStop = true;
            uiLinkLabel1.Text = "Upload Profile";
            uiLinkLabel1.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            uiLinkLabel1.Click += uiLinkLabel1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(92, 243);
            pictureBox1.Margin = new Padding(7, 7, 7, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // uitxtuser
            // 
            uitxtuser.Font = new Font("Microsoft Sans Serif", 12F);
            uitxtuser.Location = new Point(406, 523);
            uitxtuser.Margin = new Padding(8, 10, 8, 10);
            uitxtuser.MinimumSize = new Size(2, 33);
            uitxtuser.Name = "uitxtuser";
            uitxtuser.Padding = new Padding(10, 10, 10, 10);
            uitxtuser.RectColor = Color.White;
            uitxtuser.ShowText = false;
            uitxtuser.Size = new Size(638, 66);
            uitxtuser.TabIndex = 14;
            uitxtuser.TextAlignment = ContentAlignment.MiddleLeft;
            uitxtuser.Watermark = "";
            // 
            // uitxtphonenumber
            // 
            uitxtphonenumber.Font = new Font("Microsoft Sans Serif", 12F);
            uitxtphonenumber.Location = new Point(406, 859);
            uitxtphonenumber.Margin = new Padding(8, 10, 8, 10);
            uitxtphonenumber.MinimumSize = new Size(2, 33);
            uitxtphonenumber.Name = "uitxtphonenumber";
            uitxtphonenumber.Padding = new Padding(10, 10, 10, 10);
            uitxtphonenumber.RectColor = Color.White;
            uitxtphonenumber.ShowText = false;
            uitxtphonenumber.Size = new Size(638, 66);
            uitxtphonenumber.TabIndex = 13;
            uitxtphonenumber.TextAlignment = ContentAlignment.MiddleLeft;
            uitxtphonenumber.Watermark = "";
            // 
            // uitxtemail
            // 
            uitxtemail.Font = new Font("Microsoft Sans Serif", 12F);
            uitxtemail.Location = new Point(406, 741);
            uitxtemail.Margin = new Padding(8, 10, 8, 10);
            uitxtemail.MinimumSize = new Size(2, 33);
            uitxtemail.Name = "uitxtemail";
            uitxtemail.Padding = new Padding(10, 10, 10, 10);
            uitxtemail.RectColor = Color.White;
            uitxtemail.ShowText = false;
            uitxtemail.Size = new Size(638, 66);
            uitxtemail.TabIndex = 13;
            uitxtemail.TextAlignment = ContentAlignment.MiddleLeft;
            uitxtemail.Watermark = "";
            // 
            // uitxtfullname
            // 
            uitxtfullname.Font = new Font("Microsoft Sans Serif", 12F);
            uitxtfullname.Location = new Point(406, 636);
            uitxtfullname.Margin = new Padding(8, 10, 8, 10);
            uitxtfullname.MinimumSize = new Size(2, 33);
            uitxtfullname.Name = "uitxtfullname";
            uitxtfullname.Padding = new Padding(10, 10, 10, 10);
            uitxtfullname.RectColor = Color.White;
            uitxtfullname.ShowText = false;
            uitxtfullname.Size = new Size(638, 66);
            uitxtfullname.TabIndex = 13;
            uitxtfullname.TextAlignment = ContentAlignment.MiddleLeft;
            uitxtfullname.Watermark = "";
            // 
            // uiButton1
            // 
            uiButton1.BackColor = Color.WhiteSmoke;
            uiButton1.FillColor = Color.SteelBlue;
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.Location = new Point(92, 976);
            uiButton1.Margin = new Padding(7, 7, 7, 7);
            uiButton1.MinimumSize = new Size(2, 2);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.SkyBlue;
            uiButton1.Size = new Size(1477, 79);
            uiButton1.TabIndex = 11;
            uiButton1.Text = "Update Profile";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // lblPhonenumber
            // 
            lblPhonenumber.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhonenumber.ForeColor = Color.FromArgb(48, 48, 48);
            lblPhonenumber.Location = new Point(92, 889);
            lblPhonenumber.Margin = new Padding(7, 0, 7, 0);
            lblPhonenumber.Name = "lblPhonenumber";
            lblPhonenumber.Size = new Size(355, 59);
            lblPhonenumber.TabIndex = 6;
            lblPhonenumber.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(48, 48, 48);
            lblEmail.Location = new Point(92, 772);
            lblEmail.Margin = new Padding(7, 0, 7, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(265, 59);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblFullname
            // 
            lblFullname.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullname.ForeColor = Color.FromArgb(48, 48, 48);
            lblFullname.Location = new Point(92, 659);
            lblFullname.Margin = new Padding(7, 0, 7, 0);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(265, 59);
            lblFullname.TabIndex = 4;
            lblFullname.Text = "Full Name";
            // 
            // lblUserID
            // 
            lblUserID.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.FromArgb(48, 48, 48);
            lblUserID.Location = new Point(92, 551);
            lblUserID.Margin = new Padding(7, 0, 7, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(265, 62);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "User ID";
            // 
            // Btneditprofile
            // 
            Btneditprofile.BackColor = Color.WhiteSmoke;
            Btneditprofile.FillColor = SystemColors.ActiveCaption;
            Btneditprofile.Font = new Font("Microsoft Sans Serif", 12F);
            Btneditprofile.Location = new Point(1306, 194);
            Btneditprofile.Margin = new Padding(7, 7, 7, 7);
            Btneditprofile.MinimumSize = new Size(2, 2);
            Btneditprofile.Name = "Btneditprofile";
            Btneditprofile.RectColor = Color.SkyBlue;
            Btneditprofile.Size = new Size(264, 75);
            Btneditprofile.TabIndex = 2;
            Btneditprofile.Text = "Edit Profile";
            Btneditprofile.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(92, 154);
            uiLabel5.Margin = new Padding(7, 0, 7, 0);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(899, 59);
            uiLabel5.TabIndex = 1;
            uiLabel5.Text = "Manage your account information.";
            // 
            // lblmyprofile
            // 
            lblmyprofile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmyprofile.ForeColor = Color.FromArgb(48, 48, 48);
            lblmyprofile.Location = new Point(92, 98);
            lblmyprofile.Margin = new Padding(7, 0, 7, 0);
            lblmyprofile.Name = "lblmyprofile";
            lblmyprofile.Size = new Size(355, 56);
            lblmyprofile.TabIndex = 0;
            lblmyprofile.Text = "My Profile";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2139, 1089);
            Controls.Add(tabMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Main";
            Text = "Mini Digital Wallet System";
            Load += Main_Load;
            tabMenu.ResumeLayout(false);
            tabSendMoney.ResumeLayout(false);
            pnlSendMoneyCard.ResumeLayout(false);
            tabProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu tabMenu;
        private TabPage tabDashboard;
        private ImageList imageList1;
        private TabPage tabSendMoney;
        private TabPage tabTransactions;
        private TabPage tabProfile;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtRecipientId;
        private Sunny.UI.UIPanel pnlSendMoneyCard;
        private Sunny.UI.UITextBox txtAmount;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtAddNote;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UISymbolButton btnSendMoney;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel lblmyprofile;
        private Sunny.UI.UIButton Btneditprofile;
        private Sunny.UI.UILabel lblPhonenumber;
        private Sunny.UI.UILabel lblEmail;
        private Sunny.UI.UILabel lblFullname;
        private Sunny.UI.UILabel lblUserID;
        private Sunny.UI.UIIPTextBox uiipTextBox4;
        private Sunny.UI.UIIPTextBox uiipTextBox3;
        private Sunny.UI.UIIPTextBox uiipTextBox2;
        private Sunny.UI.UIIPTextBox uitxtuserid;
        private Sunny.UI.UIButton uiButton1;
        //private Sunny.UI.UITextBox uitxtuserid;
        private Sunny.UI.UITextBox uitxtphonenumber;
        private Sunny.UI.UITextBox uitxtemail;
        private Sunny.UI.UITextBox uitxtfullname;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
        private PictureBox pictureBox1;
        private Sunny.UI.UITextBox uitxtuser;
    }
}