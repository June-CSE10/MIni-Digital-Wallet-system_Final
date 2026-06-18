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
            imageList1 = new ImageList(components);
            uiLedLabel1 = new Sunny.UI.UILedLabel();
            tabMenu.SuspendLayout();
            tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            PanelBalance.SuspendLayout();
            tabSendMoney.SuspendLayout();
            pnlSendMoneyCard.SuspendLayout();
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
            tabMenu.Size = new Size(1219, 822);
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
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Size = new Size(1018, 822);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.Click += tabDashboard_Click;
            // 
            // LblHistory
            // 
            LblHistory.AutoSize = true;
            LblHistory.BackColor = Color.DarkTurquoise;
            LblHistory.ForeColor = SystemColors.HighlightText;
            LblHistory.Location = new Point(91, 216);
            LblHistory.Margin = new Padding(2, 0, 2, 0);
            LblHistory.Name = "LblHistory";
            LblHistory.Size = new Size(87, 29);
            LblHistory.TabIndex = 3;
            LblHistory.Text = "History";
            // 
            // dgvTransactions
            // 
            dgvTransactions.BackgroundColor = SystemColors.ButtonFace;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Columns.AddRange(new DataGridViewColumn[] { colName, colAmount, colDate });
            dgvTransactions.Location = new Point(91, 262);
            dgvTransactions.Margin = new Padding(2);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 102;
            dgvTransactions.Size = new Size(549, 229);
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
            PanelBalance.Location = new Point(91, 112);
            PanelBalance.Margin = new Padding(2);
            PanelBalance.Name = "PanelBalance";
            PanelBalance.Size = new Size(548, 86);
            PanelBalance.TabIndex = 1;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Location = new Point(22, 21);
            LblTotal.Margin = new Padding(2, 0, 2, 0);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(161, 29);
            LblTotal.TabIndex = 2;
            LblTotal.Text = "Total Balance";
            // 
            // LblMoney
            // 
            LblMoney.AutoSize = true;
            LblMoney.Location = new Point(338, 21);
            LblMoney.Margin = new Padding(2, 0, 2, 0);
            LblMoney.Name = "LblMoney";
            LblMoney.Size = new Size(116, 29);
            LblMoney.TabIndex = 0;
            LblMoney.Text = "$1,250.00";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblName.Location = new Point(76, 51);
            LblName.Margin = new Padding(2, 0, 2, 0);
            LblName.Name = "LblName";
            LblName.Size = new Size(356, 45);
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
            tabSendMoney.Name = "tabSendMoney";
            tabSendMoney.Size = new Size(1018, 822);
            tabSendMoney.TabIndex = 1;
            tabSendMoney.Text = "Send Money";
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
            pnlSendMoneyCard.Location = new Point(91, 110);
            pnlSendMoneyCard.Margin = new Padding(4, 5, 4, 5);
            pnlSendMoneyCard.MinimumSize = new Size(1, 1);
            pnlSendMoneyCard.Name = "pnlSendMoneyCard";
            pnlSendMoneyCard.Radius = 20;
            pnlSendMoneyCard.RectColor = Color.FromArgb(230, 230, 230);
            pnlSendMoneyCard.Size = new Size(585, 594);
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
            uiLabel1.Location = new Point(76, 51);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(225, 43);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "Send Money";
            // 
            // tabTransactions
            // 
            tabTransactions.BackColor = Color.WhiteSmoke;
            tabTransactions.Cursor = Cursors.Hand;
            tabTransactions.Location = new Point(201, 0);
            tabTransactions.Name = "tabTransactions";
            tabTransactions.Size = new Size(1018, 822);
            tabTransactions.TabIndex = 2;
            tabTransactions.Text = "Transactions";
            // 
            // tabProfile
            // 
            tabProfile.BackColor = Color.WhiteSmoke;
            tabProfile.Cursor = Cursors.Hand;
            tabProfile.Location = new Point(201, 0);
            tabProfile.Name = "tabProfile";
            tabProfile.RightToLeft = RightToLeft.No;
            tabProfile.Size = new Size(1018, 822);
            tabProfile.TabIndex = 3;
            tabProfile.Text = "Profile";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // uiLedLabel1
            // 
            uiLedLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel1.Location = new Point(751, 236);
            uiLedLabel1.MinimumSize = new Size(1, 1);
            uiLedLabel1.Name = "uiLedLabel1";
            uiLedLabel1.Size = new Size(150, 52);
            uiLedLabel1.TabIndex = 6;
            uiLedLabel1.Text = "uiLedLabel1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 822);
            Controls.Add(tabMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
    }
}