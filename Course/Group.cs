using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Group
    {
        private static i    nt id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> students { get; set; }

        public Group(string name)
        {
            Id = Id++;
            Name = name;
        }
    }
}
