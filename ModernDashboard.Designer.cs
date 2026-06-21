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
            ucDashboard1 = new UCDashboard();
            SendMoney = new TabPage();
            ucSendMoney1 = new UCSendMoney();
            AddMoney = new TabPage();
            ucAddMoney1 = new UCAddMoney();
            Transactions = new TabPage();
            ucTransactions1 = new UCTransactions();
            Contacts = new TabPage();
            ucContacts1 = new UCContacts();
            Profile = new TabPage();
            ucProfile1 = new UCProfile();
            Setting = new TabPage();
            ucSetting1 = new UCSetting();
            imageList1 = new ImageList(components);
            uiTabControlMenu1.SuspendLayout();
            Dashboard.SuspendLayout();
            SendMoney.SuspendLayout();
            AddMoney.SuspendLayout();
            Transactions.SuspendLayout();
            Contacts.SuspendLayout();
            Profile.SuspendLayout();
            Setting.SuspendLayout();
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
            uiTabControlMenu1.Size = new Size(1080, 790);
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
            Dashboard.Controls.Add(ucDashboard1);
            Dashboard.ImageIndex = 4;
            Dashboard.Location = new Point(201, 0);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(879, 790);
            Dashboard.TabIndex = 2;
            Dashboard.Text = "Dashboard";
            // 
            // ucDashboard1
            // 
            ucDashboard1.Dock = DockStyle.Fill;
            ucDashboard1.Location = new Point(0, 0);
            ucDashboard1.Name = "ucDashboard1";
            ucDashboard1.Size = new Size(879, 790);
            ucDashboard1.TabIndex = 0;
            // 
            // SendMoney
            // 
            SendMoney.BackColor = Color.FromArgb(245, 246, 250);
            SendMoney.Controls.Add(ucSendMoney1);
            SendMoney.ImageIndex = 5;
            SendMoney.Location = new Point(201, 0);
            SendMoney.Name = "SendMoney";
            SendMoney.Size = new Size(879, 790);
            SendMoney.TabIndex = 1;
            SendMoney.Text = "Send Money";
            // 
            // ucSendMoney1
            // 
            ucSendMoney1.Dock = DockStyle.Fill;
            ucSendMoney1.Location = new Point(0, 0);
            ucSendMoney1.Name = "ucSendMoney1";
            ucSendMoney1.Size = new Size(879, 790);
            ucSendMoney1.TabIndex = 0;
            // 
            // AddMoney
            // 
            AddMoney.BackColor = Color.FromArgb(245, 246, 250);
            AddMoney.Controls.Add(ucAddMoney1);
            AddMoney.ImageIndex = 2;
            AddMoney.Location = new Point(201, 0);
            AddMoney.Name = "AddMoney";
            AddMoney.Size = new Size(879, 790);
            AddMoney.TabIndex = 3;
            AddMoney.Text = "Add Money";
            // 
            // ucAddMoney1
            // 
            ucAddMoney1.Dock = DockStyle.Fill;
            ucAddMoney1.Location = new Point(0, 0);
            ucAddMoney1.Name = "ucAddMoney1";
            ucAddMoney1.Size = new Size(879, 790);
            ucAddMoney1.TabIndex = 0;
            // 
            // Transactions
            // 
            Transactions.BackColor = Color.FromArgb(245, 246, 250);
            Transactions.Controls.Add(ucTransactions1);
            Transactions.ImageIndex = 6;
            Transactions.Location = new Point(201, 0);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(249, 270);
            Transactions.TabIndex = 4;
            Transactions.Text = "Transactions";
            // 
            // ucTransactions1
            // 
            ucTransactions1.Dock = DockStyle.Fill;
            ucTransactions1.Location = new Point(0, 0);
            ucTransactions1.Name = "ucTransactions1";
            ucTransactions1.Size = new Size(249, 270);
            ucTransactions1.TabIndex = 0;
            // 
            // Contacts
            // 
            Contacts.BackColor = Color.FromArgb(245, 246, 250);
            Contacts.Controls.Add(ucContacts1);
            Contacts.ImageIndex = 3;
            Contacts.Location = new Point(201, 0);
            Contacts.Name = "Contacts";
            Contacts.Size = new Size(249, 270);
            Contacts.TabIndex = 5;
            Contacts.Text = "Contacts";
            // 
            // ucContacts1
            // 
            ucContacts1.Dock = DockStyle.Fill;
            ucContacts1.Location = new Point(0, 0);
            ucContacts1.Name = "ucContacts1";
            ucContacts1.Size = new Size(249, 270);
            ucContacts1.TabIndex = 0;
            // 
            // Profile
            // 
            Profile.BackColor = Color.FromArgb(245, 246, 250);
            Profile.Controls.Add(ucProfile1);
            Profile.ImageIndex = 2;
            Profile.Location = new Point(201, 0);
            Profile.Name = "Profile";
            Profile.Size = new Size(249, 270);
            Profile.TabIndex = 6;
            Profile.Text = "Profile";
            // 
            // ucProfile1
            // 
            ucProfile1.Dock = DockStyle.Fill;
            ucProfile1.Location = new Point(0, 0);
            ucProfile1.Margin = new Padding(2);
            ucProfile1.Name = "ucProfile1";
            ucProfile1.Size = new Size(249, 270);
            ucProfile1.TabIndex = 0;
            // 
            // Setting
            // 
            Setting.BackColor = Color.FromArgb(245, 246, 250);
            Setting.Controls.Add(ucSetting1);
            Setting.ImageIndex = 0;
            Setting.Location = new Point(401, 0);
            Setting.Name = "Setting";
            Setting.Size = new Size(49, 270);
            Setting.TabIndex = 7;
            Setting.Text = "Setting";
            // 
            // ucSetting1
            // 
            ucSetting1.Dock = DockStyle.Fill;
            ucSetting1.Location = new Point(0, 0);
            ucSetting1.Margin = new Padding(2);
            ucSetting1.Name = "ucSetting1";
            ucSetting1.Size = new Size(49, 270);
            ucSetting1.TabIndex = 0;
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
            ClientSize = new Size(1080, 840);
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
            Dashboard.ResumeLayout(false);
            SendMoney.ResumeLayout(false);
            AddMoney.ResumeLayout(false);
            Transactions.ResumeLayout(false);
            Contacts.ResumeLayout(false);
            Profile.ResumeLayout(false);
            Setting.ResumeLayout(false);
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
        private UCAddMoney ucAddMoney1;
        private UCProfile ucProfile1;
        private UCSetting ucSetting1;
        private UCDashboard ucDashboard1;
        private UCTransactions ucTransactions1;
        private UCContacts ucContacts1;
        private UCSendMoney ucSendMoney1;
    }
}