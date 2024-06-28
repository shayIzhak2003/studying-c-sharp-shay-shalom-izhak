using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson8
{
    public class Object_var
    {
        public static void DemoMain()
        {
            // Declare an object variable
            object myObject;

            // Assign different types of data to the object variable
            myObject = 42; // Integer
            Console.WriteLine("Integer value: " + myObject);

            myObject = 3.14; // Double
            Console.WriteLine("Double value: " + myObject);

            myObject = "Hello, World!"; // String
            Console.WriteLine("String value: " + myObject);

            myObject = true; // Boolean
            Console.WriteLine("Boolean value: " + myObject);

            // Demonstrating boxing and unboxing with object
            int number = 123;
            myObject = number; // Boxing
            Console.WriteLine("Boxed integer: " + myObject);

            // Unbox the object back to an integer
            int unboxedNumber = (int)myObject; // Unboxing
            Console.WriteLine("Unboxed integer: " + unboxedNumber);
        }
    }
}
