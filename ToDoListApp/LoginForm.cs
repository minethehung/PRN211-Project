using BusinessObject;
using DataAccess.Repository;
using ToDoWinApp;

namespace Group9_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration frmRegistration = new Registration();
            frmRegistration.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            IUserRepository userRepository = new UserRepository();
            UserObject user = userRepository.GetUser(username);
            if (user == null || user.Password != password)
            {
                MessageBox.Show("Username or password is incorrect!", "Notice", MessageBoxButtons.OK);

            }
            else
            {
                Home frmHome = new Home { User = user };
                frmHome.Show();
                this.Hide();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
        }
    }
}