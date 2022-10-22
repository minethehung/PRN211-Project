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
                openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    imageLocation = openFileDialog.FileName;
                    pBImage.ImageLocation = imageLocation;
                }
                btnAddImg.Text = "Change";
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
            }
        }
    }
}
