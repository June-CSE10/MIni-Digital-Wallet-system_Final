using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace MIni_Digital_Wallet_system_Final
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
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
            {

                try

                {

                    con.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE Email=@Email AND Password=@Password";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)

                    {

                        MessageBox.Show("Login Successful!",

                                        "Success",

                                        MessageBoxButtons.OK,

                                        MessageBoxIcon.Information);

                        Dashboard frm = new Dashboard();

                        frm.Show();

                        this.Hide();

                    }

                    else

                    {

                        MessageBox.Show("Invalid Email or Password!",

                                        "Login Failed",

                                        MessageBoxButtons.OK,

                                        MessageBoxIcon.Error);

                    }

                    con.Close();

                }

                catch (Exception ex)

                {

                    MessageBox.Show(ex.Message);

                }
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

                Register frm = new Register();
                frm.Show();

                this.Hide();
            }

        }

        private void lblDHAA_Click(object sender, EventArgs e)
        {

        }

        private void btnCNA_Click(object sender, EventArgs e)
        {

            Register frm = new Register();
            frm.Show();

            this.Hide();
        }
    }
}
