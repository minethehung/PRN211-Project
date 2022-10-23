using BusinessObject;
using DataAccess.Repository;

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

        private void Home_Load(object sender, EventArgs e)
        {
            labelUsername.Text = User.FullName;
            if (User.ImagePath != null)
            {
                pictureBox1.ImageLocation = User.ImagePath;
            }
            
            LoadData();
         
        }

      

        private void SetDataSource(BindingSource source)
        {
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
        private void LoadData()
        {
            try
            {
                List<TaskObject> tasks = taskRepository.GetAllTaskOfUser(this.User.Username);
                List<dynamic> data = new List<dynamic>();
                foreach (TaskObject task in tasks)
                {
                    data.Add(new
                    {
                        TaskId = task.TaskId,
                        Title = task.Title,
                        DueDate = task.DueDate,
                        Importance = task.CategoryId,
                        Status = task.State
                    });
                }
                if (data.Count > 0)
                {
                    source = null;
                    source = new BindingSource();
                    source.DataSource = data;
                    SetDataSource(source);
                }
                else {
                    MessageBox.Show("You do not have any task", "Show task", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Show task", MessageBoxButtons.OK);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create frmCreate = new Create()
            {
                LoginUser = this.User,
            };
            this.Hide();
            frmCreate.ShowDialog();
            this.Show();
            LoadData();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImportant_Click(object sender, EventArgs e)
        {
            try
            {
                List<TaskObject> tasks = taskRepository.GetAllTaskOfUser(this.User.Username);
                List<dynamic> data = new List<dynamic>();
                foreach (TaskObject task in tasks)
                {
                    if (task.CategoryId == 1)
                    {
                        data.Add(new
                        {
                            TaskId = task.TaskId,
                            Title = task.Title,
                            DueDate = task.DueDate,
                            Importance = task.CategoryId,
                            Status = task.State
                        });
                    }
                }
                if (data.Count > 0)
                {
                    source = null;
                    source = new BindingSource();
                    source.DataSource = data;
                    SetDataSource(source);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Show important task", MessageBoxButtons.OK);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                UserObject user = User;
                DetailForm frmDetail = new DetailForm() { UUser = user, Id = Convert.ToInt32(taskList.CurrentRow.Cells[0].Value.ToString()) };
                this.Hide();
                frmDetail.ShowDialog();
                this.Show();       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "View task in detail", MessageBoxButtons.OK);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void taskList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = taskList.SelectedCells[4].Value.ToString();
            if (status == "Complete")
            {
                btnDone.Text = "To doing";
            }
            else
            {
                btnDone.Text = "Done";
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(taskList.SelectedCells[0].Value.ToString());
                if (btnDone.Text.Equals("To doing"))
                {
                    taskRepository.UpdateTaskState(id, "Incomplete");
                }
                else
                {
                    taskRepository.UpdateTaskState(id, "Complete");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chang task status", MessageBoxButtons.OK);
            }
        }

        private void btnMyDate_Click(object sender, EventArgs e) {
            try {
                List<TaskObject> tasks = taskRepository.GetAllTaskOfUser(this.User.Username);
                List<dynamic> data = new List<dynamic>();
                foreach (TaskObject task in tasks) {
                    //System.Diagnostics.Debug.WriteLine(task.StartDate.Date.ToString());
                   // System.Diagnostics.Debug.WriteLine(DateTime.Now.Date.ToString());
                    if (task.StartDate.Date.CompareTo(DateTime.Now.Date) == 0) {
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
                else {
                    MessageBox.Show("You do not have any task to day", "Show today task", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Show important task", MessageBoxButtons.OK);
            }
        }

        private void btnAllTask_Click(object sender, EventArgs e) {
            LoadData();
        }

        private void btbSearch_Click(object sender, EventArgs e) {
            try {
                string searchValue = txtSearch.Text.Trim();
                if (searchValue.Length == 0) {
                    throw new Exception("Search value is empty");
                }
                List<TaskObject> tasks = taskRepository.GetAllTaskOfUser(this.User.Username);
                List<dynamic> data = new List<dynamic>();
                foreach (TaskObject task in tasks) {
                    //System.Diagnostics.Debug.WriteLine(task.StartDate.Date.ToString());
                    // System.Diagnostics.Debug.WriteLine(DateTime.Now.Date.ToString());
                    if (task.Title.Contains(searchValue)) {
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
                else {
                    MessageBox.Show("No task match your search value", "Search task", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Show important task", MessageBoxButtons.OK);
            }
        }
    }
}
