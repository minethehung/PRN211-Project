namespace BusinessObject
{
    public class TaskObject
    {
        private int taskId;
        private string title;
        private string description;
        private string dueDate;
        private int categoryId;
        private int repeatId;
        private int remind;
        private string startDate;
        private int groupId;
        private string username;
        private string state;
        public TaskObject(int taskId, string title, string description, string dueDate, int categoryId, int repeatId, int remind, string startDate, int groupId, string username, string state)
        {
            this.taskId = taskId;
            this.title = title;
            this.description = description;
            this.dueDate = dueDate;
            this.categoryId = categoryId;
            this.repeatId = repeatId;
            this.remind = remind;
            this.startDate = startDate;
            this.groupId = groupId;
            this.username = username;
            this.state = state;
        }
        public TaskObject()
        {

        }
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public int CategoryId { get; set; }
        public int RepeatId { get; set; }
        public int Remind { get; set; }
        public string StartDate { get; set; }
        public int GroupId { get; set; }
        public string Username { get; set; }
        public string State { get; set; }
    }
}
