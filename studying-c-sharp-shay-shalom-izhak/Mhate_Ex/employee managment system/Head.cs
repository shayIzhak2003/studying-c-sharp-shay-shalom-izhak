using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.employee_managment_system
{
    public class Head : Lecturer
    {
        public Lecturer[] lecturersArr;

       
        public Head(string specialization, string name, int arraySize) : base(specialization, name)
        {
            if (arraySize < 8 || arraySize > 20)
            {
                throw new ArgumentException("The number of lecturers must be between 8 and 20.");
            }

            lecturersArr = new Lecturer[arraySize];
        }

        
        public Lecturer[] GetLecturersArr()
        {
            return lecturersArr;
        }

        // Setter for lecturersArr with validation
        public void SetLecturersArr(Lecturer[] lecturers)
        {
            if (lecturers.Length < 8 || lecturers.Length > 20)
            {
                throw new ArgumentException("The number of lecturers must be between 8 and 20.");
            }

            lecturersArr = lecturers;
        }
    }
}
