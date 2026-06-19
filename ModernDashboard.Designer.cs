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
            PnlCardSendMoney = new Sunny.UI.UIPanel();
            PnlContacts = new Sunny.UI.UIPanel();
            AvatarContact5 = new Sunny.UI.UIAvatar();
            LblContactEmail5 = new Sunny.UI.UILabel();
            AvatarContact4 = new Sunny.UI.UIAvatar();
            LblContactEmail4 = new Sunny.UI.UILabel();
            AvatarContact3 = new Sunny.UI.UIAvatar();
            LblContactEmail3 = new Sunny.UI.UILabel();
            LblContactName5 = new Sunny.UI.UILabel();
            AvatarContact2 = new Sunny.UI.UIAvatar();
            LblContactName4 = new Sunny.UI.UILabel();
            LblContactEmail2 = new Sunny.UI.UILabel();
            LblContactName3 = new Sunny.UI.UILabel();
            AvatarContact1 = new Sunny.UI.UIAvatar();
            LblContactName2 = new Sunny.UI.UILabel();
            LblContactEmail1 = new Sunny.UI.UILabel();
            LblContactName1 = new Sunny.UI.UILabel();
            LblRecentContacts = new Sunny.UI.UILabel();
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
            PnlViewContacts = new Sunny.UI.UIPanel();
            BtnViewContacts = new Sunny.UI.UIButton();
            uiTabControlMenu1.SuspendLayout();
            SendMoney.SuspendLayout();
            PnlCardSendMoney.SuspendLayout();
            PnlContacts.SuspendLayout();
            Contacts.SuspendLayout();
            PnlViewContacts.SuspendLayout();
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
            Dashboard.ImageIndex = 4;
            Dashboard.Location = new Point(201, 0);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(879, 790);
            Dashboard.TabIndex = 2;
            Dashboard.Text = "Dashboard";
            // 
            // SendMoney
            // 
            SendMoney.BackColor = Color.FromArgb(245, 246, 250);
            SendMoney.Controls.Add(PnlCardSendMoney);
            SendMoney.ImageIndex = 5;
            SendMoney.Location = new Point(201, 0);
            SendMoney.Name = "SendMoney";
            SendMoney.Size = new Size(879, 790);
            SendMoney.TabIndex = 1;
            SendMoney.Text = "Send Money";
            // 
            // PnlCardSendMoney
            // 
            PnlCardSendMoney.Controls.Add(PnlViewContacts);
            PnlCardSendMoney.Controls.Add(PnlContacts);
            PnlCardSendMoney.Controls.Add(LblNote);
            PnlCardSendMoney.Controls.Add(LblAmount);
            PnlCardSendMoney.Controls.Add(LblRecipient);
            PnlCardSendMoney.Controls.Add(LblDescription);
            PnlCardSendMoney.Controls.Add(LblLabel);
            PnlCardSendMoney.Controls.Add(Btn100);
            PnlCardSendMoney.Controls.Add(Btn50);
            PnlCardSendMoney.Controls.Add(uiButton1);
            PnlCardSendMoney.Controls.Add(Btn20);
            PnlCardSendMoney.Controls.Add(Btn10);
            PnlCardSendMoney.Controls.Add(TxtNote);
            PnlCardSendMoney.Controls.Add(BtnSendMoney);
            PnlCardSendMoney.Controls.Add(TxtAmount);
            PnlCardSendMoney.Controls.Add(TxtRecipient);
            PnlCardSendMoney.Dock = DockStyle.Fill;
            PnlCardSendMoney.FillColor = Color.White;
            PnlCardSendMoney.Font = new Font("Microsoft Sans Serif", 12F);
            PnlCardSendMoney.Location = new Point(0, 0);
            PnlCardSendMoney.Margin = new Padding(4, 5, 4, 5);
            PnlCardSendMoney.MinimumSize = new Size(1, 1);
            PnlCardSendMoney.Name = "PnlCardSendMoney";
            PnlCardSendMoney.Radius = 15;
            PnlCardSendMoney.RectColor = Color.FromArgb(230, 230, 230);
            PnlCardSendMoney.Size = new Size(879, 790);
            PnlCardSendMoney.TabIndex = 1;
            PnlCardSendMoney.Text = null;
            PnlCardSendMoney.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // PnlContacts
            // 
            PnlContacts.Controls.Add(AvatarContact5);
            PnlContacts.Controls.Add(LblContactEmail5);
            PnlContacts.Controls.Add(AvatarContact4);
            PnlContacts.Controls.Add(LblContactEmail4);
            PnlContacts.Controls.Add(AvatarContact3);
            PnlContacts.Controls.Add(LblContactEmail3);
            PnlContacts.Controls.Add(LblContactName5);
            PnlContacts.Controls.Add(AvatarContact2);
            PnlContacts.Controls.Add(LblContactName4);
            PnlContacts.Controls.Add(LblContactEmail2);
            PnlContacts.Controls.Add(LblContactName3);
            PnlContacts.Controls.Add(AvatarContact1);
            PnlContacts.Controls.Add(LblContactName2);
            PnlContacts.Controls.Add(LblContactEmail1);
            PnlContacts.Controls.Add(LblContactName1);
            PnlContacts.Controls.Add(LblRecentContacts);
            PnlContacts.Font = new Font("Microsoft Sans Serif", 12F);
            PnlContacts.Location = new Point(600, 172);
            PnlContacts.Margin = new Padding(4, 5, 4, 5);
            PnlContacts.MinimumSize = new Size(1, 1);
            PnlContacts.Name = "PnlContacts";
            PnlContacts.Radius = 8;
            PnlContacts.Size = new Size(235, 451);
            PnlContacts.TabIndex = 4;
            PnlContacts.Text = null;
            PnlContacts.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // AvatarContact5
            // 
            AvatarContact5.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvatarContact5.Location = new Point(15, 369);
            AvatarContact5.MinimumSize = new Size(1, 1);
            AvatarContact5.Name = "AvatarContact5";
            AvatarContact5.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            AvatarContact5.Size = new Size(67, 71);
            AvatarContact5.TabIndex = 1;
            AvatarContact5.Text = "uiAvatar1";
            // 
            // LblContactEmail5
            // 
            LblContactEmail5.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContactEmail5.ForeColor = Color.FromArgb(48, 48, 48);
            LblContactEmail5.Location = new Point(95, 413);
            LblContactEmail5.Name = "LblContactEmail5";
            LblContactEmail5.Size = new Size(137, 34);
            LblContactEmail5.TabIndex = 0;
            LblContactEmail5.Text = "ContactEmail";
            // 
            // AvatarContact4
            // 
            AvatarContact4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvatarContact4.Location = new Point(15, 292);
            AvatarContact4.MinimumSize = new Size(1, 1);
            AvatarContact4.Name = "AvatarContact4";
            AvatarContact4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            AvatarContact4.Size = new Size(67, 71);
            AvatarContact4.TabIndex = 1;
            AvatarContact4.Text = "uiAvatar1";
            // 
            // LblContactEmail4
            // 
            LblContactEmail4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContactEmail4.ForeColor = Color.FromArgb(48, 48, 48);
            LblContactEmail4.Location = new Point(95, 336);
            LblContactEmail4.Name = "LblContactEmail4";
            LblContactEmail4.Size = new Size(137, 34);
            LblContactEmail4.TabIndex = 0;
            LblContactEmail4.Text = "ContactEmail";
            // 
            // AvatarContact3
            // 
            AvatarContact3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvatarContact3.Location = new Point(15, 215);
            AvatarContact3.MinimumSize = new Size(1, 1);
            AvatarContact3.Name = "AvatarContact3";
            AvatarContact3.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            AvatarContact3.Size = new Size(67, 71);
            AvatarContact3.TabIndex = 1;
            AvatarContact3.Text = "uiAvatar1";
            // 
            // LblContactEmail3
            // 
            LblContactEmail3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContactEmail3.ForeColor = Color.FromArgb(48, 48, 48);
            LblContactEmail3.Location = new Point(95, 259);
            LblContactEmail3.Name = "LblContactEmail3";
            LblContactEmail3.Size = new Size(137, 34);
            LblContactEmail3.TabIndex = 0;
            LblContactEmail3.Text = "ContactEmail";
            // 
            // LblContactName5
            // 
            LblContactName5.Font = new Font("Microsoft Sans Serif", 10F);
            LblContactName5.ForeColor = Color.FromArgb(48, 48, 48);
            LblContactName5.Location = new Point(88, 379);
            LblContactName5.Name = "LblContactName5";
            LblContactName5.Size = new Size(135, 34);
            LblContactName5.TabIndex = 0;
            LblContactName5.Text = "ContactName";
            LblContactName5.Click += LblContactName_Click;
            // 
            // AvatarContact2
            // 
            AvatarContact2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvatarContact2.Location = new Point(15, 138);
            AvatarContact2.MinimumSize = new Size(1, 1);
            AvatarContact2.Name = "AvatarContact2";
            AvatarContact2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            AvatarContact2.Size = new Size(67, 71);
            AvatarContact2.TabIndex = 1;
            AvatarContact2.Text = "uiAvatar1";
            // 
            // LblContactName4
            // 
            LblContactName4.Font = new Font("Microsoft Sans Serif", 10F);
            LblContactName4.ForeColor = Color.FromArgb(48, 48, 48);
            LblContactName4.Location = new Point(88, 302);
            LblContactName4.Name = "LblContactName4";
            LblContactName4.Size = new Size(135, 34);
            LblContactName4.TabIndex = 0;
            LblContactName4.Text = "ContactName";
            LblContactName4.Click += LblContactName_Click;
            // 
            // LblContactEmail2
            // 
            LblContactEmail2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContactEmail2.ForeColor = Color.FromArgb(48, 48, 48);
            LblContactEmail2.Location = new Point(95, 182);
            LblContactEmail2.Name = "LblContactEmail2";
            LblContactEmail2.Size = new Size(137, 34);
            LblContactEmail2.TabIndex = 0;
            LblContactEmail2.Text = "ContactEmail";
            // 
            // LblContactName3
            // 
            LblContactName3.Font = new Font("Microsoft Sans Serif", 10F);
            LblContactName3.ForeColor = Color.FromArgb(48, 48, 48);
            LblContactName3.Location = new Point(88, 225);
            LblContactName3.Name = "LblContactName3";
            LblContactName3.Size = new Size(135, 34);
            LblContactName3.TabIndex = 0;
            LblContactName3.Text = "ContactName";
            LblContactName3.Click += LblContactName_Click;
            // 
            // AvatarContact1
            // 
            AvatarContact1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvatarContact1.Location = new Point(15, 61);
            AvatarContact1.MinimumSize = new Size(1, 1);
            AvatarContact1.Name = "AvatarContact1";
            AvatarContact1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            AvatarContact1.Size = new Size(67, 71);
            AvatarContact1.TabIndex = 1;
            AvatarContact1.Text = "uiAvatar1";
            // 
            // LblContactName2
            // 
            LblContactName2.Font = new Font("Microsoft Sans Serif", 10F);
            LblContactName2.ForeColor = Color.FromArgb(48, 48, 48);
            LblContactName2.Location = new Point(88, 148);
            LblContactName2.Name = "LblContactName2";
            LblContactName2.Size = new Size(135, 34);
            LblContactName2.TabIndex = 0;
            LblContactName2.Text = "ContactName";
            LblContactName2.Click += LblContactName_Click;
            // 
            // LblContactEmail1
            // 
            LblContactEmail1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContactEmail1.ForeColor = Color.FromArgb(48, 48, 48);
            LblContactEmail1.Location = new Point(95, 105);
            LblContactEmail1.Name = "LblContactEmail1";
            LblContactEmail1.Size = new Size(137, 34);
            LblContactEmail1.TabIndex = 0;
            LblContactEmail1.Text = "ContactEmail";
            // 
            // LblContactName1
            // 
            LblContactName1.Font = new Font("Microsoft Sans Serif", 10F);
            LblContactName1.ForeColor = Color.FromArgb(48, 48, 48);
            LblContactName1.Location = new Point(88, 71);
            LblContactName1.Name = "LblContactName1";
            LblContactName1.Size = new Size(135, 34);
            LblContactName1.TabIndex = 0;
            LblContactName1.Text = "ContactName";
            LblContactName1.Click += LblContactName_Click;
            // 
            // LblRecentContacts
            // 
            LblRecentContacts.Font = new Font("Microsoft Sans Serif", 12F);
            LblRecentContacts.ForeColor = Color.FromArgb(48, 48, 48);
            LblRecentContacts.Location = new Point(15, 24);
            LblRecentContacts.Name = "LblRecentContacts";
            LblRecentContacts.Size = new Size(150, 34);
            LblRecentContacts.TabIndex = 0;
            LblRecentContacts.Text = "RecentContacts";
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
            AddMoney.Size = new Size(879, 790);
            AddMoney.TabIndex = 3;
            AddMoney.Text = "Add Money";
            // 
            // Transactions
            // 
            Transactions.BackColor = Color.FromArgb(245, 246, 250);
            Transactions.ImageIndex = 6;
            Transactions.Location = new Point(201, 0);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(879, 790);
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
            Contacts.Size = new Size(879, 790);
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
            uiPanel1.Size = new Size(879, 790);
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
            Profile.Size = new Size(879, 790);
            Profile.TabIndex = 6;
            Profile.Text = "Profile";
            // 
            // Setting
            // 
            Setting.BackColor = Color.FromArgb(245, 246, 250);
            Setting.ImageIndex = 0;
            Setting.Location = new Point(201, 0);
            Setting.Name = "Setting";
            Setting.Size = new Size(879, 790);
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
            // PnlViewContacts
            // 
            PnlViewContacts.Controls.Add(BtnViewContacts);
            PnlViewContacts.Font = new Font("Microsoft Sans Serif", 12F);
            PnlViewContacts.Location = new Point(600, 633);
            PnlViewContacts.Margin = new Padding(4, 5, 4, 5);
            PnlViewContacts.MinimumSize = new Size(1, 1);
            PnlViewContacts.Name = "PnlViewContacts";
            PnlViewContacts.Radius = 8;
            PnlViewContacts.Size = new Size(235, 89);
            PnlViewContacts.TabIndex = 5;
            PnlViewContacts.Text = null;
            PnlViewContacts.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // BtnViewContacts
            // 
            BtnViewContacts.Font = new Font("Microsoft Sans Serif", 12F);
            BtnViewContacts.Location = new Point(14, 15);
            BtnViewContacts.MinimumSize = new Size(1, 1);
            BtnViewContacts.Name = "BtnViewContacts";
            BtnViewContacts.Radius = 8;
            BtnViewContacts.Size = new Size(208, 58);
            BtnViewContacts.TabIndex = 0;
            BtnViewContacts.Text = "View All Contacts";
            BtnViewContacts.TipsFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            SendMoney.ResumeLayout(false);
            PnlCardSendMoney.ResumeLayout(false);
            PnlContacts.ResumeLayout(false);
            Contacts.ResumeLayout(false);
            PnlViewContacts.ResumeLayout(false);
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
        private Sunny.UI.UIPanel PnlCardSendMoney;
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
        private Sunny.UI.UIPanel PnlContacts;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel LblRecentContacts;
        private Sunny.UI.UIAvatar AvatarContact1;
        private Sunny.UI.UILabel LblContactEmail1;
        private Sunny.UI.UILabel LblContactName1;
        private Sunny.UI.UIAvatar AvatarContact5;
        private Sunny.UI.UILabel LblContactEmail5;
        private Sunny.UI.UIAvatar AvatarContact4;
        private Sunny.UI.UILabel LblContactEmail4;
        private Sunny.UI.UIAvatar AvatarContact3;
        private Sunny.UI.UILabel LblContactEmail3;
        private Sunny.UI.UILabel LblContactName5;
        private Sunny.UI.UIAvatar AvatarContact2;
        private Sunny.UI.UILabel LblContactName4;
        private Sunny.UI.UILabel LblContactEmail2;
        private Sunny.UI.UILabel LblContactName3;
        private Sunny.UI.UILabel LblContactName2;
        private Sunny.UI.UIPanel PnlViewContacts;
        private Sunny.UI.UIButton BtnViewContacts;
    }
}