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
    public partial class frmAddGroup : Form
    {
        public ITaskGroupRepository TaskGroupRepository { get; set; }
        public UserObject LoginUser { get; set; }
        public frmAddGroup()
        {
            InitializeComponent();
        }
        private void ShowError(string msg)
        {
            MessageBox.Show(
                    msg,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private string CheckEmptyString(string s)
        {
            if (s == null || s.Trim().Equals(""))
            {
                throw new Exception("Input field cannot be empty!");
            }
            return s.Trim();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = CheckEmptyString(txtGroupName.Text);
                string description = CheckEmptyString(txtDescription.Text);
                TaskGroupObject taskGroup = new TaskGroupObject()
                {
                    Name = name,
                    Description = description,
                    Username = LoginUser.Username
                };
                TaskGroupRepository.InsertTaskGroup(taskGroup);
                MessageBox.Show(
                    "Added new group successfully!",
                    "Add new group",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
