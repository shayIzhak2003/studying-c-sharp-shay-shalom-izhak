using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.employee_managment_system
{
    public class RunEmployeeApp
    {
        public static void DemoMain()
        {   // Create an array of staff members
            Employe[] staffArray = new Employe[]
            {
            new Tutor("Alice", 101),
            new Tutor("Bob", 202),
            new Lecturer("Physics", "Charlie"),
            new Lecturer("Math", "Diana"),
            new Head("Computer Science", "Eve", 8),
            new Head("Biology", "Frank", 10)
            };

            // Initialize TeachingStaff object
            TeachingStaff teachingStaff = new TeachingStaff();

            // Add staff members to the TeachingStaff object
            foreach (var staff in staffArray)
            {
                teachingStaff.AddStaff(staff);
            }

            // Populate Head with Lecturers
            Head head1 = (Head)staffArray[4];
            head1.SetLecturersArr(new Lecturer[]
            {
            new Lecturer("AI", "Lecturer1"),
            new Lecturer("ML", "Lecturer2"),
            new Lecturer("DS", "Lecturer3"),
            new Lecturer("OS", "Lecturer4"),
            new Lecturer("DB", "Lecturer5"),
            new Lecturer("NetSec", "Lecturer6"),
            new Lecturer("Cloud", "Lecturer7"),
            new Lecturer("WebDev", "Lecturer8")
            });

            Head head2 = (Head)staffArray[5];
            head2.SetLecturersArr(new Lecturer[]
            {
            new Lecturer("Genetics", "LecturerA"),
            new Lecturer("Botany", "LecturerB"),
            new Lecturer("Zoology", "LecturerC"),
            new Lecturer("MicroBio", "LecturerD"),
            new Lecturer("BioChem", "LecturerE"),
            new Lecturer("Neuro", "LecturerF"),
            new Lecturer("Ecology", "LecturerG"),
            new Lecturer("MarineBio", "LecturerH"),
            new Lecturer("Anatomy", "LecturerI"),
            new Lecturer("Physiology", "LecturerJ")
            });

            // Display staff details
            Console.WriteLine($"\nThe total staff count is: {teachingStaff.CountHeads()}");
            Console.WriteLine($"The number of Heads is: {teachingStaff.CountHeads()}");

            Console.WriteLine("\nHead 1 Lecturers:");
            foreach (var lecturer in head1.GetLecturersArr())
            {
                Console.WriteLine($"- {lecturer.name}, Specialization: {lecturer.GetSpecialization()}");
            }

            Console.WriteLine("\nHead 2 Lecturers:");
            foreach (var lecturer in head2.GetLecturersArr())
            {
                Console.WriteLine($"- {lecturer.name}, Specialization: {lecturer.GetSpecialization()}");
            }

            Console.WriteLine("\nProgram execution completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
