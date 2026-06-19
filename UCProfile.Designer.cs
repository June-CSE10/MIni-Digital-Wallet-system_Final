namespace MIni_Digital_Wallet_system_Final
{
    partial class UCProfile
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
            uiAvatar1 = new Sunny.UI.UIAvatar();
            uiBreadcrumb1 = new Sunny.UI.UIBreadcrumb();
            SuspendLayout();
            // 
            // uiAvatar1
            // 
            uiAvatar1.Font = new Font("Microsoft Sans Serif", 12F);
            uiAvatar1.Location = new Point(190, 101);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(90, 90);
            uiAvatar1.TabIndex = 0;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // uiBreadcrumb1
            // 
            uiBreadcrumb1.Font = new Font("Microsoft Sans Serif", 12F);
            uiBreadcrumb1.ItemWidth = 227;
            uiBreadcrumb1.Location = new Point(190, 210);
            uiBreadcrumb1.MinimumSize = new Size(1, 1);
            uiBreadcrumb1.Name = "uiBreadcrumb1";
            uiBreadcrumb1.Size = new Size(150, 44);
            uiBreadcrumb1.TabIndex = 1;
            uiBreadcrumb1.Text = "uiBreadcrumb1";
            uiBreadcrumb1.UnSelectedColor = Color.FromArgb(155, 200, 255);
            // 
            // UCProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uiBreadcrumb1);
            Controls.Add(uiAvatar1);
            Name = "UCProfile";
            Size = new Size(659, 758);
            Load += UCProfile_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIBreadcrumb uiBreadcrumb1;
    }
}
