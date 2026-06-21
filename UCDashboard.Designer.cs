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
            btnAddMoney = new Sunny.UI.UIButton();
            btnSendMoney = new Sunny.UI.UIButton();
            LblWalletBalance = new Label();
            SuspendLayout();
            // 
            // LblBalance
            // 
            LblBalance.AutoSize = true;
            LblBalance.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblBalance.Location = new Point(753, 148);
            LblBalance.Name = "LblBalance";
            LblBalance.Size = new Size(110, 89);
            LblBalance.TabIndex = 0;
            LblBalance.Text = "$0";
            // 
            // btnAddMoney
            // 
            btnAddMoney.Font = new Font("Microsoft Sans Serif", 12F);
            btnAddMoney.Location = new Point(374, 268);
            btnAddMoney.MinimumSize = new Size(1, 1);
            btnAddMoney.Name = "btnAddMoney";
            btnAddMoney.Size = new Size(246, 149);
            btnAddMoney.TabIndex = 1;
            btnAddMoney.Text = "Add Money";
            btnAddMoney.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAddMoney.Click += btnAdd_Click;
            // 
            // btnSendMoney
            // 
            btnSendMoney.Font = new Font("Microsoft Sans Serif", 12F);
            btnSendMoney.Location = new Point(374, 483);
            btnSendMoney.MinimumSize = new Size(1, 1);
            btnSendMoney.Name = "btnSendMoney";
            btnSendMoney.Size = new Size(246, 149);
            btnSendMoney.TabIndex = 2;
            btnSendMoney.Text = "Send Money";
            btnSendMoney.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // LblWalletBalance
            // 
            LblWalletBalance.AutoSize = true;
            LblWalletBalance.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblWalletBalance.Location = new Point(374, 165);
            LblWalletBalance.Name = "LblWalletBalance";
            LblWalletBalance.Size = new Size(386, 72);
            LblWalletBalance.TabIndex = 3;
            LblWalletBalance.Text = "Wallet Balance:";
            // 
            // UCDashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LblWalletBalance);
            Controls.Add(btnSendMoney);
            Controls.Add(btnAddMoney);
            Controls.Add(LblBalance);
            Margin = new Padding(5);
            Name = "UCDashboard";
            Size = new Size(2939, 1481);
            Load += UCDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblBalance;
        private Sunny.UI.UIButton btnAddMoney;
        private Sunny.UI.UIButton btnSendMoney;
        private Label LblWalletBalance;
    }
}
