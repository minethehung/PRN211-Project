using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class TaskGroupRepository : ITaskGroupRepository
    {
        public List<TaskGroupObject> GetTaskGroupList() => TaskGroupDAO.Instance.GetTaskGroupList();
        public List<TaskGroupObject> GetTaskGroupListByUser(string username) => TaskGroupDAO.Instance.GetTaskGroupListByUser(username);
        public int GetTaskGroupId(string username, string groupName) => TaskGroupDAO.Instance.GetTaskGroupId(username, groupName);
        public TaskGroupObject GetTaskGroupByUserAndName(string username, string name) => TaskGroupDAO.Instance.GetTaskGroupByUserAndName(username, name);
        public void InsertTaskGroup(TaskGroupObject taskGroup) => TaskGroupDAO.Instance.InsertTaskGroup(taskGroup);
    }
}
