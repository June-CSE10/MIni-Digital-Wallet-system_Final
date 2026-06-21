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
    public partial class UCSendMoney : UserControl
    {
        string MyServer = "JUNE-IT\\sQL_2025_C002";
        string MyDb = "Project";
        string MyUserID = "sa";
        string MyPwd = "1206";

        //establis connect
        SqlConnection MyConn = new();

        public UCSendMoney()
        {
            InitializeComponent();

        }

        private void BtnSendMoney_Click(object sender, EventArgs e)
        {
            //Input
            string StrMyConn_SqlAuth =
            $"Server={MyServer}; " +
            $"Database={MyDb}; " +
            $"User id={MyUserID}; Password={MyPwd}; " +
            "Encrypt=True; " +
            "TrustServerCertificate=True; ";

            using (MyConn = new SqlConnection(StrMyConn_SqlAuth))
            {
                try
                {
                    MyConn.Open();
                    MessageBox.Show("Successfully connected to the database!", "Connection Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Connection Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void PnlCardSendMoney_Click(object sender, EventArgs e)
        {

        }
        private void AmountButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                // យកអក្សរពី Button ដកសញ្ញា $ រួចបង្ហាញក្នុង Textbox ទឹកប្រាក់
                TxtAmount.Text = clickedButton.Text.Replace("$", "").Trim();
            }
        }
    }
}
