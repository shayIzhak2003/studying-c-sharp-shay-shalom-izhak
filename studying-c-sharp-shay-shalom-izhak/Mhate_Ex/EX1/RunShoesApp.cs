using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.EX1
{
    public class RunShoesApp
    {
        public static void DemoMain()
        {
            // Example for Kids Shoe
            KidsShoe kidsShoe = new KidsShoe("Adidas", 35, "Red", true);
            Console.WriteLine($"Kids Shoe Price: {kidsShoe.CalculatePrice()} ₪");

            // Example for Womens Shoe
            WomensShoe womensShoe = new WomensShoe("Nike", 42, "Black", 2023, 5);
            Console.WriteLine($"Women's Shoe Price: {womensShoe.CalculatePrice()} ₪");

            // Example for Mens Shoe
            MensShoe mensShoe = new MensShoe("Puma", 43, "Blue", 2023, true);
            Console.WriteLine($"Men's Shoe Price: {mensShoe.CalculatePrice()} ₪");

            Storage storage = new Storage();

            storage.AddShoe(new KidsShoe("Adidas", 36, "Blue", true));
            storage.AddShoe(new KidsShoe("Nike", 34, "Pink", true));
            storage.AddShoe(new MensShoe("Puma", 42, "Black", 2022, false));

            Console.WriteLine($"Number of orthopedic kids' shoes: {storage.CalcOrthopedicCount()}");
        }
    }
}
