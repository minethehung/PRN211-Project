using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class TaskGroupObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public TaskGroupObject(int id, string name, string description, string username)
        {
            Id = id;
            Name = name;
            Description = description;
            Username = username;
        }
        public TaskGroupObject() { }
    }
}
