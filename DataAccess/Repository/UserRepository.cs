using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository:IUserRepository
    {
        public List<UserObject> GetUsers()
        {
            UserDAO userDAO = new UserDAO();
            return userDAO.GetUsers();
        }
        public UserObject GetUser(string username)
        {
            UserDAO userDAO = new UserDAO();
            return userDAO.GetUser(username);
        }
        public void UpdateUser(UserObject user)
        {
            UserDAO userDAO = new UserDAO();
            userDAO.UpdateUser(user);
        }
        public void DeleteUser(string username)
        {
            UserDAO userDAO = new UserDAO();
            userDAO.DeleteUser(username);
        }
        public void InsertNewUser(UserObject user)
        {
            UserDAO userDAO = new UserDAO();
            userDAO.InsertNewUser(user);
        }
    }
}
