using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DbHelper
    {
        public static string getConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", true, true)
                            .Build();
            string strConnection = config["ConnectionStrings:Todolist"];
            return strConnection;
        }
        public static SqlConnection getConnection()
        {
            return new SqlConnection(getConnectionString());
        }

    }
}
