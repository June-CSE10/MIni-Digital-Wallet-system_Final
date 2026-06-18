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
            LblHistory = new Label();
            dgvTransactions = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            PanelBalance = new Panel();
            LblTotal = new Label();
            LblMoney = new Label();
            LblName = new Label();
            tabSendMoney = new TabPage();
            uiLedLabel1 = new Sunny.UI.UILedLabel();
            pnlSendMoneyCard = new Sunny.UI.UIPanel();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            txtAddNote = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            txtAmount = new Sunny.UI.UITextBox();
            txtRecipientId = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            tabTransactions = new TabPage();
            tabProfile = new TabPage();
            uiipTextBox4 = new Sunny.UI.UIIPTextBox();
            uiipTextBox3 = new Sunny.UI.UIIPTextBox();
            uiipTextBox2 = new Sunny.UI.UIIPTextBox();
            uitxtuserid = new Sunny.UI.UIIPTextBox();
            lblPhonenumber = new Sunny.UI.UILabel();
            lblEmail = new Sunny.UI.UILabel();
            lblFullname = new Sunny.UI.UILabel();
            lblUserID = new Sunny.UI.UILabel();
            Btneditprofile = new Sunny.UI.UIButton();
            uiLabel5 = new Sunny.UI.UILabel();
            lblmyprofile = new Sunny.UI.UILabel();
            imageList1 = new ImageList(components);
            uiButton1 = new Sunny.UI.UIButton();
            tabMenu.SuspendLayout();
            tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            PanelBalance.SuspendLayout();
            tabSendMoney.SuspendLayout();
            pnlSendMoneyCard.SuspendLayout();
            tabProfile.SuspendLayout();
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
            tabMenu.Margin = new Padding(2);
            tabMenu.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            tabMenu.Multiline = true;
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(975, 658);
            tabMenu.SizeMode = TabSizeMode.Fixed;
            tabMenu.TabBackColor = Color.FromArgb(96, 43, 217);
            tabMenu.TabIndex = 0;
            tabMenu.TabUnSelectedForeColor = Color.WhiteSmoke;
            // 
            // tabDashboard
            // 
            tabDashboard.BackColor = Color.WhiteSmoke;
            tabDashboard.Controls.Add(LblHistory);
            tabDashboard.Controls.Add(dgvTransactions);
            tabDashboard.Controls.Add(PanelBalance);
            tabDashboard.Controls.Add(LblName);
            tabDashboard.Cursor = Cursors.Hand;
            tabDashboard.Location = new Point(201, 0);
            tabDashboard.Margin = new Padding(2);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Size = new Size(774, 658);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.Click += tabDashboard_Click;
            // 
            // LblHistory
            // 
            LblHistory.AutoSize = true;
            LblHistory.BackColor = Color.DarkTurquoise;
            LblHistory.ForeColor = SystemColors.HighlightText;
            LblHistory.Location = new Point(73, 173);
            LblHistory.Margin = new Padding(2, 0, 2, 0);
            LblHistory.Name = "LblHistory";
            LblHistory.Size = new Size(72, 25);
            LblHistory.TabIndex = 3;
            LblHistory.Text = "History";
            // 
            // dgvTransactions
            // 
            dgvTransactions.BackgroundColor = SystemColors.ButtonFace;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Columns.AddRange(new DataGridViewColumn[] { colName, colAmount, colDate });
            dgvTransactions.Location = new Point(73, 210);
            dgvTransactions.Margin = new Padding(2);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 102;
            dgvTransactions.Size = new Size(439, 183);
            dgvTransactions.TabIndex = 2;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 12;
            colName.Name = "colName";
            colName.Width = 250;
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Amount";
            colAmount.MinimumWidth = 12;
            colAmount.Name = "colAmount";
            colAmount.Width = 250;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 12;
            colDate.Name = "colDate";
            colDate.Width = 250;
            // 
            // PanelBalance
            // 
            PanelBalance.BackColor = Color.MediumTurquoise;
            PanelBalance.Controls.Add(LblTotal);
            PanelBalance.Controls.Add(LblMoney);
            PanelBalance.ForeColor = SystemColors.ControlLightLight;
            PanelBalance.Location = new Point(73, 90);
            PanelBalance.Margin = new Padding(2);
            PanelBalance.Name = "PanelBalance";
            PanelBalance.Size = new Size(438, 69);
            PanelBalance.TabIndex = 1;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Location = new Point(18, 17);
            LblTotal.Margin = new Padding(2, 0, 2, 0);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(132, 25);
            LblTotal.TabIndex = 2;
            LblTotal.Text = "Total Balance";
            // 
            // LblMoney
            // 
            LblMoney.AutoSize = true;
            LblMoney.Location = new Point(270, 17);
            LblMoney.Margin = new Padding(2, 0, 2, 0);
            LblMoney.Name = "LblMoney";
            LblMoney.Size = new Size(99, 25);
            LblMoney.TabIndex = 0;
            LblMoney.Text = "$1,250.00";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblName.Location = new Point(61, 41);
            LblName.Margin = new Padding(2, 0, 2, 0);
            LblName.Name = "LblName";
            LblName.Size = new Size(301, 37);
            LblName.TabIndex = 0;
            LblName.Text = "Good Morning, Messi!";
            // 
            // tabSendMoney
            // 
            tabSendMoney.BackColor = Color.WhiteSmoke;
            tabSendMoney.Controls.Add(uiLedLabel1);
            tabSendMoney.Controls.Add(pnlSendMoneyCard);
            tabSendMoney.Controls.Add(uiLabel1);
            tabSendMoney.Cursor = Cursors.Hand;
            tabSendMoney.Location = new Point(201, 0);
            tabSendMoney.Margin = new Padding(2);
            tabSendMoney.Name = "tabSendMoney";
            tabSendMoney.Size = new Size(774, 658);
            tabSendMoney.TabIndex = 1;
            tabSendMoney.Text = "Send Money";
            // 
            // uiLedLabel1
            // 
            uiLedLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel1.Location = new Point(601, 189);
            uiLedLabel1.Margin = new Padding(2);
            uiLedLabel1.MinimumSize = new Size(1, 1);
            uiLedLabel1.Name = "uiLedLabel1";
            uiLedLabel1.Size = new Size(120, 42);
            uiLedLabel1.TabIndex = 6;
            uiLedLabel1.Text = "uiLedLabel1";
            // 
            // pnlSendMoneyCard
            // 
            pnlSendMoneyCard.BackColor = Color.Transparent;
            pnlSendMoneyCard.BackgroundImageLayout = ImageLayout.None;
            pnlSendMoneyCard.Controls.Add(uiSymbolButton1);
            pnlSendMoneyCard.Controls.Add(txtAddNote);
            pnlSendMoneyCard.Controls.Add(uiLabel4);
            pnlSendMoneyCard.Controls.Add(uiLabel3);
            pnlSendMoneyCard.Controls.Add(uiLabel2);
            pnlSendMoneyCard.Controls.Add(txtAmount);
            pnlSendMoneyCard.Controls.Add(txtRecipientId);
            pnlSendMoneyCard.FillColor = Color.White;
            pnlSendMoneyCard.FillColor2 = Color.FromArgb(248, 248, 248);
            pnlSendMoneyCard.Font = new Font("Microsoft Sans Serif", 12F);
            pnlSendMoneyCard.Location = new Point(73, 88);
            pnlSendMoneyCard.Margin = new Padding(3, 4, 3, 4);
            pnlSendMoneyCard.MinimumSize = new Size(1, 1);
            pnlSendMoneyCard.Name = "pnlSendMoneyCard";
            pnlSendMoneyCard.Radius = 20;
            pnlSendMoneyCard.RectColor = Color.FromArgb(230, 230, 230);
            pnlSendMoneyCard.Size = new Size(663, 511);
            pnlSendMoneyCard.Style = Sunny.UI.UIStyle.Custom;
            pnlSendMoneyCard.TabIndex = 4;
            pnlSendMoneyCard.Text = null;
            pnlSendMoneyCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.FillColor = Color.FromArgb(96, 43, 217);
            uiSymbolButton1.FillHoverColor = Color.FromArgb(120, 60, 255);
            uiSymbolButton1.FillPressColor = Color.FromArgb(70, 20, 180);
            uiSymbolButton1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiSymbolButton1.Location = new Point(49, 434);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.RectColor = Color.FromArgb(96, 43, 217);
            uiSymbolButton1.RectHoverColor = Color.FromArgb(120, 60, 255);
            uiSymbolButton1.RectPressColor = Color.FromArgb(70, 20, 180);
            uiSymbolButton1.Size = new Size(499, 52);
            uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolButton1.Symbol = 61912;
            uiSymbolButton1.SymbolSize = 34;
            uiSymbolButton1.TabIndex = 5;
            uiSymbolButton1.Text = "Send Money";
            uiSymbolButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
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
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(38, 301);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(160, 34);
            uiLabel4.TabIndex = 2;
            uiLabel4.Text = "Note (optional)";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(38, 70);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(150, 34);
            uiLabel3.TabIndex = 2;
            uiLabel3.Text = "Recipient ID";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
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
            uiLabel1.Location = new Point(61, 41);
            uiLabel1.Margin = new Padding(2, 0, 2, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(180, 34);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "Send Money";
            // 
            // tabTransactions
            // 
            tabTransactions.BackColor = Color.WhiteSmoke;
            tabTransactions.Cursor = Cursors.Hand;
            tabTransactions.Location = new Point(201, 0);
            tabTransactions.Margin = new Padding(2);
            tabTransactions.Name = "tabTransactions";
            tabTransactions.Size = new Size(774, 658);
            tabTransactions.TabIndex = 2;
            tabTransactions.Text = "Transactions";
            // 
            // tabProfile
            // 
            tabProfile.BackColor = Color.WhiteSmoke;
            tabProfile.Controls.Add(uiButton1);
            tabProfile.Controls.Add(uiipTextBox4);
            tabProfile.Controls.Add(uiipTextBox3);
            tabProfile.Controls.Add(uiipTextBox2);
            tabProfile.Controls.Add(uitxtuserid);
            tabProfile.Controls.Add(lblPhonenumber);
            tabProfile.Controls.Add(lblEmail);
            tabProfile.Controls.Add(lblFullname);
            tabProfile.Controls.Add(lblUserID);
            tabProfile.Controls.Add(Btneditprofile);
            tabProfile.Controls.Add(uiLabel5);
            tabProfile.Controls.Add(lblmyprofile);
            tabProfile.Cursor = Cursors.Hand;
            tabProfile.Location = new Point(201, 0);
            tabProfile.Margin = new Padding(2);
            tabProfile.Name = "tabProfile";
            tabProfile.RightToLeft = RightToLeft.No;
            tabProfile.Size = new Size(774, 658);
            tabProfile.TabIndex = 3;
            tabProfile.Text = "Profile";
            // 
            // uiipTextBox4
            // 
            uiipTextBox4.FillColor2 = Color.FromArgb(235, 243, 255);
            uiipTextBox4.Font = new Font("Microsoft Sans Serif", 12F);
            uiipTextBox4.Location = new Point(199, 422);
            uiipTextBox4.Margin = new Padding(4, 5, 4, 5);
            uiipTextBox4.MinimumSize = new Size(1, 1);
            uiipTextBox4.Name = "uiipTextBox4";
            uiipTextBox4.Padding = new Padding(1);
            uiipTextBox4.RectColor = Color.White;
            uiipTextBox4.ShowText = false;
            uiipTextBox4.Size = new Size(310, 32);
            uiipTextBox4.TabIndex = 10;
            uiipTextBox4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiipTextBox3
            // 
            uiipTextBox3.FillColor2 = Color.FromArgb(235, 243, 255);
            uiipTextBox3.Font = new Font("Microsoft Sans Serif", 12F);
            uiipTextBox3.Location = new Point(199, 365);
            uiipTextBox3.Margin = new Padding(4, 5, 4, 5);
            uiipTextBox3.MinimumSize = new Size(1, 1);
            uiipTextBox3.Name = "uiipTextBox3";
            uiipTextBox3.Padding = new Padding(1);
            uiipTextBox3.RectColor = Color.White;
            uiipTextBox3.ShowText = false;
            uiipTextBox3.Size = new Size(310, 32);
            uiipTextBox3.TabIndex = 9;
            uiipTextBox3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiipTextBox2
            // 
            uiipTextBox2.FillColor2 = Color.FromArgb(235, 243, 255);
            uiipTextBox2.Font = new Font("Microsoft Sans Serif", 12F);
            uiipTextBox2.Location = new Point(199, 313);
            uiipTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiipTextBox2.MinimumSize = new Size(1, 1);
            uiipTextBox2.Name = "uiipTextBox2";
            uiipTextBox2.Padding = new Padding(1);
            uiipTextBox2.RectColor = Color.White;
            uiipTextBox2.ShowText = false;
            uiipTextBox2.Size = new Size(310, 32);
            uiipTextBox2.TabIndex = 8;
            uiipTextBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uitxtuserid
            // 
            uitxtuserid.FillColor2 = Color.FromArgb(245, 251, 241);
            uitxtuserid.Font = new Font("Microsoft Sans Serif", 12F);
            uitxtuserid.Location = new Point(199, 257);
            uitxtuserid.Margin = new Padding(4, 5, 4, 5);
            uitxtuserid.MinimumSize = new Size(1, 1);
            uitxtuserid.Name = "uitxtuserid";
            uitxtuserid.Padding = new Padding(1);
            uitxtuserid.RectColor = Color.White;
            uitxtuserid.ShowText = false;
            uitxtuserid.Size = new Size(310, 32);
            uitxtuserid.Style = Sunny.UI.UIStyle.Custom;
            uitxtuserid.TabIndex = 7;
            uitxtuserid.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblPhonenumber
            // 
            lblPhonenumber.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhonenumber.ForeColor = Color.FromArgb(48, 48, 48);
            lblPhonenumber.Location = new Point(43, 434);
            lblPhonenumber.Name = "lblPhonenumber";
            lblPhonenumber.Size = new Size(167, 29);
            lblPhonenumber.TabIndex = 6;
            lblPhonenumber.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(48, 48, 48);
            lblEmail.Location = new Point(43, 377);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(125, 29);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblFullname
            // 
            lblFullname.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullname.ForeColor = Color.FromArgb(48, 48, 48);
            lblFullname.Location = new Point(43, 322);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(125, 29);
            lblFullname.TabIndex = 4;
            lblFullname.Text = "Full Name";
            // 
            // lblUserID
            // 
            lblUserID.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.FromArgb(48, 48, 48);
            lblUserID.Location = new Point(43, 269);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(125, 30);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "User ID";
            // 
            // Btneditprofile
            // 
            Btneditprofile.BackColor = Color.WhiteSmoke;
            Btneditprofile.FillColor = SystemColors.ActiveCaption;
            Btneditprofile.Font = new Font("Microsoft Sans Serif", 12F);
            Btneditprofile.Location = new Point(614, 94);
            Btneditprofile.MinimumSize = new Size(1, 1);
            Btneditprofile.Name = "Btneditprofile";
            Btneditprofile.RectColor = Color.SkyBlue;
            Btneditprofile.Size = new Size(124, 37);
            Btneditprofile.TabIndex = 2;
            Btneditprofile.Text = "Edit Profile";
            Btneditprofile.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(43, 75);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(423, 29);
            uiLabel5.TabIndex = 1;
            uiLabel5.Text = "Manage your account information.";
            // 
            // lblmyprofile
            // 
            lblmyprofile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmyprofile.ForeColor = Color.FromArgb(48, 48, 48);
            lblmyprofile.Location = new Point(43, 48);
            lblmyprofile.Name = "lblmyprofile";
            lblmyprofile.Size = new Size(167, 27);
            lblmyprofile.TabIndex = 0;
            lblmyprofile.Text = "My Profile";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // uiButton1
            // 
            uiButton1.BackColor = Color.WhiteSmoke;
            uiButton1.FillColor = Color.SteelBlue;
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.Location = new Point(43, 491);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.SkyBlue;
            uiButton1.Size = new Size(695, 38);
            uiButton1.TabIndex = 11;
            uiButton1.Text = "Update Profile";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 658);
            Controls.Add(tabMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Main";
            Text = "Mini Digital Wallet System";
            Load += Main_Load;
            tabMenu.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tabDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            PanelBalance.ResumeLayout(false);
            PanelBalance.PerformLayout();
            tabSendMoney.ResumeLayout(false);
            pnlSendMoneyCard.ResumeLayout(false);
            tabProfile.ResumeLayout(false);
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
        private Label LblName;
        private Panel PanelBalance;
        private Label LblTotal;
        private Label LblMoney;
        private DataGridView dgvTransactions;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colDate;
        private Label LblHistory;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UILedLabel uiLedLabel1;
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
    }
}