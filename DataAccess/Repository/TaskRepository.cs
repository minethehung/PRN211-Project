using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class TaskRepository : ITaskRepository
    {
        public List<TaskObject> GetAllTaskOfUser(string username) => TaskDAO.Instance.GetAllTaskOfUser(username);
        public void UpdateTaskState(int id, string status) => TaskDAO.Instance.UpdateTaskState(id, status);

        public TaskObject GetTaskByTaskId(int taskId)
        {
            return TaskDAO.Instance.GetTaskDetail(taskId);
        }

        public List<TaskObject> GetTasksByGroupId(int groupId)
        {
            throw new NotImplementedException();
        }

        public void InsertTask(TaskObject task) => TaskDAO.Instance.InsertTask(task);

        public void RemoveTask(int taskId) => TaskDAO.Instance.RemoveTask(taskId);
       

        public void UpdateTask(TaskObject task)
        {
            TaskDAO.Instance.UpdateTask(task);
        }
    }
}
