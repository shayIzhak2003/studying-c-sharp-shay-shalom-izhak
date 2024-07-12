using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson10
{

    public class OverloadDemo
    {
        // Method with no parameters
        public void Print()
        {
            Console.WriteLine("Print method with no parameters.");
        }

        // Method with one int parameter
        public void Print(int number)
        {
            Console.WriteLine("Print method with int parameter: " + number);
        }

        // Method with one string parameter
        public void Print(string message)
        {
            Console.WriteLine("Print method with string parameter: " + message);
        }
    }

    public class RunOverloadDemo
    {
        public static void DemoMain()
        {
            OverloadDemo demo = new OverloadDemo();

            demo.Print(); // Calls the method with no parameters
            demo.Print(42); // Calls the method with int parameter
            demo.Print("Hello, world!"); // Calls the method with string parameter
        }
    }
}
