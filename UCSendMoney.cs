using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;
using Sunny.UI;

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
        private void AmountButton_Click(object sender, EventArgs e)
        {
            TxtAmount.Text = ((UIButton)sender).Text;
        }//Methona

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
                    MyConn.Open();      //Start connect to sqlserver
                    MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"General System Error: {ex.Message}",
                                    "System Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }//Methona
    }
}
