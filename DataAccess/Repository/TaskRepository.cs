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

        public TaskObject GetTaskByTaskId(int taskId)
        {
            throw new NotImplementedException();
        }

        public List<TaskObject> GetTasksByGroupId(int groupId)
        {
            throw new NotImplementedException();
        }

        public void InsertTask(TaskObject task)
        {
            throw new NotImplementedException();
        }

        public void RemoveTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(TaskObject task)
        {
            throw new NotImplementedException();
        }
    }
}
