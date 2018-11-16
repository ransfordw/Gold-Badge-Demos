using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_RemoveFromList
{
    public class InstructorRepository
    {
        private List<Instructor> _instructors = new List<Instructor>();

        public List<Instructor> GetInstructorList()
        {
            return _instructors;
        }
        public void AddInstructorToList(Instructor instructor)
        {
            _instructors.Add(instructor);
        }
        public void RemoveInstructor(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }
    }
}
