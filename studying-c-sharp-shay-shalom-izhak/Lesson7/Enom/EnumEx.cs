using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson7.Enom
{
    public class EnumEx
    {
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public static void DemoMain()
        {
            // Using enums
            DaysOfWeek today = DaysOfWeek.Wednesday;

            Console.WriteLine($"Today is {today}");

            // Example switch statement with enums
            switch (today)
            {
                case DaysOfWeek.Monday:
                    Console.WriteLine("It's the start of the week.");
                    break;
                case DaysOfWeek.Friday:
                    Console.WriteLine("It's almost the weekend!");
                    break;
                case DaysOfWeek.Saturday:
                case DaysOfWeek.Sunday:
                    Console.WriteLine("It's the weekend!");
                    break;
                default:
                    Console.WriteLine("It's a weekday.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
