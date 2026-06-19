namespace MIni_Digital_Wallet_system_Final
{
    partial class ModernDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModernDashboard));
            uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            Dashboard = new TabPage();
            SendMoney = new TabPage();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiPanel3 = new Sunny.UI.UIPanel();
            LblNote = new Sunny.UI.UILabel();
            LblAmount = new Sunny.UI.UILabel();
            LblRecipient = new Sunny.UI.UILabel();
            LblDescription = new Sunny.UI.UILabel();
            LblLabel = new Sunny.UI.UILabel();
            Btn100 = new Sunny.UI.UIButton();
            Btn50 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            Btn20 = new Sunny.UI.UIButton();
            Btn10 = new Sunny.UI.UIButton();
            TxtNote = new Sunny.UI.UITextBox();
            BtnSendMoney = new Sunny.UI.UIButton();
            TxtAmount = new Sunny.UI.UITextBox();
            TxtRecipient = new Sunny.UI.UITextBox();
            AddMoney = new TabPage();
            Transactions = new TabPage();
            Contacts = new TabPage();
            uiPanel1 = new Sunny.UI.UIPanel();
            Profile = new TabPage();
            Setting = new TabPage();
            imageList1 = new ImageList(components);
            uiTabControlMenu1.SuspendLayout();
            SendMoney.SuspendLayout();
            uiPanel2.SuspendLayout();
            Contacts.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            uiTabControlMenu1.Alignment = TabAlignment.Left;
            uiTabControlMenu1.Controls.Add(Dashboard);
            uiTabControlMenu1.Controls.Add(SendMoney);
            uiTabControlMenu1.Controls.Add(AddMoney);
            uiTabControlMenu1.Controls.Add(Transactions);
            uiTabControlMenu1.Controls.Add(Contacts);
            uiTabControlMenu1.Controls.Add(Profile);
            uiTabControlMenu1.Controls.Add(Setting);
            uiTabControlMenu1.Dock = DockStyle.Fill;
            uiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMenu1.FillColor = Color.FromArgb(245, 246, 250);
            uiTabControlMenu1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTabControlMenu1.ImageList = imageList1;
            uiTabControlMenu1.Location = new Point(0, 50);
            uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControlMenu1.Multiline = true;
            uiTabControlMenu1.Name = "uiTabControlMenu1";
            uiTabControlMenu1.SelectedIndex = 0;
            uiTabControlMenu1.Size = new Size(1062, 790);
            uiTabControlMenu1.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu1.Style = Sunny.UI.UIStyle.Custom;
            uiTabControlMenu1.TabBackColor = Color.FromArgb(30, 27, 75);
            uiTabControlMenu1.TabIndex = 0;
            uiTabControlMenu1.TabSelectedColor = Color.White;
            uiTabControlMenu1.TabUnSelectedForeColor = Color.LightGray;
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.FromArgb(245, 246, 250);
            Dashboard.ImageIndex = 4;
            Dashboard.Location = new Point(201, 0);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(883, 790);
            Dashboard.TabIndex = 2;
            Dashboard.Text = "Dashboard";
            // 
            // SendMoney
            // 
            SendMoney.BackColor = Color.FromArgb(245, 246, 250);
            SendMoney.Controls.Add(uiPanel2);
            SendMoney.ImageIndex = 5;
            SendMoney.Location = new Point(201, 0);
            SendMoney.Name = "SendMoney";
            SendMoney.Size = new Size(861, 790);
            SendMoney.TabIndex = 1;
            SendMoney.Text = "Send Money";
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(uiPanel3);
            uiPanel2.Controls.Add(LblNote);
            uiPanel2.Controls.Add(LblAmount);
            uiPanel2.Controls.Add(LblRecipient);
            uiPanel2.Controls.Add(LblDescription);
            uiPanel2.Controls.Add(LblLabel);
            uiPanel2.Controls.Add(Btn100);
            uiPanel2.Controls.Add(Btn50);
            uiPanel2.Controls.Add(uiButton1);
            uiPanel2.Controls.Add(Btn20);
            uiPanel2.Controls.Add(Btn10);
            uiPanel2.Controls.Add(TxtNote);
            uiPanel2.Controls.Add(BtnSendMoney);
            uiPanel2.Controls.Add(TxtAmount);
            uiPanel2.Controls.Add(TxtRecipient);
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.FillColor = Color.White;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(0, 0);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 15;
            uiPanel2.RectColor = Color.FromArgb(230, 230, 230);
            uiPanel2.Size = new Size(861, 790);
            uiPanel2.TabIndex = 1;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(600, 172);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Radius = 8;
            uiPanel3.Size = new Size(215, 451);
            uiPanel3.TabIndex = 4;
            uiPanel3.Text = "uiPanel3";
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // LblNote
            // 
            LblNote.Font = new Font("Microsoft Sans Serif", 12F);
            LblNote.ForeColor = Color.FromArgb(48, 48, 48);
            LblNote.Location = new Point(40, 464);
            LblNote.Name = "LblNote";
            LblNote.Size = new Size(65, 34);
            LblNote.TabIndex = 3;
            LblNote.Text = "Note";
            // 
            // LblAmount
            // 
            LblAmount.Font = new Font("Microsoft Sans Serif", 12F);
            LblAmount.ForeColor = Color.FromArgb(48, 48, 48);
            LblAmount.Location = new Point(40, 293);
            LblAmount.Name = "LblAmount";
            LblAmount.Size = new Size(94, 34);
            LblAmount.TabIndex = 3;
            LblAmount.Text = "Amount";
            // 
            // LblRecipient
            // 
            LblRecipient.Font = new Font("Microsoft Sans Serif", 12F);
            LblRecipient.ForeColor = Color.FromArgb(48, 48, 48);
            LblRecipient.Location = new Point(40, 172);
            LblRecipient.Name = "LblRecipient";
            LblRecipient.Size = new Size(117, 34);
            LblRecipient.TabIndex = 3;
            LblRecipient.Text = "Recipient";
            // 
            // LblDescription
            // 
            LblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescription.ForeColor = Color.FromArgb(48, 48, 48);
            LblDescription.Location = new Point(40, 100);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(313, 34);
            LblDescription.TabIndex = 2;
            LblDescription.Text = "Send demo money to any user";
            // 
            // LblLabel
            // 
            LblLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LblLabel.ForeColor = Color.FromArgb(48, 48, 48);
            LblLabel.Location = new Point(40, 40);
            LblLabel.Name = "LblLabel";
            LblLabel.Size = new Size(240, 60);
            LblLabel.TabIndex = 2;
            LblLabel.Text = "Send Money";
            // 
            // Btn100
            // 
            Btn100.Cursor = Cursors.Hand;
            Btn100.FillColor = Color.FromArgb(96, 43, 217);
            Btn100.Font = new Font("Microsoft Sans Serif", 12F);
            Btn100.Location = new Point(460, 400);
            Btn100.MinimumSize = new Size(1, 1);
            Btn100.Name = "Btn100";
            Btn100.Radius = 8;
            Btn100.RectColor = Color.FromArgb(96, 43, 217);
            Btn100.Size = new Size(100, 50);
            Btn100.TabIndex = 1;
            Btn100.Text = "$ 100";
            Btn100.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // Btn50
            // 
            Btn50.Cursor = Cursors.Hand;
            Btn50.FillColor = Color.FromArgb(96, 43, 217);
            Btn50.Font = new Font("Microsoft Sans Serif", 12F);
            Btn50.Location = new Point(355, 400);
            Btn50.MinimumSize = new Size(1, 1);
            Btn50.Name = "Btn50";
            Btn50.Radius = 8;
            Btn50.RectColor = Color.FromArgb(96, 43, 217);
            Btn50.Size = new Size(100, 50);
            Btn50.TabIndex = 1;
            Btn50.Text = "$ 50";
            Btn50.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiButton1
            // 
            uiButton1.Cursor = Cursors.Hand;
            uiButton1.FillColor = Color.FromArgb(96, 43, 217);
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.Location = new Point(145, 400);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Radius = 8;
            uiButton1.RectColor = Color.FromArgb(96, 43, 217);
            uiButton1.Size = new Size(100, 50);
            uiButton1.TabIndex = 1;
            uiButton1.Text = "$ 20";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // Btn20
            // 
            Btn20.Cursor = Cursors.Hand;
            Btn20.FillColor = Color.FromArgb(96, 43, 217);
            Btn20.Font = new Font("Microsoft Sans Serif", 12F);
            Btn20.Location = new Point(250, 400);
            Btn20.MinimumSize = new Size(1, 1);
            Btn20.Name = "Btn20";
            Btn20.Radius = 8;
            Btn20.RectColor = Color.FromArgb(96, 43, 217);
            Btn20.Size = new Size(100, 50);
            Btn20.TabIndex = 1;
            Btn20.Text = "$ 20";
            Btn20.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // Btn10
            // 
            Btn10.Cursor = Cursors.Hand;
            Btn10.FillColor = Color.FromArgb(96, 43, 217);
            Btn10.Font = new Font("Microsoft Sans Serif", 12F);
            Btn10.Location = new Point(40, 400);
            Btn10.MinimumSize = new Size(1, 1);
            Btn10.Name = "Btn10";
            Btn10.Radius = 8;
            Btn10.RectColor = Color.FromArgb(96, 43, 217);
            Btn10.Size = new Size(100, 50);
            Btn10.TabIndex = 1;
            Btn10.Text = "$ 10";
            Btn10.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // TxtNote
            // 
            TxtNote.Font = new Font("Microsoft Sans Serif", 12F);
            TxtNote.Location = new Point(40, 503);
            TxtNote.Margin = new Padding(4, 5, 4, 5);
            TxtNote.MinimumSize = new Size(520, 40);
            TxtNote.Name = "TxtNote";
            TxtNote.Padding = new Padding(5);
            TxtNote.Radius = 8;
            TxtNote.RectColor = Color.LightGray;
            TxtNote.ShortcutsEnabled = false;
            TxtNote.ShowText = false;
            TxtNote.Size = new Size(520, 120);
            TxtNote.TabIndex = 0;
            TxtNote.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNote.Watermark = "Add a note";
            // 
            // BtnSendMoney
            // 
            BtnSendMoney.Cursor = Cursors.Hand;
            BtnSendMoney.FillColor = Color.FromArgb(96, 43, 217);
            BtnSendMoney.Font = new Font("Microsoft Sans Serif", 12F);
            BtnSendMoney.Location = new Point(40, 662);
            BtnSendMoney.MinimumSize = new Size(1, 1);
            BtnSendMoney.Name = "BtnSendMoney";
            BtnSendMoney.Radius = 8;
            BtnSendMoney.RectColor = Color.FromArgb(96, 43, 217);
            BtnSendMoney.Size = new Size(520, 60);
            BtnSendMoney.TabIndex = 1;
            BtnSendMoney.Text = "Send Money";
            BtnSendMoney.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // TxtAmount
            // 
            TxtAmount.Font = new Font("Microsoft Sans Serif", 12F);
            TxtAmount.Location = new Point(40, 332);
            TxtAmount.Margin = new Padding(4, 5, 4, 5);
            TxtAmount.MinimumSize = new Size(520, 40);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Padding = new Padding(5);
            TxtAmount.Radius = 8;
            TxtAmount.RectColor = Color.LightGray;
            TxtAmount.ShortcutsEnabled = false;
            TxtAmount.ShowText = false;
            TxtAmount.Size = new Size(520, 60);
            TxtAmount.TabIndex = 0;
            TxtAmount.TextAlignment = ContentAlignment.MiddleLeft;
            TxtAmount.Watermark = "Enter amount";
            // 
            // TxtRecipient
            // 
            TxtRecipient.Font = new Font("Microsoft Sans Serif", 12F);
            TxtRecipient.Location = new Point(40, 211);
            TxtRecipient.Margin = new Padding(4, 5, 4, 5);
            TxtRecipient.MinimumSize = new Size(520, 40);
            TxtRecipient.Name = "TxtRecipient";
            TxtRecipient.Padding = new Padding(5);
            TxtRecipient.Radius = 8;
            TxtRecipient.RectColor = Color.LightGray;
            TxtRecipient.ShortcutsEnabled = false;
            TxtRecipient.ShowText = false;
            TxtRecipient.Size = new Size(520, 60);
            TxtRecipient.TabIndex = 0;
            TxtRecipient.TextAlignment = ContentAlignment.MiddleLeft;
            TxtRecipient.Watermark = "Enter recipient email or select from contacts";
            // 
            // AddMoney
            // 
            AddMoney.BackColor = Color.FromArgb(245, 246, 250);
            AddMoney.ImageIndex = 2;
            AddMoney.Location = new Point(201, 0);
            AddMoney.Name = "AddMoney";
            AddMoney.Size = new Size(883, 790);
            AddMoney.TabIndex = 3;
            AddMoney.Text = "Add Money";
            // 
            // Transactions
            // 
            Transactions.BackColor = Color.FromArgb(245, 246, 250);
            Transactions.ImageIndex = 6;
            Transactions.Location = new Point(201, 0);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(883, 790);
            Transactions.TabIndex = 4;
            Transactions.Text = "Transactions";
            // 
            // Contacts
            // 
            Contacts.BackColor = Color.FromArgb(245, 246, 250);
            Contacts.Controls.Add(uiPanel1);
            Contacts.ImageIndex = 3;
            Contacts.Location = new Point(201, 0);
            Contacts.Name = "Contacts";
            Contacts.Size = new Size(883, 790);
            Contacts.TabIndex = 5;
            Contacts.Text = "Contacts";
            // 
            // uiPanel1
            // 
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.FillColor = Color.White;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.FromArgb(230, 230, 230);
            uiPanel1.Size = new Size(883, 790);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = "uiPanel1";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Profile
            // 
            Profile.BackColor = Color.FromArgb(245, 246, 250);
            Profile.ImageIndex = 2;
            Profile.Location = new Point(201, 0);
            Profile.Name = "Profile";
            Profile.Size = new Size(883, 790);
            Profile.TabIndex = 6;
            Profile.Text = "Profile";
            // 
            // Setting
            // 
            Setting.BackColor = Color.FromArgb(245, 246, 250);
            Setting.ImageIndex = 0;
            Setting.Location = new Point(201, 0);
            Setting.Name = "Setting";
            Setting.Size = new Size(883, 790);
            Setting.TabIndex = 7;
            Setting.Text = "Setting";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-settings-50.png");
            imageList1.Images.SetKeyName(1, "icons8-administrator-male-50.png");
            imageList1.Images.SetKeyName(2, "icons8-add-money-48.png");
            imageList1.Images.SetKeyName(3, "icons8-contact-50.png");
            imageList1.Images.SetKeyName(4, "icons8-dashboard-50.png");
            imageList1.Images.SetKeyName(5, "icons8-send-money-50.png");
            imageList1.Images.SetKeyName(6, "icons8-transaction-64.png");
            // 
            // ModernDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1062, 840);
            Controls.Add(uiTabControlMenu1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModernDashboard";
            Padding = new Padding(0, 50, 0, 0);
            Style = Sunny.UI.UIStyle.Custom;
            Text = "Mini Digital Wallet";
            TitleColor = Color.FromArgb(30, 27, 75);
            TitleFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(22, 22, 1258, 664);
            Load += ModernDashboard_Load;
            uiTabControlMenu1.ResumeLayout(false);
            SendMoney.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            Contacts.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage SendMoney;
        private TabPage Dashboard;
        private TabPage AddMoney;
        private TabPage Transactions;
        private ImageList imageList1;
        private TabPage Contacts;
        private TabPage Profile;
        private TabPage Setting;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UITextBox TxtRecipient;
        private Sunny.UI.UIButton BtnSendMoney;
        private Sunny.UI.UILabel LblDescription;
        private Sunny.UI.UILabel LblLabel;
        private Sunny.UI.UILabel LblRecipient;
        private Sunny.UI.UILabel LblAmount;
        private Sunny.UI.UITextBox TxtAmount;
        private Sunny.UI.UIButton Btn100;
        private Sunny.UI.UIButton Btn50;
        private Sunny.UI.UIButton Btn20;
        private Sunny.UI.UIButton Btn10;
        private Sunny.UI.UILabel LblNote;
        private Sunny.UI.UITextBox TxtNote;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIButton uiButton1;
    }
}