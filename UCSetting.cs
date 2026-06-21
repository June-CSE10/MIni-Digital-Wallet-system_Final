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
    public partial class UCSetting : UserControl
    {
        public UCSetting()
        {
            InitializeComponent();
        }
        string MyServer = "Song\\sqlexpress";
        string MyDb = "Project";
        string MyUserID = "sa";
        string MyPwd = "1206";

        SqlConnection MyConn = new();       //establis connect
        SqlCommand cmd;                     //establis command (Parameter/ExecuteNonQuery)
        string sql;                         //establis query string


        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
