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
            // Creating instances of various products
            ElectronicProduct ep = new ElectronicProduct("Generic", "ModelA", 299.99);
            Screen screen = new Screen("Samsung", "UltraView", 799.99, 55, "4K", true);
            Tv tv = new Tv("LG", "SmartTV", 999.99, 65, "4K", true, "Korea", "Living Room");
            PlayStation ps = new PlayStation("Sony", "PS5", 499.99, 825, "PlayStation 5", true);

            // Upcasting
            ElectronicProduct epFromScreen = screen;
            ElectronicProduct epFromTv = tv;
            ElectronicProduct epFromPs = ps;

           
            Console.WriteLine(epFromScreen.ToString()); 
            Console.WriteLine(epFromTv.ToString());     
            Console.WriteLine(epFromPs.ToString());     


            // Down Casting
            if (epFromScreen is Screen)
            {
           
                Console.WriteLine("Screen-specific method: " + ((Screen)epFromScreen).GetResolution());
            }

            if (epFromTv is Tv derivedTv)
            {
                Console.WriteLine("TV-specific method: " + derivedTv.GetPlaceOfMade());
            }

            if (epFromPs is PlayStation derivedPs)
            {
                Console.WriteLine("PlayStation-specific method: " + derivedPs.DisplayStorageCapacity());
            }

            // Using `is` operator
            if (epFromScreen is Tv)
            {
                Console.WriteLine("This should not print: epFromScreen is a Tv");
            }

            if (epFromTv is Tv)
            {
                Console.WriteLine("epFromTv is a Tv");
            }

            if (epFromPs is PlayStation)
            {
                Console.WriteLine("epFromPs is a PlayStation");
            }

            // Using `typeof` operator
            Type typeOfScreen = typeof(Screen);
            Type typeOfTv = typeof(Tv);
            Type typeOfPlayStation = typeof(PlayStation);
            Type typeOfElectronicProduct = typeof(ElectronicProduct);

            Console.WriteLine("Type of screen: " + typeOfScreen);
            Console.WriteLine("Type of tv: " + typeOfTv);
            Console.WriteLine("Type of PlayStation: " + typeOfPlayStation);
            Console.WriteLine("Type of electronic product: " + typeOfElectronicProduct);

            // Using `GetType` method to get the exact runtime type
            Console.WriteLine("epFromScreen is exactly of type: " + epFromScreen.GetType());
            Console.WriteLine("epFromTv is exactly of type: " + epFromTv.GetType());
            Console.WriteLine("epFromPs is exactly of type: " + epFromPs.GetType());

            // Verifying types
            if (epFromScreen.GetType() == typeof(Screen))
            {
                Console.WriteLine("epFromScreen is exactly a Screen");
            }

            if (epFromTv.GetType() == typeof(Tv))
            {
                Console.WriteLine("epFromTv is exactly a Tv");
            }

            if (epFromPs.GetType() == typeof(PlayStation))
            {
                Console.WriteLine("epFromPs is exactly a PlayStation");
            }

            // Downcasting that will cause errors
            try
            {
                // This will cause an InvalidCastException because ep is not a Tv
                Tv invalidTv = (Tv)ep;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                // This will cause an InvalidCastException because epFromScreen is not a Tv
                Tv invalidTvFromScreen = (Tv)epFromScreen;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            // Using `as` operator to safely cast
            Tv safeTv = ep as Tv;
            if (safeTv == null)
            {
                Console.WriteLine("Safe casting with `as` failed: ep is not a Tv");
            }

            // Using `as` operator to safely cast
            Tv safeTvFromScreen = epFromScreen as Tv;
            if (safeTvFromScreen == null)
            {
                Console.WriteLine("Safe casting with `as` failed: epFromScreen is not a Tv");
            }
        }
    }
}
