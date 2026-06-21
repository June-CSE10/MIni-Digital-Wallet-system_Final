namespace MIni_Digital_Wallet_system_Final
{
    partial class UCAddMoney
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
            uiBarChart1 = new Sunny.UI.UIBarChart();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            uiColorPicker1 = new Sunny.UI.UIColorPicker();
            SuspendLayout();
            // 
            // uiBarChart1
            // 
            uiBarChart1.Font = new Font("Microsoft Sans Serif", 12F);
            uiBarChart1.LegendFont = new Font("Microsoft Sans Serif", 9F);
            uiBarChart1.Location = new Point(67, 118);
            uiBarChart1.MinimumSize = new Size(1, 1);
            uiBarChart1.Name = "uiBarChart1";
            uiBarChart1.Size = new Size(600, 450);
            uiBarChart1.SubFont = new Font("Microsoft Sans Serif", 9F);
            uiBarChart1.TabIndex = 0;
            uiBarChart1.Text = "uiBarChart1";
            // 
            // uiAvatar1
            // 
            uiAvatar1.Font = new Font("Microsoft Sans Serif", 12F);
            uiAvatar1.Location = new Point(945, 269);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(90, 90);
            uiAvatar1.TabIndex = 1;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // uiColorPicker1
            // 
            uiColorPicker1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            uiColorPicker1.FillColor = Color.White;
            uiColorPicker1.Font = new Font("Microsoft Sans Serif", 12F);
            uiColorPicker1.Location = new Point(198, 22);
            uiColorPicker1.Margin = new Padding(4, 5, 4, 5);
            uiColorPicker1.MinimumSize = new Size(63, 0);
            uiColorPicker1.Name = "uiColorPicker1";
            uiColorPicker1.Padding = new Padding(0, 0, 30, 2);
            uiColorPicker1.Size = new Size(225, 44);
            uiColorPicker1.SymbolSize = 24;
            uiColorPicker1.TabIndex = 2;
            uiColorPicker1.TextAlignment = ContentAlignment.MiddleLeft;
            uiColorPicker1.Watermark = "";
            // 
            // UCAddMoney
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uiColorPicker1);
            Controls.Add(uiAvatar1);
            Controls.Add(uiBarChart1);
            Name = "UCAddMoney";
            Size = new Size(879, 790);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIBarChart uiBarChart1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIColorPicker uiColorPicker1;
    }
}
