namespace MIni_Digital_Wallet_system_Final
{
    partial class UCDashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblBalance = new Label();
            btnAdd = new Sunny.UI.UIButton();
            btnSend = new Sunny.UI.UIButton();
            dgvTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // LblBalance
            // 
            LblBalance.AutoSize = true;
            LblBalance.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblBalance.Location = new Point(1032, 191);
            LblBalance.Name = "LblBalance";
            LblBalance.Size = new Size(110, 89);
            LblBalance.TabIndex = 0;
            LblBalance.Text = "$0";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdd.Location = new Point(1032, 388);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(246, 149);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Money";
            btnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Microsoft Sans Serif", 12F);
            btnSend.Location = new Point(1670, 388);
            btnSend.MinimumSize = new Size(1, 1);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(246, 149);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send Money";
            btnSend.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // dgvTransactions
            // 
            dgvTransactions.BackgroundColor = SystemColors.ActiveCaption;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(1032, 572);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 102;
            dgvTransactions.Size = new Size(884, 311);
            dgvTransactions.TabIndex = 3;
            // 
            // UCDashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvTransactions);
            Controls.Add(btnSend);
            Controls.Add(btnAdd);
            Controls.Add(LblBalance);
            Margin = new Padding(5);
            Name = "UCDashboard";
            Size = new Size(2939, 1481);
            Load += UCDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblBalance;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnSend;
        private DataGridView dgvTransactions;
    }
}
