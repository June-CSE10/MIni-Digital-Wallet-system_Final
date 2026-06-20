using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MIni_Digital_Wallet_system_Final
{
    public partial class UCDashboard : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=WalletDB;Integrated Security=True");
        int userId = 1;

        public UCDashboard()
        {
            InitializeComponent();

        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
