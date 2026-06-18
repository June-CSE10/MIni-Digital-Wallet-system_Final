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
            btnSendMoney = new Sunny.UI.UIButton();
            txtAddNote = new Sunny.UI.UITextBox();
            txtAmount = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            txtRecipientId = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            tabTransactions = new TabPage();
            tabProfile = new TabPage();
            imageList1 = new ImageList(components);
            tabMenu.SuspendLayout();
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
            tabMenu.Size = new Size(798, 464);
            tabMenu.SizeMode = TabSizeMode.Fixed;
            tabMenu.TabBackColor = Color.FromArgb(30, 27, 75);
            tabMenu.TabIndex = 0;
            tabMenu.TabUnSelectedForeColor = Color.WhiteSmoke;
            // 
            // tabDashboard
            // 
            tabDashboard.BackColor = Color.WhiteSmoke;
            tabDashboard.Cursor = Cursors.Hand;
            tabDashboard.Location = new Point(201, 0);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Size = new Size(597, 464);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            // 
            // tabSendMoney
            // 
            tabSendMoney.BackColor = Color.WhiteSmoke;
            tabSendMoney.Controls.Add(pnlSendMoneyCard);
            tabSendMoney.Controls.Add(uiLabel1);
            tabSendMoney.Cursor = Cursors.Hand;
            tabSendMoney.Location = new Point(201, 0);
            tabSendMoney.Name = "tabSendMoney";
            tabSendMoney.Size = new Size(597, 464);
            tabSendMoney.TabIndex = 1;
            tabSendMoney.Text = "Send Money";
            // 
            // pnlSendMoneyCard
            // 
            pnlSendMoneyCard.BackColor = Color.White;
            pnlSendMoneyCard.Controls.Add(btnSendMoney);
            pnlSendMoneyCard.Controls.Add(txtAddNote);
            pnlSendMoneyCard.Controls.Add(txtAmount);
            pnlSendMoneyCard.Controls.Add(uiLabel4);
            pnlSendMoneyCard.Controls.Add(uiLabel2);
            pnlSendMoneyCard.Controls.Add(txtRecipientId);
            pnlSendMoneyCard.Controls.Add(uiLabel3);
            pnlSendMoneyCard.Font = new Font("Microsoft Sans Serif", 12F);
            pnlSendMoneyCard.Location = new Point(81, 51);
            pnlSendMoneyCard.Margin = new Padding(4, 5, 4, 5);
            pnlSendMoneyCard.MinimumSize = new Size(1, 1);
            pnlSendMoneyCard.Name = "pnlSendMoneyCard";
            pnlSendMoneyCard.Radius = 10;
            pnlSendMoneyCard.Size = new Size(435, 365);
            pnlSendMoneyCard.TabIndex = 4;
            pnlSendMoneyCard.Text = null;
            pnlSendMoneyCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnSendMoney
            // 
            btnSendMoney.FillColor = Color.FromArgb(96, 43, 217);
            btnSendMoney.Font = new Font("Microsoft Sans Serif", 12F);
            btnSendMoney.Location = new Point(41, 288);
            btnSendMoney.MinimumSize = new Size(1, 1);
            btnSendMoney.Name = "btnSendMoney";
            btnSendMoney.Radius = 6;
            btnSendMoney.Size = new Size(355, 52);
            btnSendMoney.TabIndex = 5;
            btnSendMoney.Text = "Send Money";
            btnSendMoney.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSendMoney.Click += btnSendMoney_Click;
            // 
            // txtAddNote
            // 
            txtAddNote.Font = new Font("Microsoft Sans Serif", 12F);
            txtAddNote.ForeColor = Color.Black;
            txtAddNote.Location = new Point(41, 232);
            txtAddNote.Margin = new Padding(4, 5, 4, 5);
            txtAddNote.MaxLength = 200;
            txtAddNote.MinimumSize = new Size(1, 16);
            txtAddNote.Name = "txtAddNote";
            txtAddNote.Padding = new Padding(5);
            txtAddNote.Radius = 6;
            txtAddNote.ShowText = false;
            txtAddNote.Size = new Size(355, 36);
            txtAddNote.Symbol = 61788;
            txtAddNote.SymbolColor = Color.FromArgb(30, 27, 75);
            txtAddNote.TabIndex = 3;
            txtAddNote.TextAlignment = ContentAlignment.MiddleCenter;
            txtAddNote.Watermark = "Add a note";
            txtAddNote.WatermarkActiveColor = Color.LightGray;
            txtAddNote.WatermarkColor = Color.Gainsboro;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Microsoft Sans Serif", 12F);
            txtAmount.ForeColor = Color.Black;
            txtAmount.Location = new Point(42, 152);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.MinimumSize = new Size(1, 16);
            txtAmount.Name = "txtAmount";
            txtAmount.Padding = new Padding(5);
            txtAmount.Radius = 6;
            txtAmount.ShowText = false;
            txtAmount.Size = new Size(355, 36);
            txtAmount.Symbol = 61781;
            txtAmount.SymbolColor = Color.FromArgb(30, 27, 75);
            txtAmount.TabIndex = 3;
            txtAmount.TextAlignment = ContentAlignment.MiddleCenter;
            txtAmount.Watermark = "Enter amount";
            txtAmount.WatermarkActiveColor = Color.LightGray;
            txtAmount.WatermarkColor = Color.Gainsboro;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(42, 193);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(160, 34);
            uiLabel4.TabIndex = 2;
            uiLabel4.Text = "Note (optional)";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(42, 113);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(150, 34);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "Amount";
            // 
            // txtRecipientId
            // 
            txtRecipientId.Font = new Font("Microsoft Sans Serif", 12F);
            txtRecipientId.ForeColor = Color.Black;
            txtRecipientId.Location = new Point(42, 68);
            txtRecipientId.Margin = new Padding(4, 5, 4, 5);
            txtRecipientId.MinimumSize = new Size(1, 16);
            txtRecipientId.Name = "txtRecipientId";
            txtRecipientId.Padding = new Padding(5);
            txtRecipientId.Radius = 6;
            txtRecipientId.ShowText = false;
            txtRecipientId.Size = new Size(355, 36);
            txtRecipientId.Symbol = 62146;
            txtRecipientId.SymbolColor = Color.FromArgb(30, 27, 75);
            txtRecipientId.TabIndex = 3;
            txtRecipientId.TextAlignment = ContentAlignment.MiddleCenter;
            txtRecipientId.Watermark = "Enter recipient ID";
            txtRecipientId.WatermarkActiveColor = Color.LightGray;
            txtRecipientId.WatermarkColor = Color.Gainsboro;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(42, 29);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(150, 34);
            uiLabel3.TabIndex = 2;
            uiLabel3.Text = "Recipient ID";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(81, 3);
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
            tabTransactions.Size = new Size(597, 464);
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
            tabProfile.Size = new Size(597, 464);
            tabProfile.TabIndex = 3;
            tabProfile.Text = "Profile";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 464);
            Controls.Add(tabMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Main";
            Text = "Mini Digital Wallet System";
            tabMenu.ResumeLayout(false);
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
        private Sunny.UI.UIButton btnSendMoney;
    }
}