using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex
{
    using System;

    public interface IPernting
    {
        void Print();
    }

    public class Father : IPernting
    {
        public void Print()
        {
            Console.WriteLine("i am the grandfather");
        }

        public void FatherPrint()
        {
            Console.WriteLine("i am the Father");
        }
    }

    public class Son : Father
    {
        public void SonPrint()
        {
            Console.WriteLine("i am the Son");
        }
    }

    public class RunPerenting
    {
        public static void DemoMain()
        {
            IPernting i1 = new Son();
            i1.Print();
            // i1.FatherPrint(); // This line would cause a compile-time error because `FatherPrint` is not defined in `IPernting`
            // To call `FatherPrint`, you need to cast `i1` to `Father`:
            if (i1 is Father father)
            {
                father.FatherPrint();
            }
        }
    }

}
