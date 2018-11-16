using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_RemoveFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            InstructorRepository instructorRepo = new InstructorRepository();
            List<Instructor> instructors = instructorRepo.GetInstructorList();

            Instructor josh = new Instructor(1,"Josh", 23);
            Instructor ransford = new Instructor(2,"Ransford", 27);
            Instructor paul = new Instructor(3,"Paul", 40);
            Instructor tom = new Instructor(4, "Tom", 29);

            Console.WriteLine();
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine();
            var name = Console.ReadLine();

            Console.WriteLine();
            var age = int.Parse(Console.ReadLine());

            Instructor newinstructor = new Instructor(id, name, age);
            instructorRepo.AddInstructorToList(newinstructor);

            instructorRepo.AddInstructorToList(josh);
            instructorRepo.AddInstructorToList(ransford);
            instructorRepo.AddInstructorToList(paul);
            instructorRepo.AddInstructorToList(tom);

            Console.WriteLine("Enter the instructor id you would like to remove: ");
            Console.WriteLine("Id\t\tName\tAge");
            foreach (Instructor instructor in instructors)
            {
                Console.WriteLine($"{instructor.Id}\t\t{instructor.Name}\t{instructor.Age}");
            }
            var removeInstructor = int.Parse(Console.ReadLine());

            foreach (Instructor instructor in instructors)
            {
                if (removeInstructor == instructor.Id)
                {
                    instructorRepo.RemoveInstructor(instructor);
                    break;
                }
            }

            foreach (Instructor instructor in instructors)
            {
                Console.WriteLine(instructor.Name);
            }
            
            Console.ReadLine();
        }
    }
}
