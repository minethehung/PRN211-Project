﻿namespace BusinessObject
{
    public class TaskObject
    {
      
        
        public TaskObject()
        {

        }

        public TaskObject(int taskId, string title, string description, string dueDate, int categoryId, int repeatId, int remind, string startDate, int groupId, string username, string state) {
            TaskId = taskId;
            Title = title;
            Description = description;
            DueDate = dueDate;
            CategoryId = categoryId;
            RepeatId = repeatId;
            Remind = remind;
            StartDate = startDate;
            GroupId = groupId;
            Username = username;
            State = state;
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