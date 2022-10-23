using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoWinApp
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            string imageLocation;
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;...";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    imageLocation = openFileDialog.FileName;
                    pBImage.ImageLocation = imageLocation;
                    btnAddImg.Text = "Change";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load the image!");
            }
        }

        private void dateTimeBirthDay_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeBirthDay.Value > DateTime.Now)
            {
                MessageBox.Show("Not a valid date!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();
            if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Username cannot be empty!", "Error", MessageBoxButtons.OK);
                this.ActiveControl = txtUsername;
            }
            else if (userRepository.GetUser(txtUsername.Text) != null)
            {
                MessageBox.Show("Username has been used!", "Notice", MessageBoxButtons.OK);
                this.ActiveControl = txtUsername;
            }
            else if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK);
                this.ActiveControl = txtPassword;
            }
            else if (txtConfirm.Text != txtPassword.Text)
            {
                MessageBox.Show("Password Confirm must match!", "Error", MessageBoxButtons.OK);
                this.ActiveControl = txtConfirm;
            }
            else if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Name cannot be empty!", "Error", MessageBoxButtons.OK);
                this.ActiveControl = txtName;
            }
            else if (dateTimeBirthDay.Value > DateTime.Now)
            {
                MessageBox.Show("Not a valid date!", "Error", MessageBoxButtons.OK);
                this.ActiveControl = dateTimeBirthDay;
            }
            else
            {
                UserObject user = new UserObject();
                user.Username = txtUsername.Text;
                user.FullName = txtName.Text;
                user.DateOfBirh = dateTimeBirthDay.Value;
                user.Password = txtPassword.Text;
                user.ImagePath = pBImage.ImageLocation.ToString();
                userRepository.InsertNewUser(user);
                this.Close();
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
            txtConfirm.TabIndex = 2;
            txtName.TabIndex = 3;
            dateTimeBirthDay.TabIndex = 4;
            btnAddImg.TabIndex = 5;
            txtPassword.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
