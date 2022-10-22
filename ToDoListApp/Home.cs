using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group9_Project
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }
        private ITaskRepository taskRepository = new TaskRepository();
        private BindingSource source = null;
        public UserObject User { get; set; }

        private void Home_Load(object sender, EventArgs e){
            this.User = new UserObject {
                Username = "admin"
            };
            LoadData();
           
        }
        private void SetDataSource(BindingSource source) {
            taskList.DataSource = null;
            taskList.DataSource = source;
            taskList.Columns[0].Visible = false;
            string status = taskList.SelectedCells[4].Value.ToString();
            if (status == "Complete") {
                btnDone.Text = "To doing";
            }
            else {
                btnDone.Text = "Done";
            }
        }
        private void LoadData() {
            try {
                List<TaskObject> tasks = taskRepository.GetAllTaskOfUser(this.User.Username);
                List<dynamic> data = new List<dynamic>();
                foreach (TaskObject task in tasks) {
                    data.Add(new {
                        TaskId = task.TaskId,
                        Title = task.Title,
                        DueDate = task.DueDate,
                        Importance = task.CategoryId,
                        Status = task.State
                    });
                }
                if (data.Count > 0) {
                    source = null;
                    source = new BindingSource();
                    source.DataSource = data;
                    SetDataSource(source);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Show task", MessageBoxButtons.OK);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e) {
            Create frmCreate = new Create();
            this.Hide();
            frmCreate.ShowDialog();
            this.Show();
            LoadData();

        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnImportant_Click(object sender, EventArgs e) {
            try {
                List<TaskObject> tasks = taskRepository.GetAllTaskOfUser(this.User.Username);
                List<dynamic> data = new List<dynamic>();
                foreach (TaskObject task in tasks) {
                    if (task.CategoryId == 1) {
                        data.Add(new {
                            TaskId = task.TaskId,
                            Title = task.Title,
                            DueDate = task.DueDate,
                            Importance = task.CategoryId,
                            Status = task.State
                        });
                    }
                }
                if (data.Count > 0) {
                    source = null;
                    source = new BindingSource();
                    source.DataSource = data;
                    SetDataSource(source);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Show important task", MessageBoxButtons.OK);
            }
        }

        private void btnView_Click(object sender, EventArgs e) {
            try {
                //taskList.SelectedCells[0].Value.ToString();
                Detail frmDetail = new Detail();
                this.Hide();
                frmDetail.ShowDialog();
                this.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "View task in detail", MessageBoxButtons.OK);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            Application.Restart();
        }

        private void taskList_CellClick(object sender, DataGridViewCellEventArgs e) {
            string status = taskList.SelectedCells[4].Value.ToString();
            if (status == "Complete") {
                btnDone.Text = "To doing";
            }
            else {
                btnDone.Text = "Done";
            }
        }

        private void btnDone_Click(object sender, EventArgs e) {
            try {
                int id = int.Parse(taskList.SelectedCells[0].Value.ToString());
                if (btnDone.Text.Equals("To doing")) {
                    taskRepository.UpdateTaskState(id, "Incomplete");
                }else {
                    taskRepository.UpdateTaskState(id, "Complete");
                }
                LoadData();
                for (int i = 0; i < taskList.Rows.Count; i++) {
                    if (int.Parse(taskList.Rows[i].Cells[0].Value.ToString()) == id) {
                        taskList.Rows[i].Selected = true;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Chang task status", MessageBoxButtons.OK);
            }
        }
    }
}
