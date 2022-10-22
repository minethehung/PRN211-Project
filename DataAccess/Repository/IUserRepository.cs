using Azure.Identity;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        public List<UserObject> GetUsers();
        public UserObject GetUser(string username);
        public void UpdateUser(UserObject user);
        public void DeleteUser(string username);
        public void InsertNewUser(UserObject user);
    }
}
