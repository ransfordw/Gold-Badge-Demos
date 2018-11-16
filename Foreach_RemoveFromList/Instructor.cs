using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_RemoveFromList
{
    public class Instructor
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }

        public Instructor() { }
        public Instructor(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
