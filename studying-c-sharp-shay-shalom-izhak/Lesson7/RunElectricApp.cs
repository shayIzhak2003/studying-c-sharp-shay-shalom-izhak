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


            // Creating instances of each class
            var electronicProduct = new ElectronicProduct("Generic", "ModelX", 99.99);
            var screen = new Screen("Samsung", "Q90T", 1299.99, 65, "4K", true);
            var tv = new Tv("LG", "OLED55C1", 1499.99, 55, "4K", true, "South Korea", "Living Room");
            var playStation = new PlayStation("Sony", "PS5", 499.99, 825, "PlayStation 5", true);

            // Printing the details of each product
            Console.WriteLine("Electronic Product:");
            Console.WriteLine(electronicProduct.ToString());
            Console.WriteLine();

            Console.WriteLine("Screen:");
            Console.WriteLine(screen.ToString());
            Console.WriteLine();

            Console.WriteLine("TV:");
            Console.WriteLine(tv.ToString());
            Console.WriteLine();

            Console.WriteLine("PlayStation:");
            Console.WriteLine(playStation.ToString());
        }
    }
}
