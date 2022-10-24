using BusinessObject;
using DataAccess.Repository;

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
        private ITaskRepository repository = new TaskRepository();
        private void Detail_Load(object sender, EventArgs e)
        {
            txtTitle.Enabled = false;
            txtDes.Enabled = false;
            dateDueDate.Enabled = false;
            timeDueDate.Enabled = false;
            dateRemind.Enabled = false;
            timeRemind.Enabled = false;
            comboCategory.Enabled = false;
            comboImportant.Enabled = false;
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
            if (repeatTime[0] == "days")
            {
                comboTypeRepeat.SelectedIndex = 0;
            }
            else
            {
                comboTypeRepeat.SelectedIndex = 1;
                for(int i = 1; i < repeatTime.Length; i++)
                {
                    System.Diagnostics.Debug.WriteLine(repeatTime[i]);
                    if(repeatTime[i] == "Mo")
                    {
                        Mo.Checked = true;
                    }
                    if (repeatTime[i] == "Tu")
                    {
                        Tu.Checked = true;
                    }
                    if (repeatTime[i] == "We")
                    {
                        We.Checked = true;
                    }
                    if (repeatTime[i] == "Th")
                    {
                        Th.Checked = true;
                    }
                    if (repeatTime[i] == "Fr")
                    {
                        Fr.Checked = true;
                    }
                    if (repeatTime[i] == "Sa")
                    {
                        Sa.Checked = true;
                    }
                    if (repeatTime[i] == "Su")
                    {
                        Su.Checked = true;
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
            comboImportant.Enabled = true;
            groupRepeat.Enabled = true;
            comboCategory.Enabled = true;
            btnFinish.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Update", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                //Code save here
                this.Detail_Load(sender, e);
            }
            if (res == DialogResult.Cancel)
            {
                this.Detail_Load(sender, e);
            }
        }
    }
}
