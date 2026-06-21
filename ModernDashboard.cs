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

        private void Btn10_Click(object sender, EventArgs e)
        {
            TxtAmount.Text = "10";
        }

        private void Btn20_Click_1(object sender, EventArgs e)
        {
            TxtAmount.Text = "20";
        }

        private void Btn30_Click(object sender, EventArgs e)
        {
            TxtAmount.Text = "30";
        }

        private void Btn50_Click(object sender, EventArgs e)
        {
            TxtAmount.Text = "50";
        }

        private void Btn100_Click(object sender, EventArgs e)
        {
            TxtAmount.Text = "100";
        }

        private void BtnSendMoney_Click_1(object sender, EventArgs e)
        {
            decimal amount =
    Convert.ToDecimal(TxtAmount.Text);

            SqlTransaction trans =
            MyConn.BeginTransaction();

            try
            {
                // deduct sender

                // add receiver

                // insert transaction

                trans.Commit();

                MessageBox.Show("Transfer Successful");
            }
            catch
            {
                trans.Rollback();
            }
        }   //Methona

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

        private void ucProfile1_Load(object sender, EventArgs e)
        {

        }

        private void uiTabControlMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucDashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
