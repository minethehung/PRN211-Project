using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TaskGroupDAO
    {
        // Singleton 
        private static TaskGroupDAO instance = null;
        private static readonly object instanceLock = new object();
        private TaskGroupDAO() { }
        public static TaskGroupDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TaskGroupDAO();
                    }
                    return instance;
                }
            }
        }
        public List<TaskGroupObject> GetTaskGroupList()
        {
            List<TaskGroupObject> result = new List<TaskGroupObject>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = DbHelper.getConnection();
                if (con != null)
                {
                    con.Open();
                    string sql = "SELECT [task_group_id], [name], [description], [username] FROM [task_group] ";
                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new TaskGroupObject
                            {
                                Id = reader.GetInt32("task_group_id"),
                                Name = reader.GetString("name"),
                                Description = reader.GetString("description"),
                                Username = reader.GetString("username")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
            return result;
        }
        public List<TaskGroupObject> GetTaskGroupListByUser(string username)
        {
            if (username == null)
            {
                throw new Exception("Invalid user!");
            }
            IEnumerable<TaskGroupObject> result = null;
            try
            {
                List<TaskGroupObject> taskGroups = GetTaskGroupList();
                result = from g in taskGroups
                         where g.Username == username
                         select g;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result.ToList();
        }
        public int GetTaskGroupId(string username, string groupName)
        {
            int result = 0;
            try
            {
                List<TaskGroupObject> taskGroups = GetTaskGroupListByUser(username);
                result = taskGroups.SingleOrDefault(t => t.Name.Equals(groupName)).Id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public TaskGroupObject GetTaskGroupByUserAndName(string username, string name)
        {
            TaskGroupObject result = null;
            List<TaskGroupObject> taskGroups = GetTaskGroupListByUser(username);
            if (taskGroups != null)
            {
                result = taskGroups.SingleOrDefault(g => g.Name.Equals(name));
            }

            return result;
        }
        public void InsertTaskGroup(TaskGroupObject taskGroup)
        {
            if (GetTaskGroupByUserAndName(taskGroup.Username, taskGroup.Name) != null)
            {
                throw new Exception($"Group '{taskGroup.Name}' has been already created by {taskGroup.Username}!");
            }
            SqlConnection con = null;
            try
            {
                con = DbHelper.getConnection();
                if (con != null)
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO [task_group] ([name], [description], [username]) " +
                                          "VALUES (@name, @description, @username) ";
                        cmd.Parameters.AddWithValue("@name", taskGroup.Name);
                        cmd.Parameters.AddWithValue("@description", taskGroup.Description);
                        cmd.Parameters.AddWithValue("@username", taskGroup.Username);
                        con.Open();
                        int affectedRows = cmd.ExecuteNonQuery();
                        con.Close();
                        if (affectedRows == 0)
                        {
                            throw new Exception("Failed to add new group!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public TaskGroupObject GetTaskGroupById(int id)
        {
            TaskGroupObject taskGroubObj = new TaskGroupObject();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = DbHelper.getConnection();
                if (con != null)
                {
                    con.Open();
                    string sql = "SELECT [task_group_id], [name], [description], [username] " +
                        "FROM [task_group] " +
                        "WHERE [task_group_id] = @Id ";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            taskGroubObj = new TaskGroupObject
                            {
                                Id = reader.GetInt32("task_group_id"),
                                Name = reader.GetString("name"),
                                Description = reader.GetString("description"),
                                Username = reader.GetString("username")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
            return taskGroubObj;
        }
    }
}
