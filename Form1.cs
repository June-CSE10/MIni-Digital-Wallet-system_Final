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
            this.Text = "Login - Mini Digital Wallet";
            this.Size = new Size(400, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            Label lblTitle = new Label();
            lblTitle.Text = "Welcome Back!";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.Location = new Point(105, 160);
            lblTitle.AutoSize = true;

            Label lblSub = new Label();
            lblSub.Text = "Login to access your wallet";
            lblSub.Location = new Point(110, 195);
            lblSub.AutoSize = true;

            Label lblEmail = new Label();
            lblEmail.Text = "Email";
            lblEmail.Location = new Point(50, 240);

            TextBox txtEmail = new TextBox();
            txtEmail.Name = "txtEmail";
            txtEmail.Location = new Point(50, 260);
            txtEmail.Size = new Size(280, 30);

            Label lblPassword = new Label();
            lblPassword.Text = "Password";
            lblPassword.Location = new Point(50, 305);

            TextBox txtPassword = new TextBox();
            txtPassword.Name = "txtPassword";
            txtPassword.Location = new Point(50, 325);
            txtPassword.Size = new Size(280, 30);
            txtPassword.PasswordChar = '*';

            CheckBox chkRemember = new CheckBox();
            chkRemember.Text = "Remember Me";
            chkRemember.Location = new Point(50, 370);

            LinkLabel linkForgot = new LinkLabel();
            linkForgot.Text = "Forgot Password?";
            linkForgot.Location = new Point(220, 370);

            Button btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Size = new Size(280, 40);
            btnLogin.Location = new Point(50, 420);
            btnLogin.BackColor = Color.MediumSlateBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;

            LinkLabel linkRegister = new LinkLabel();
            linkRegister.Text = "Don't have an account? Register";
            linkRegister.Location = new Point(90, 480);
            linkRegister.AutoSize = true;

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblSub);
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(chkRemember);
            this.Controls.Add(linkForgot);
            this.Controls.Add(btnLogin);
            this.Controls.Add(linkRegister);
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
    }
}
