using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson10
{
    public class CastingDemo
    {
        public static void DemoMain()
        {
            // Implicit casting (automatically) - converting a smaller type to a larger type
            int num = 10;
            double doubleNum = num; // Implicit casting: int to double
            Console.WriteLine("Implicit casting: " + doubleNum);

            // Explicit casting (manually) - converting a larger type to a smaller type
            double doubleNum2 = 9.78;
            int num2 = (int)doubleNum2; // Explicit casting: double to int
            Console.WriteLine("Explicit casting: " + num2);

            // Casting custom objects
            DerivedClass derived = new DerivedClass();
            BaseClass baseClass = derived; // Implicit casting: DerivedClass to BaseClass
            derived = (DerivedClass)baseClass; // Explicit casting: BaseClass to DerivedClass

            baseClass.Show(); // Calls DerivedClass's Show method because of polymorphism
            derived.Show(); // Calls DerivedClass's Show method
        }
    }

    public class BaseClass
    {
        public virtual void Show()
        {
            Console.WriteLine("BaseClass Show method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Show()
        {
            Console.WriteLine("DerivedClass Show method");
        }
    }
}
