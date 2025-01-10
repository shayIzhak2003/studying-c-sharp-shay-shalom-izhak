using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Ran_Object_Oriented
{
    public class BasicObject
    {
        // function 1
        public static void HelloWorldFunction()
        {
            Console.WriteLine("Hello, World!");
        }

        // function 2
        public static int SumOfXandY(int x, int y)
        {
            return x + y;
        }
        // function 3
    }

    public class RunBasicObject
    {
        public static void DemoMain()
        {
            BasicObject.HelloWorldFunction();
            Console.WriteLine(BasicObject.SumOfXandY(3, 2));
        }
    }

}
