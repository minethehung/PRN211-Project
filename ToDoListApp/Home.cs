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

        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
