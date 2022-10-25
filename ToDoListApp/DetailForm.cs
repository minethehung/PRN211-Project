using BusinessObject;
using DataAccess.Repository;
using static System.Windows.Forms.AxHost;

namespace Group9_Project
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();

        }

        public UserObject UUser { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        private ITaskRepository repository = new TaskRepository();
        private ITaskGroupRepository taskGroupRepository = new TaskGroupRepository();
        private void Detail_Load(object sender, EventArgs e)
        {
            txtTitle.Enabled = false;
            txtDes.Enabled = false;
            dateDueDate.Enabled = false;
            timeDueDate.Enabled = false;
            dateRemind.Enabled = false;
            timeRemind.Enabled = false;
            comboCategory.Enabled = false;
            comboGroup.Enabled = false;
            groupRepeat.Enabled = false;
            btnFinish.Enabled = false;
            int id = Id;
            TaskObject taskObj = repository.GetTaskByTaskId(id);
            txtTitle.Text = taskObj.Title;
            txtDes.Text = taskObj.Description;
            comboCategory.SelectedIndex = --taskObj.CategoryId;
            getRepeatTime(taskObj.Repeat);
            DateTime dateTimeDueDate = taskObj.DueDate;
            dateDueDate.Text = dateTimeDueDate.ToShortDateString();
            timeDueDate.Text = dateTimeDueDate.ToLongTimeString();
            DateTime dateTimeRemid = taskObj.Remind;
            dateRemind.Text = dateTimeRemid.ToShortDateString();
            timeRemind.Text = dateTimeRemid.ToLongTimeString();
            btnAddGroup.Enabled = false;
            group.Visible = false;
            cboTaskGroup_LoadDataSource();
            //comboTypeRepeat.SelectedIndex = 0;
            //dateTimeDeadline.Value = taskObj.DueDate;
            comboTypeRepeat_SelectedIndexChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (btnFinish.Enabled)
            {
                DialogResult res = MessageBox.Show("Something was Changed. Do you want to save?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    //Code save Here
                    this.Close();
                }
                if (res == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }

        }

        private void comboTypeRepeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTypeRepeat.SelectedItem.ToString() == "weeks")
            {
                Su.Visible = true;
                Mo.Visible = true;
                Tu.Visible = true;
                We.Visible = true;
                Th.Visible = true;
                Fr.Visible = true;
                Sa.Visible = true;
            }
            else
            {
                Su.Visible = false;
                Mo.Visible = false;
                Tu.Visible = false;
                We.Visible = false;
                Th.Visible = false;
                Fr.Visible = false;
                Sa.Visible = false;
            }
        }
        private string CheckEmptyString(string s)
        {
            if (s == null || s.Trim().Equals(""))
            {
                throw new Exception("Input field cannot be empty!");
            }
            return s.Trim();
        }
        private string GetRepeatString()
        {
            string repeatCount = CheckEmptyString(txtRepeatCount.Text);
            string repeatType = CheckEmptyString(comboTypeRepeat.Text);
            string result = repeatCount + " " + repeatType;
            if (!repeatType.Equals("weeks"))
            {
                return result;
            }
            result += "/";
            if (Mo.Checked)
            {
                result += "Mo, ";
            }
            if (Tu.Checked)
            {
                result += "Tu, ";
            }
            if (We.Checked)
            {
                result += "We, ";
            }
            if (Th.Checked)
            {
                result += "Th, ";
            }
            if (Fr.Checked)
            {
                result += "Fr, ";
            }
            if (Sa.Checked)
            {
                result += "Sa, ";
            }
            if (Su.Checked)
            {
                result += "Su, ";
            }

            return result.Substring(0, result.Length - 2);
        }
        private void getRepeatTime(string repeat)
        {

            string[] repeatCount = repeat.Split(" ");
            string count = repeatCount[0];
            string[] repeatTime = repeatCount[1].Split("/");
            txtRepeatCount.Text = count;
            System.Diagnostics.Debug.WriteLine(":V " + repeat);
            if (repeatTime[0] == "days")
            {
                comboTypeRepeat.SelectedIndex = 0;
            }
            else
            {
                comboTypeRepeat.SelectedIndex = 1;
                string[] dayOfWeek = repeatTime[1].Split(",");
                System.Diagnostics.Debug.WriteLine("DCM: " + repeatTime[1]);
                for (int i = 0; i < dayOfWeek.Length; i++)
                {
                    System.Diagnostics.Debug.WriteLine("Ma may: " + dayOfWeek[i]);
                }
                for (int i = 0; i < dayOfWeek.Length; i++)
                {

                    if (dayOfWeek[i].Trim() == "Mo")
                    {
                        Mo.Checked = true;
                        //Mo.BackColor = SystemColors.MenuHighlight;
                    }
                    if (dayOfWeek[i].Trim() == "Tu")
                    {
                        Tu.Checked = true;
                        //Tu.BackColor = SystemColors.MenuHighlight;
                    }
                    if (dayOfWeek[i].Trim() == "We")
                    {
                        We.Checked = true;
                        //We.BackColor = SystemColors.MenuHighlight;
                    }
                    if (dayOfWeek[i].Trim() == "Th")
                    {
                        Th.Checked = true;
                        //Th.BackColor = SystemColors.MenuHighlight;
                    }
                    if (dayOfWeek[i].Trim() == "Fr")
                    {
                        Fr.Checked = true;
                        //Fr.BackColor = SystemColors.MenuHighlight;
                    }
                    if (dayOfWeek[i].Trim() == "Sa")
                    {
                        Sa.Checked = true;
                        //Sa.BackColor = SystemColors.MenuHighlight;
                    }
                    if (dayOfWeek[i].Trim() == "Su")
                    {
                        Su.Checked = true;
                        //Su.BackColor = SystemColors.MenuHighlight;
                    }
                }
            }

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtTitle.Enabled = true;
            txtDes.Enabled = true;
            dateDueDate.Enabled = true;
            timeDueDate.Enabled = true;
            dateRemind.Enabled = true;
            timeRemind.Enabled = true;
            comboGroup.Enabled = true;
            groupRepeat.Enabled = true;
            comboCategory.Enabled = true;
            btnFinish.Enabled = true;
            btnAddGroup.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Update", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                //Code save here
                TaskObject obj = getTask();
                MessageBox.Show(obj.getTask());
                this.Detail_Load(sender, e);
            }
            if (res == DialogResult.Cancel)
            {
                this.Detail_Load(sender, e);
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            group.Visible = true;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            group.Visible = false;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Title = txtTitleGroup.Text.Trim();
            Description = txtDesGroup.Text.Trim();
            if (Title.Length > 0)
            {
                comboGroup.Items.Add(Title);
                comboGroup.SelectedIndex = comboGroup.Items.IndexOf(Title);
            }
            group.Visible = false;
        }
        private void cboTaskGroup_LoadDataSource()
        {
            IEnumerable<TaskGroupObject> taskGroups = null;
            try
            {
                taskGroups = taskGroupRepository.GetTaskGroupListByUser(UUser.Username);
                if (taskGroups == null)
                {
                    taskGroups = new List<TaskGroupObject>();
                }
                foreach (TaskGroupObject value in taskGroups)
                {
                    System.Diagnostics.Debug.WriteLine(value.Name);
                    comboGroup.Items.Add(value.Name);
                }
                string name = taskGroupRepository.GetTaskGroupById(repository.GetTaskByTaskId(Id).GroupId).Name;
                comboGroup.SelectedIndex = comboGroup.Items.IndexOf(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Groups", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Su_CheckedChanged(object sender, EventArgs e)
        {

            Su.BackColor = Su.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;

        }
        private void Mo_CheckedChanged(object sender, EventArgs e)
        {

            Mo.BackColor = Mo.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;

        }

        private void Tu_CheckedChanged(object sender, EventArgs e)
        {

            Tu.BackColor = Tu.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;
        }

        private void We_CheckedChanged(object sender, EventArgs e)
        {

            We.BackColor = We.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;

        }

        private void Th_CheckedChanged(object sender, EventArgs e)
        {

            Th.BackColor = Th.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;

        }

        private void Fr_CheckedChanged(object sender, EventArgs e)
        {

            Fr.BackColor = Fr.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;

        }

        private void Sa_CheckedChanged(object sender, EventArgs e)
        {

            Sa.BackColor = Sa.Checked ? SystemColors.MenuHighlight : SystemColors.ButtonHighlight;

        }
        private TaskObject getTask()
        {
            string title = txtTitle.Text;
            string description = txtDes.Text;
            string username = UUser.Username;
            int taskId = Id;
            string category = comboCategory.Text;
            int taskCate = 0;

            if (category == "Critical")
            {
                taskCate = 1;
            }
            if (category == "High")
            {
                taskCate = 2;
            }
            if (category == "Normal")
            {
                taskCate = 3;
            }
            if (category == "Critical")
            {
                taskCate = 4;
            }

            string repeat = GetRepeatString();
            DateTime dueDate = dateDueDate.Value.Date.Add(timeDueDate.Value.TimeOfDay);
            DateTime remind = dateRemind.Value.Date.Add(timeRemind.Value.TimeOfDay);
            string group = comboGroup.Text;
            if (group == Title)
            {
                TaskGroupObject objG = new TaskGroupObject(Id, Title, Description, UUser.Username);
                taskGroupRepository.InsertTaskGroup(objG);
            }
            int taskGroupId = taskGroupRepository.GetTaskGroupId(UUser.Username, group);
            TaskObject obj = new TaskObject()
            {
                Title = title,
                Description = description,
                CategoryId = taskCate,
                GroupId = taskGroupId,
                Username = username,
                DueDate = dueDate,
                Remind = remind,
                Repeat = repeat,
            };
            return obj;
        }


    }
}
