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

