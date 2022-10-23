using BusinessObject;
using DataAccess.Repository;
using ToDoListApp;

namespace Group9_Project
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
            txtTitle.Enabled = false;
            txtDes.Enabled = false;
            txtRemind.Enabled = false;
            dateTimeDeadline.Enabled = false;
            comboCategory.Enabled = false;
            comboImportant.Enabled = false;
            groupRepeat.Enabled = false;
            List<string> repeat = MyAppConstants.repeat;
            for (int i = 0; i < repeat.Count; i++)
            {
                comboTypeRepeat.Items.Add(repeat[i]);
            }
            List<string> category = MyAppConstants.category;
            for (int i = 0; i < category.Count; i++)
            {
                comboCategory.Items.Add(category[i]);
            }
        }

        public UserObject UUser { get; set; }
        public int Id { get; set; }
        private ITaskRepository repository = new TaskRepository();
        private void Detail_Load(object sender, EventArgs e)
        {
            int id = Id;
            TaskObject taskObj = repository.GetTaskDetail(id);
            txtTitle.Text = taskObj.Title;
            txtDes.Text = taskObj.Description;
            comboCategory.SelectedIndex = --taskObj.CategoryId;
            dateTimeDeadline.Value = taskObj.DueDate;
            comboTypeRepeat.SelectedIndex = --taskObj.RepeatId;
            comboTypeRepeat_SelectedIndexChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTitle.Enabled = true;
            txtDes.Enabled = true;
            txtRemind.Enabled = true;
            dateTimeDeadline.Enabled = true;
            comboImportant.Enabled = true;
            groupRepeat.Enabled = true;
            comboCategory.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Update", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("You have clicked Ok Button");
                //Some task…
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked Cancel Button");
                //Some task…
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboTypeRepeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboTypeRepeat.SelectedItem.ToString() == "Week")
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
    }
}
