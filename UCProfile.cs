using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MIni_Digital_Wallet_system_Final
{
    public partial class UCProfile : UserControl
    {
        public UCProfile()
        {
            InitializeComponent();
        }

        private void UCProfile_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

            // Create a new instance of UCSetting
            UCSetting ucSetting = new UCSetting();

            // Clear the current controls in the parent panel/form
            this.Parent.Controls.Clear();

            // Add UCSetting to the parent container
            ucSetting.Dock = DockStyle.Fill; // make it fill the area
            this.Parent.Controls.Add(ucSetting);
        }
        
    }
}

