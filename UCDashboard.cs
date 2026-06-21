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
    public partial class UCDashboard : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=WalletDB;Integrated Security=True");
        int userId = 1;
        private readonly object uiTabControlMenu1;

        public UCDashboard()
        {
            InitializeComponent();

        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
         
            ModernDashboard frm = (ModernDashboard)this.FindForm();

            frm.Controls["panelMain"].Controls.Clear();
            frm.Controls["panelMain"].Controls.Add(new UCAddMoney());
        }
    }
      }
    
