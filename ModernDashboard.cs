using Microsoft.Data.SqlClient;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MIni_Digital_Wallet_system_Final
{
    public partial class ModernDashboard : UIForm
    {
        string MyServer = "JUNE-IT\\sQL_2025_C002";
        string MyDb = "Project";
        string MyUserID = "sa";
        string MyPwd = "1206";

        //establis connect
        SqlConnection MyConn = new();

        public ModernDashboard()
        {
            InitializeComponent();
        }

        private void LoadUserControl(TabPage tab, UserControl uc)
        {
            tab.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            tab.Controls.Add(uc);
        }   //Methona

        private void ModernDashboard_Load(object sender, EventArgs e)
        {
            LoadUserControl(AddMoney, new UCAddMoney());
            LoadUserControl(Dashboard, new UCDashboard());
            LoadUserControl(SendMoney, new UCSendMoney());
            LoadUserControl(AddMoney, new UCAddMoney());
            LoadUserControl(Transactions, new UCTransactions());
            LoadUserControl(Contacts, new UCContacts());
            LoadUserControl(Profile, new UCProfile());
            LoadUserControl(Setting, new UCSetting());
        }   //Methona
    }
}
