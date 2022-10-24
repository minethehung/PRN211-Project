using BusinessObject;
using DataAccess.Repository;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListApp;

namespace Group9_Project
{
    public partial class Create : Form
    {
        public UserObject LoginUser { get; set; }
        private ICategoryRepository categoryRepository = new CategoryRepository();
        private ITaskRepository taskRepository = new TaskRepository();
        private ITaskGroupRepository taskGroupRepository = new TaskGroupRepository();
        public Create()
        {
            InitializeComponent();
        }
        private void ErrorMessage(string msg)
        {
            MessageBox.Show(
                    msg,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void cboCategory_LoadDataSource()
        {
            IEnumerable<CategoryObject> categories;
            try
            {
                categories = categoryRepository.GetCategoryList();
                if (categories == null)
                {
                    categories = new List<CategoryObject>();
                }
                BindingSource categorySource = new BindingSource();
                categorySource.DataSource = categories;

                cboCategory.DataSource = null;
                cboCategory.DataSource = categorySource;
                cboCategory.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Categories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboTaskGroup_LoadDataSource(bool addNew = false)
        {
            IEnumerable<TaskGroupObject> taskGroups = null;
            try
            {
                taskGroups = taskGroupRepository.GetTaskGroupListByUser(LoginUser.Username);
                if (taskGroups == null)
                {
                    taskGroups = new List<TaskGroupObject>();
                }
                taskGroups = taskGroups.Append(new TaskGroupObject
                {
                    Name = "Add new group"
                });
                BindingSource taskGroupSource = new BindingSource();
                taskGroupSource.DataSource = taskGroups;

                cboGroup.DataSource = null;
                cboGroup.DataSource = taskGroupSource;
                cboGroup.DisplayMember = "Name";
                if (addNew)
                {
                    taskGroupSource.Position = taskGroupSource.Count - 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Groups", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboRepeatType_LoadDataSource()
        {
            List<string> repeatTypes = new List<string>()
            {
                "days", "weeks"
            };
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = repeatTypes;

            cboRepeatType.DataSource = bindingSource;
            txtRepeatCount.Text = "1";
        }
        private void SetWeekDaysVisible(bool visible)
        {
            ckbMo.Visible = visible;
            ckbTu.Visible = visible;
            ckbWe.Visible = visible;
            ckbTh.Visible = visible;
            ckbFr.Visible = visible;
            ckbSa.Visible = visible;
            ckbSu.Visible = visible;
        }
        private void Create_Load(object sender, EventArgs e)
        {
            try
            {
                cboCategory_LoadDataSource();
                cboTaskGroup_LoadDataSource();
                cboRepeatType_LoadDataSource();
                SetWeekDaysVisible(false);
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string CheckEmptyString(string s)
        {
            if (s == null || s.Trim().Equals(""))
            {
                throw new Exception("Input field cannot be empty!");
            }
            return s.Trim();
        }
        private DateTime ConverToDateTime(string date, string time)
        {
            DateTime result;
            DateTime.TryParseExact($"{date} {time}",
                    new string[] { "dd MMMM yyyy HH:mm:ss" },
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out result);
            return result;
        }
        private string GetRepeatString()
        {
            string repeatCount = CheckEmptyString(txtRepeatCount.Text);
            string repeatType = CheckEmptyString(cboRepeatType.Text);
            string result = repeatCount + " " + repeatType;
            if (!repeatType.Equals("weeks"))
            {
                return result;
            }
            result += "/";
            if (ckbMo.Checked)
            {
                result += "Mo, ";
            }
            if (ckbTu.Checked)
            {
                result += "Tu, ";
            }
            if (ckbWe.Checked)
            {
                result += "We, ";
            }
            if (ckbTh.Checked)
            {
                result += "Th, ";
            }
            if (ckbFr.Checked)
            {
                result += "Fr, ";
            }
            if (ckbSa.Checked)
            {
                result += "Sa, ";
            }
            if (ckbSu.Checked)
            {
                result += "Su, ";
            }

            return result.Substring(0, result.Length - 2);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string title = CheckEmptyString(txtTitle.Text);
                string description = CheckEmptyString(txtDescription.Text);
                int categoryId = categoryRepository.GetCategoryByName(CheckEmptyString(cboCategory.Text)).Id;
                int groupId = taskGroupRepository.GetTaskGroupId(LoginUser.Username, CheckEmptyString(cboGroup.Text));
                DateTime startDate = DateTime.Now;
                string state = "Incomplete";
                string repeat = GetRepeatString();
                //DateTime dueDate = ConverToDateTime(dateDueDate.Text, timeDueDate.Text);
                //DateTime remind = ConverToDateTime(dateRemind.Text, timeRemind.Text);
                DateTime dueDate = dateDueDate.Value.Date + timeDueDate.Value.TimeOfDay;
                DateTime remind = dateRemind.Value.Date.Add(timeRemind.Value.TimeOfDay);
                string username = LoginUser.Username;

                TaskObject task = new TaskObject()
                {
                    Title = title,
                    Description = description,
                    CategoryId = categoryId,
                    GroupId = groupId,
                    Username = username,
                    DueDate = dueDate,
                    Remind = remind,
                    Repeat = repeat,
                    StartDate = startDate,
                    State = state
                };
                taskRepository.InsertTask(task);
                MessageBox.Show(
                    "Created task successfully!",
                    "Create task",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }

        private void cboRepeatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRepeatType.Text.Equals("weeks"))
            {

                SetWeekDaysVisible(true);
            }
            else
            {
                SetWeekDaysVisible(false);
            }
        }

        private void ckbSu_CheckedChanged(object sender, EventArgs e)
        {
            ckbSu.BackColor = ckbSu.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;
        }

        private void ckbMo_CheckedChanged(object sender, EventArgs e)
        {
            ckbMo.BackColor = ckbMo.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;
        }

        private void ckbTu_CheckedChanged(object sender, EventArgs e)
        {
            ckbTu.BackColor = ckbTu.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;
        }

        private void ckbWe_CheckedChanged(object sender, EventArgs e)
        {
            ckbWe.BackColor = ckbWe.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;
        }

        private void ckbTh_CheckedChanged(object sender, EventArgs e)
        {
            ckbTh.BackColor = ckbTh.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;
        }

        private void ckbFr_CheckedChanged(object sender, EventArgs e)
        {
            ckbFr.BackColor = ckbFr.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;
        }

        private void ckbSa_CheckedChanged(object sender, EventArgs e)
        {
            ckbSa.BackColor = ckbSa.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGroup = cboGroup.Text;
            if (selectedGroup.Equals("Add new group"))
            {
                frmAddGroup frmAddGroup = new frmAddGroup()
                {
                    LoginUser = this.LoginUser,
                    TaskGroupRepository = this.taskGroupRepository
                };
                if (frmAddGroup.ShowDialog() == DialogResult.OK)
                {
                    cboTaskGroup_LoadDataSource(true);
                }
            }
        }
    }
}
