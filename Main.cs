using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MIni_Digital_Wallet_system_Final
{
    public partial class Main : Form
    {
        string MyServer = "JUNE-IT\\sQL_2025_C002";
        string MyDb = "Project";
        string MyUserID = "sa";
        string MyPwd = "1206";

        SqlConnection MyConn = new();       //establis connect

        public Main()
        {
            InitializeComponent();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Always allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
                return;

            // Allow exactly one decimal point
            if (e.KeyChar == '.' && !txtAmount.Text.Contains("."))
                return;

            // Block everything else (letters, symbols, second decimal point)
            e.Handled = true;
        }

        private void btnSendMoney_Click(object sender, EventArgs e)
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
                MyConn.Open();      //Start connect to sqlserver
                try
                {
                    MessageBox.Show("ការតភ្ជាប់ទៅកាន់ Database បានជោគជ័យ!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MyConn.Close();
                }

                catch (SqlException ex)
                {
                    // បង្ហាញសារព្រមានច្បាស់លាស់ ប្រសិនបើការតភ្ជាប់មានបញ្ហា (ដូចជាខុសឈ្មោះម៉ាស៊ីន ឬ SQL មិនទាន់ Start)
                    MessageBox.Show("មិនអាចភ្ជាប់ទៅកាន់ Database បានទេ! មូលហេតុ៖\n" + ex.Message,
                                    "កំហុសតភ្ជាប់ (Error 26/Else)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabDashboard_Click(object sender, EventArgs e)
        {

            dgvTransactions.Rows.Add("Alice", "-$50", "03,Jun,2026");
            dgvTransactions.Rows.Add("Bob", "+$100", "04,Jun,2026");
            dgvTransactions.Rows.Add("John", "-$25", "05,Jun,2026");
        }

        //
        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((Sunny.UI.UITextBox)sender).RectColor =
                Color.FromArgb(96, 43, 217);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            ((Sunny.UI.UITextBox)sender).RectColor =
                Color.LightGray;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtRecipientId.Enter += TextBox_Enter;
            txtRecipientId.Leave += TextBox_Leave;

            txtAmount.Enter += TextBox_Enter;
            txtAmount.Leave += TextBox_Leave;

            txtAddNote.Enter += TextBox_Enter;
            txtAddNote.Leave += TextBox_Leave;
        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            // Create and configure the file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Show the dialog and check if user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                // Optional: make the image fit nicely
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}

