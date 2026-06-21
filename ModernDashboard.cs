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
<<<<<<< HEAD

        private void ucProfile1_Load(object sender, EventArgs e)
        {

        }

        private void uiTabControlMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucDashboard1_Load(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 829151ecd882bf81b99ff3cc641381f5f0e68a7d
    }
}
