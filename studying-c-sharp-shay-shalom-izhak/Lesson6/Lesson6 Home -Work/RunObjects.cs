using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static studying_c_sharp_shay_shalom_izhak.Lesson6.Lesson6_Home__Work.Objects;

namespace studying_c_sharp_shay_shalom_izhak.Lesson6.Lesson6_Home__Work
{
    public class RunObjects
    {

       public static void DemoMain()
        {
            Child1 child1 = new Child1("Alice", 10, "Painting", 5);
            Child2 child2 = new Child2("Bob", 12, "Math", "John");
            Child3 child3 = new Child3("Cathy", 15, "Basketball", "Engineer");

            // Test Child1
            Console.WriteLine("Testing Child1:");
            child1.DisplayInfo();
            child1.DisplayHobby();
            Console.WriteLine();

            // Test Child2
            Console.WriteLine("Testing Child2:");
            child2.DisplayInfo();
            child2.DisplayBestFriend();
            Console.WriteLine();

            // Test Child3
            Console.WriteLine("Testing Child3:");
            child3.DisplayInfo();
            child3.DisplayDreamJob();
            Console.WriteLine();
        }
    }
}
