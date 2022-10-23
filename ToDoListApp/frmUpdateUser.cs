using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class frmUpdateUser : Form
    {
        public UserObject loggedInUser { get; set; }
        public frmUpdateUser(UserObject user)
        {
            loggedInUser = user;
            InitializeComponent();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            txtName.Text = loggedInUser.FullName;
            dateTimeBirthDay.Value = loggedInUser.DateOfBirh;
            pBImage.ImageLocation = loggedInUser.ImagePath;
            if (pBImage.ImageLocation.Length > 0)
            {
                btnAddImg.Text = "Change";
            }
            gBPassword.Visible = false;
            txtOldPassword.PasswordChar = '*';
            txtPassword.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            gBPassword.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();

            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Name cannot be empty!", "Error", MessageBoxButtons.OK);
                this.ActiveControl = txtName;
            }
            else if (dateTimeBirthDay.Value > DateTime.Now)
            {
                MessageBox.Show("Not a valid date!", "Error", MessageBoxButtons.OK);
                this.ActiveControl = dateTimeBirthDay;
            }
            else if (gBPassword.Visible == true)
            {
                if (txtOldPassword.Text != loggedInUser.Password)
                {
                    MessageBox.Show("Old Password is incorrect!", "Error", MessageBoxButtons.OK);
                    this.ActiveControl = txtOldPassword;
                }
                else if (txtPassword.Text.Length == 0)
                {
                    MessageBox.Show("New Password cannot be empty!", "Error", MessageBoxButtons.OK);
                    this.ActiveControl = txtPassword;
                }
                else if (txtConfirm.Text != txtPassword.Text)
                {
                    MessageBox.Show("Password Confirm must match!", "Error", MessageBoxButtons.OK);
                    this.ActiveControl = txtConfirm;
                }
                else
                {
                    try
                    {
                        UserObject user = new UserObject();
                        user.Username = loggedInUser.Username;
                        user.FullName = txtName.Text;
                        user.DateOfBirh = dateTimeBirthDay.Value;
                        user.Password = txtPassword.Text.ToString();
                        user.ImagePath = pBImage.ImageLocation.ToString();
                        userRepository.UpdateUser(user);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message + "Update User");
                    }

                }
            }
            else
            {
                try
                {
                    UserObject user = new UserObject();
                    user.Username = loggedInUser.Username;
                    user.FullName = txtName.Text;
                    user.DateOfBirh = dateTimeBirthDay.Value;
                    if (gBPassword.Visible == false)
                    {
                        user.Password = loggedInUser.Password;

                    }
                    user.ImagePath = pBImage.ImageLocation.ToString();
                    userRepository.UpdateUser(user);
                    this.Close();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message + "Update User");
                }
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
