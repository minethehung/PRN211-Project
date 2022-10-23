using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ITaskRepository
    {
        List<TaskObject> GetAllTaskOfUser(string username);
        public void UpdateTaskState(int id, string status);
        TaskObject GetTaskByTaskId(int taskId);
        void InsertTask(TaskObject task);
        void UpdateTask(TaskObject task);
        void RemoveTask(int taskId);
        List<TaskObject> GetTasksByGroupId(int groupId);
        public TaskObject GetTaskDetail(int id);

    }
}
