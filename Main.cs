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
    public partial class Main : Form
    {
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
            /*
            // 1. Required field check
            string recipId = txtRecipientId.Text.Trim();
            if (string.IsNullOrEmpty(recipId))
            { UIMessageTip.ShowWarning("Enter a recipient ID."); return; }

            // 2. Numeric amount validation
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            { UIMessageTip.ShowError("Enter a valid positive amount."); return; }

            // 3. Self-send guard
            if (recipId == _currentUserCode)
            { UIMessageTip.ShowWarning("You cannot send money to yourself."); return; }

            // 4. Execute DB transaction (atomic debit + credit)
            try
            { DatabaseHelper.SendMoney(_userId, recipId, amount, txtAddNote.Text); }
            catch (Exception ex)
            { UIMessageTip.ShowError(ex.Message); return; }

            // 5. Clear fields, refresh dashboard
            txtRecipientId.Clear(); txtAmount.Clear(); txtAddNote.Clear();
            LoadDashboard();
            UIMessageTip.ShowOk($"${amount:F2} sent successfully!");
            */
        }

        private void tabDashboard_Click(object sender, EventArgs e)
        {

            dgvTransactions.Rows.Add("Alice", "-$50", "03,Jun,2026");
            dgvTransactions.Rows.Add("Bob", "+$100", "04,Jun,2026");
            dgvTransactions.Rows.Add("John", "-$25", "05,Jun,2026");
        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}

