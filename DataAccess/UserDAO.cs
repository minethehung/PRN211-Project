using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{

    public class UserDAO
    {
        public List<UserObject> GetUsers()
        {
            List<UserObject> users = null;
            SqlConnection connection = DbHelper.getConnection();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT username, [password], [name], date_of_birth, img " +
                "FROM users ";
            connection.Open();
            DbDataReader dbDataReader = cmd.ExecuteReader();

            while (dbDataReader.Read())
            {
                UserObject user = new UserObject();
                user.Username = dbDataReader["username"].ToString();
                user.Password = dbDataReader["password"].ToString();
                user.FullName = dbDataReader["name"].ToString();
                user.DateOfBirh = DateTime.Parse(dbDataReader["date_of_birth"].ToString());
                user.ImagePath = dbDataReader["img"].ToString();
                if (users == null)
                {
                    users = new List<UserObject>();
                }
                users.Add(user);
            }
            connection.Close();
            return users;
        }
        public UserObject GetUser(string username)
        {
            UserObject user = null;
            SqlConnection connection = DbHelper.getConnection();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT username, [password], [name], date_of_birth, img " +
                "FROM users WHERE username = @username";
            cmd.Parameters.AddWithValue("@username", username);
            connection.Open();
            DbDataReader dbDataReader = cmd.ExecuteReader();

            while (dbDataReader.Read())
            {
                user = new UserObject();
                user.Username = username;
                user.Password = dbDataReader["password"].ToString();
                user.FullName = dbDataReader["name"].ToString();
                user.DateOfBirh = DateTime.Parse(dbDataReader["date_of_birth"].ToString());
                user.ImagePath = dbDataReader["img"].ToString();

            }
            connection.Close();
            return user;
        }
        public void UpdateUser(UserObject user)
        {
            SqlConnection connection = DbHelper.getConnection();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE users SET  [password] = @password, [name] = @name, date_of_birth = @date_of_birth, img = @img " +
                "WHERE username = @username";
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@name", user.FullName);
            cmd.Parameters.AddWithValue("@date_of_birth", user.DateOfBirh);
            cmd.Parameters.AddWithValue("@img", user.ImagePath);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteUser(string username)
        {
            SqlConnection connection = DbHelper.getConnection();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM users WHERE username = @username";
            cmd.Parameters.AddWithValue("@username", username);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void InsertNewUser(UserObject user)
        {
            SqlConnection connection = DbHelper.getConnection();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO users(username, [password], [name], date_of_birth, img) " +
                "VALUES(@username, @password, @name, @date_of_birth, @img)";
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@name", user.FullName);
            cmd.Parameters.AddWithValue("@date_of_birth", user.DateOfBirh);
            cmd.Parameters.AddWithValue("@img", user.ImagePath);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
    }
}
