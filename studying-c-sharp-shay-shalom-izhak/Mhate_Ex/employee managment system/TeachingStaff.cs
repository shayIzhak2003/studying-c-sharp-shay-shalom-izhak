using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.employee_managment_system
{
    public class TeachingStaff
    {
        private const int MAX_STAFF_COUNT = 200;
        private int current;
        private Employe[] staffArray;

        // Constructor
        public TeachingStaff()
        {
            staffArray = new Employe[MAX_STAFF_COUNT];
            current = 0;
        }

        public int CountHeads()
        {
            int headCount = 0;
            for(int i = 0; i < staffArray.Length; i++)
            {
                if (staffArray[i] is Head)
                {
                    headCount++;
                }
            }
            return headCount;
        }
        public Tutor GetNewTutor(int curseNum)
        {
            for(int i = 0;i < staffArray.Length; i++)
            {
                if (staffArray[i] is Tutor tutor)
                {
                    if(tutor.GetCourseNum() == curseNum)
                    {
                        return tutor;
                    }
                }
            }
            return null;
        }

        // Add staff member to the array
        public void AddStaff(Employe staffMember)
        {
            if (current >= MAX_STAFF_COUNT)
            {
                Console.WriteLine("Cannot add more staff. Maximum limit of 200 reached.");
                return;
            }

            staffArray[current] = staffMember;
            current++;
            Console.WriteLine($"Staff member added: {staffMember.name}");
        }


    }
}
