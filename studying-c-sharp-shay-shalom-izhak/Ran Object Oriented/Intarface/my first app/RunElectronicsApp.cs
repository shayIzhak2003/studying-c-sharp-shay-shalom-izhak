using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Ran_Object_Oriented.Intarface.my_first_app
{
    public class RunElectronicsApp
    {

        public static object[] countObjects(object[] arr)
        {
            int countElectrinics = 0;
            int countTv = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if()
            }
        }
        public static void DemoMain()
        {
            Elctronics e1 = new Elctronics("playstaion5", 230);
            Elctronics e2 = new Elctronics("oven", 350);
            IElectric e3 = new Elctronics("PSVITA", 400);
            Tv t1 = new Tv("LG", 300, 2, 12, "4K");
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(t1);

            Console.WriteLine("======");
            Console.WriteLine("CHECKING FUNCTIONS....");
            Console.WriteLine($"is e1 as more or 250V? {e1.Is250V()}");
            Console.WriteLine($"is e2 as more or 250V? {e2.Is250V()}");
            Console.WriteLine($"is e3 as more or 250V? {e3.Is250V()}");
            Console.WriteLine($"is t1 as more or 250V? {t1.Is250V()}");
            Console.WriteLine("=======");
            Console.WriteLine("the products voltage list:");
            Console.WriteLine(e1.ReturnVoltage());
            Console.WriteLine(e2.ReturnVoltage());
            Console.WriteLine(e3.ReturnVoltage());
            Console.WriteLine(t1.ReturnVoltage());
        }
    }
}
