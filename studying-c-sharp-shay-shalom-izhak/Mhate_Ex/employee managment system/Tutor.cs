using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.employee_managment_system
{
    public class Tutor : Employe
    {
        public int CourseNum { get; set; }

        public Tutor(string name, int courseNum) : base(name)
        {
            this.CourseNum = courseNum;
        }

        // Getter for CourseNum
        public int GetCourseNum()
        {
            return this.CourseNum;
        }

        // Setter for CourseNum
        public void SetCourseNum(int courseNum)
        {
            this.CourseNum = courseNum;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Course Number: {this.GetCourseNum()}";
        }
    }
}
