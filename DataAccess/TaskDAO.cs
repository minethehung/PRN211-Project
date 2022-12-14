using BusinessObject;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;
using System.Text;

namespace DataAccess
{
    public class TaskDAO
    {
        // Singleton 
        private static TaskDAO instance = null;
        private static readonly object instanceLock = new object();
        private TaskDAO() { }
        public static TaskDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TaskDAO();
                    }
                    return instance;
                }
            }
        }
        public List<TaskObject> GetAllTaskOfUser(string username)
        {
            List<TaskObject> tasks = new List<TaskObject>();
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader dataReader = null;
            try
            {
                connection = DbHelper.getConnection();
                connection.Open();
                string SQLSelect = "select * from tasks where username = @username order by state desc, category_id ";
                command = new SqlCommand(SQLSelect, connection);
                command.Parameters.AddWithValue("@username", username);
                dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (dataReader.HasRows == true)
                {
                    while (dataReader.Read())
                    {
                        tasks.Add(new TaskObject
                        {
                            TaskId = dataReader.GetInt32("task_id"),
                            Title = dataReader.GetString("title"),
                            Description = dataReader.GetString("description"),
                            DueDate = dataReader.GetDateTime("due_date"),
                            CategoryId = dataReader.GetInt32("category_id"),
                            Repeat = dataReader.GetString("repeat"),
                            Remind = dataReader.GetDateTime("remind_time"),
                            StartDate = dataReader.GetDateTime("start_date"),
                            GroupId = dataReader.GetInt32("group_id"),
                            Username = dataReader.GetString("username"),
                            State = dataReader.GetString("state")
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return tasks;
        }
        public void UpdateTaskState(int id, string status)
        {

            SqlConnection connection = null;
            SqlCommand command = null;

            try
            {
                connection = DbHelper.getConnection();
                connection.Open();
                string SQLSelect = "update tasks set [state] = @status where [task_id] = @id";
                command = new SqlCommand(SQLSelect, connection);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        public void RemoveTask(int id) {

            SqlConnection connection = null;
            SqlCommand command = null;

            try {
                connection = DbHelper.getConnection();
                connection.Open();
                string SQLSelect = "delete from tasks where [task_id] = @id";
                command = new SqlCommand(SQLSelect, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            finally {
                connection.Close();
            }

        }
        public void InsertTask(TaskObject task)
        {
            SqlConnection connection = null;
            SqlCommand command = null;

            try
            {
                connection = DbHelper.getConnection();
                connection.Open();
                string SQLSelect = "INSERT INTO tasks ([title], [description], [due_date], [category_id], [repeat], [remind_time], " +
                                    "[start_date], [group_id], [username], [state]) " +
                                    "VALUES (@title, @description, @due_date, @category_id, @repeat, @remind_time, " +
                                    "@start_date, @group_id, @username, @state) ";
                command = new SqlCommand(SQLSelect, connection);
                command.Parameters.AddWithValue("@title", task.Title);
                command.Parameters.AddWithValue("@description", task.Description);
                command.Parameters.AddWithValue("@due_date", task.DueDate);
                command.Parameters.AddWithValue("@category_id", task.CategoryId);
                command.Parameters.AddWithValue("@repeat", task.Repeat);
                command.Parameters.AddWithValue("@remind_time", task.Remind);
                command.Parameters.AddWithValue("@start_date", task.StartDate);
                command.Parameters.AddWithValue("@group_id", task.GroupId);
                command.Parameters.AddWithValue("@username", task.Username);
                command.Parameters.AddWithValue("@state", task.State);
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 0)
                {
                    throw new Exception("Failed to insert task!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public TaskObject GetTaskDetail(int id)
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            TaskObject task = null;
            SqlDataReader rd = null;
            try
            {
                connection = DbHelper.getConnection();
                connection.Open();
                string sql = "SELECT * from dbo.tasks WHERE task_id = @TaskId ";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@TaskId", id);
                rd = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        task = new TaskObject(
                            rd.GetInt32("task_id"),
                            rd.GetString("title"),
                            rd.GetString("description"),
                            rd.GetDateTime("due_date"),
                            rd.GetInt32("category_id"),
                            rd.GetString("repeat"),
                            rd.GetDateTime("remind_time"),
                            rd.GetDateTime("start_date"),
                            rd.GetInt32("group_id"),
                            rd.GetString("username"),
                            rd.GetString("state"));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return task;
        }
        public void UpdateTask(TaskObject obj)
        {

            SqlConnection connection = null;
            SqlCommand command = null;

            try
            {
                connection = DbHelper.getConnection();
                connection.Open();
                string SQLSelect = "UPDATE tasks " +
                    "set [title] = @Title, [description] = @Description, [due_date] = @Due, [category_id] = @Cate, [repeat] = @Repeat, [remind_time] = @Remind , group_id = @Group " +
                    "where [task_id] = @Id";
                command = new SqlCommand(SQLSelect, connection);
                command.Parameters.AddWithValue("@Title", obj.Title);
                command.Parameters.AddWithValue("@Description", obj.Description);
                command.Parameters.AddWithValue("@Due", obj.DueDate);
                command.Parameters.AddWithValue("@Cate", obj.CategoryId);
                command.Parameters.AddWithValue("@Repeat", obj.Repeat);
                command.Parameters.AddWithValue("@Remind", obj.Remind);
                command.Parameters.AddWithValue("@Group", obj.GroupId);
                command.Parameters.AddWithValue("@Id", obj.TaskId);
                int re = command.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine("Haiz: " + obj.getTask());
                System.Diagnostics.Debug.WriteLine("Fuck: " + re);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

    }
}

