namespace BusinessObject
{
    public class TaskObject
    {
      
        
        public TaskObject()
        {

        }

        public TaskObject(int taskId, string title, string description, DateTime dueDate, int categoryId, string repeat, DateTime remind, DateTime startDate, int groupId, string username, string state) {
            TaskId = taskId;
            Title = title;
            Description = description;
            DueDate = dueDate;
            CategoryId = categoryId;
            Repeat = repeat;
            Remind = remind;
            StartDate = startDate;
            GroupId = groupId;
            Username = username;
            State = state;
        }

        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int CategoryId { get; set; }
        public string Repeat { get; set; }
        public DateTime Remind { get; set; }
        public DateTime StartDate { get; set; }
        public int GroupId { get; set; }
        public string Username { get; set; }
        public string State { get; set; }

        public string getTask()
        {
            return TaskId + "-" + Title + "-" + Description + "-" + DueDate + "-" + CategoryId + "-" + Repeat + "-" + StartDate + "-" + GroupId + "-" + Username + "-" + State;
        }
    }
}
