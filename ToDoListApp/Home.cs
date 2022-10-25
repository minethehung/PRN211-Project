using BusinessObject;
using DataAccess.Repository;
using System.Runtime.CompilerServices;
using ToDoListApp;

namespace Group9_Project
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }
        private ITaskRepository taskRepository = new TaskRepository();
        private IUserRepository userRepository = new UserRepository();
        private ITaskGroupRepository taskGroupRepository = new TaskGroupRepository();
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
            List<TaskGroupObject> tasks = taskGroupRepository.GetTaskGroupListByUser(this.User.Username);
            if (tasks.Count > 0) {
                List<string> data = new List<string>();
                data.Add("All");
                foreach (TaskGroupObject taskGroupObject in tasks) {
                    data.Add(taskGroupObject.Name);
                }
                cboGroup.DataSource = data;
            }
            
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
            enableButton();
            foreach (DataGridViewRow row in taskList.Rows) {
                if (row.Cells[4].Value.ToString() == "Complete") {
                    row.Cells[4].Style.ForeColor = Color.Green;
                }
                else {
                    row.Cells[4].Style.ForeColor = Color.Tomato;
                }
            }
        }
        private void LoadData()
        {
            disableButton();
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
            
            frmCreate.ShowDialog();
            
            LoadData();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void disableButton () {
            btnView.Enabled = false;
            btnDone.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void enableButton () {
            btnView.Enabled = true;
            btnDone.Enabled = true;
            btnDelete.Enabled = true;
        }
        private void btnImportant_Click(object sender, EventArgs e)
        {
            disableButton ();
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
                DetailForm frmDetail = new DetailForm { UUser = user, Id = int.Parse(taskList.SelectedCells[0].Value.ToString()) };
               
                frmDetail.ShowDialog();
                
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

        private void btnUpdateUser_Click(object sender, EventArgs e) {
            try {
                frmUpdateUser frmUpdateUser = new frmUpdateUser(this.User);
               
                frmUpdateUser.ShowDialog();
                
                this.User = userRepository.GetUser(this.User.Username);
                labelUsername.Text = User.FullName;
                if (User.ImagePath != null) {
                    pictureBox1.ImageLocation = User.ImagePath;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Update profile", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult res = MessageBox.Show("Are you sure to delete this task", "Delete task", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK) { 
                try {
                    int id = int.Parse(taskList.SelectedCells[0].Value.ToString());
                    taskRepository.RemoveTask(id);
                    LoadData();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Delete task", MessageBoxButtons.OK);
                }
            }
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                string groupText = cboGroup.SelectedItem.ToString();
                //System.Diagnostics.Debug.WriteLine(groupText);
                if (groupText.Equals("All")) {
                    LoadData();
                    return;
                }
              
                List<TaskObject> tasks = taskRepository.GetAllTaskOfUser(this.User.Username);
                List<dynamic> data = new List<dynamic>();
                foreach (TaskObject task in tasks) {
                    //System.Diagnostics.Debug.WriteLine(task.StartDate.Date.ToString());
                    // System.Diagnostics.Debug.WriteLine(DateTime.Now.Date.ToString());
                    if (taskGroupRepository.GetTaskGroupId(User.Username, groupText) == task.GroupId) {
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
