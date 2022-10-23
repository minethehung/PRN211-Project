using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class CategoryDAO
    {
        // Singleton 
        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }
        public List<CategoryObject> GetCategoryList()
        {
            List<CategoryObject> categories = new List<CategoryObject>();
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader dataReader = null;
            try
            {
                connection = DbHelper.getConnection();
                connection.Open();
                string SQLSelect = "SELECT [category_id], [name] FROM [categories] ";
                command = new SqlCommand(SQLSelect, connection);
                dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (dataReader.HasRows == true)
                {
                    while (dataReader.Read())
                    {
                        categories.Add(new CategoryObject
                        {
                            Id = dataReader.GetInt32("category_id"),
                            Name = dataReader.GetString("name")
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
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return categories;
        }

        public CategoryObject GetCategoryById(int categoryId)
        {
            CategoryObject result = null;
            try
            {
                var categories = GetCategoryList();
                if (categories != null)
                {
                    result = categories.SingleOrDefault(c => c.Id == categoryId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public CategoryObject GetCategoryByName(string categoryName)
        {
            CategoryObject category = null;

            try
            {
                var categories = GetCategoryList();
                category = categories.SingleOrDefault(c => c.Name.Equals(categoryName.Trim()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return category;
        }

        public void AddCategory(string categoryName)
        {
            if (GetCategoryByName(categoryName) != null)
            {
                throw new Exception($"Category '{categoryName.Trim()}' is existed!");
            }
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = DbHelper.getConnection();
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO categories([name]) VALUES(@name) ";
                cmd.Parameters.AddWithValue("@name", categoryName);
                con.Open();
                int affectedRows = cmd.ExecuteNonQuery();
                con.Close();
                if (affectedRows == 0)
                {
                    throw new Exception("Failed to add new category!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
