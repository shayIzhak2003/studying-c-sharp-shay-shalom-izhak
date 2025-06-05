using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Guy_EX6
{
 
    public class DemoMain
    {
        // 6 ג
        public static int Count(Sport[] s)
        {
            int countOBJ = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] is IGroup && s[i] is IHall)
                {
                    countOBJ++;
                }
            }
            return countOBJ;
        }

        public static void VirtualMain()
        {
            // values
            Sport s1 = new Sport();
            BBall b1 = new BBall(); // 1
            Sport bb2 = new BBall();// 2
            Sport s3 = new RGymnastic();
            Sport MR = new MRace();
            // TOTAL 2

            //array
            Sport[] arr = new Sport[] { s1, b1, bb2, s3, MR };

            //הפעלת הפונקציה
            Console.WriteLine(Count(arr));


        }
    }
}
