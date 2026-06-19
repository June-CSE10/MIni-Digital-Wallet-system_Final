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
            uiButton1 = new Sunny.UI.UIButton();
            uiTextBox1 = new Sunny.UI.UITextBox();
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
            uiTabControlMenu1.Size = new Size(1280, 670);
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
            Dashboard.Size = new Size(1079, 670);
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
            SendMoney.Size = new Size(1079, 670);
            SendMoney.TabIndex = 1;
            SendMoney.Text = "Send Money";
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(uiButton1);
            uiPanel2.Controls.Add(uiTextBox1);
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.FillColor = Color.White;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(0, 0);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 15;
            uiPanel2.RectColor = Color.FromArgb(230, 230, 230);
            uiPanel2.Size = new Size(1079, 670);
            uiPanel2.TabIndex = 1;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            uiButton1.Cursor = Cursors.Hand;
            uiButton1.FillColor = Color.FromArgb(96, 43, 217);
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.Location = new Point(315, 253);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Radius = 8;
            uiButton1.RectColor = Color.FromArgb(96, 43, 217);
            uiButton1.Size = new Size(150, 52);
            uiButton1.TabIndex = 1;
            uiButton1.Text = "uiButton1";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox1.Location = new Point(164, 104);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.Radius = 8;
            uiTextBox1.RectColor = Color.LightGray;
            uiTextBox1.ShortcutsEnabled = false;
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(225, 44);
            uiTextBox1.TabIndex = 0;
            uiTextBox1.Text = "uiTextBox1";
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // AddMoney
            // 
            AddMoney.BackColor = Color.FromArgb(245, 246, 250);
            AddMoney.ImageIndex = 2;
            AddMoney.Location = new Point(201, 0);
            AddMoney.Name = "AddMoney";
            AddMoney.Size = new Size(1079, 670);
            AddMoney.TabIndex = 3;
            AddMoney.Text = "Add Money";
            // 
            // Transactions
            // 
            Transactions.BackColor = Color.FromArgb(245, 246, 250);
            Transactions.ImageIndex = 6;
            Transactions.Location = new Point(201, 0);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(1079, 670);
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
            Contacts.Size = new Size(1079, 670);
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
            uiPanel1.Size = new Size(1079, 670);
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
            Profile.Size = new Size(1079, 670);
            Profile.TabIndex = 6;
            Profile.Text = "Profile";
            // 
            // Setting
            // 
            Setting.BackColor = Color.FromArgb(245, 246, 250);
            Setting.ImageIndex = 0;
            Setting.Location = new Point(201, 0);
            Setting.Name = "Setting";
            Setting.Size = new Size(1079, 670);
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
            ClientSize = new Size(1280, 720);
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
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton1;
    }
}