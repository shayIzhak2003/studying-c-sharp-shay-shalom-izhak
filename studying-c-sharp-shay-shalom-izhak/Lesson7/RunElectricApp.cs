using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson7
{
    public class RunElectricApp
    {
        public static void DemoMain()
        {

            ElectronicProduct electronicProduct = new ElectronicProduct("Sony", "GenericModel", 150.00);
            ElectronicProduct screen = new Screen("Samsung", "UltraSharp", 499.99, 27.0, "4K", true);
            var tv = new Tv("LG", "SuperHD", 999.99, 65.0, "8K", true, "South Korea", "Wall-mounted");

            
            Console.WriteLine("Electronic Product:");
            Console.WriteLine(electronicProduct.ToString());

            Console.WriteLine("\nScreen:");
            Console.WriteLine(screen.ToString());

            Console.WriteLine("\nTV:");
            Console.WriteLine(tv.ToString());
        }
    }
}
