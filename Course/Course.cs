using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Course
    {
        private static int id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Group> Groups { get; set; } 

        public Course(string name)
        {
            Id = Id++;
            Name = name;
        }
        public void AddGroup(Group group) 
        {
            Groups.Add(group);
        }
    }
}
