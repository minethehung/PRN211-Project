using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using Microsoft.Data.SqlClient;

namespace DataAccess {
    public class TaskDAO {
        // Singleton 
        private static TaskDAO instance = null;
        private static readonly object instanceLock = new object();
        private TaskDAO() { }
        public static TaskDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new TaskDAO();
                    }
                    return instance;
                }
            }
        }
        public List<TaskObject> GetAllTaskOfUser(string username) {
            List<TaskObject> list = new List<TaskObject>();
            public SqlConnection connection = null;
            
        }
    }
}
