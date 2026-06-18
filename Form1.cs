namespace MIni_Digital_Wallet_system_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtEmail.Text == "" &&
                 txtPassword.Text == "")
            {
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Invalid Email or Password!");
            }
        }

        private void linkForgot_Click(object sender, EventArgs e)
        {
            {

                MessageBox.Show("Forgot Password Clicked");

            }

        }

        private void linkRegister_Click(object sender, EventArgs e)
        {
            { 

                MessageBox.Show("Register Clicked"); 

            }

        }
    }
}
