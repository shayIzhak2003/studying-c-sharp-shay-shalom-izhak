using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.real_estate_app
{
    internal class RunRealEsteteApp
    {
        public static void DemoMain()
        {
            // Simple House
            IHouseBuilder simpleHouseBuilder = new HouseBuilder();
            HouseDirector simpleHouseDirector = new HouseDirector(simpleHouseBuilder);
            simpleHouseDirector.BuildSimpleHouse();
            House simpleHouse = simpleHouseDirector.GetHouse();
            Console.WriteLine(simpleHouse);

            // Luxury House
            IHouseBuilder luxuryHouseBuilder = new HouseBuilder();
            HouseDirector luxuryHouseDirector = new HouseDirector(luxuryHouseBuilder);
            luxuryHouseDirector.BuildLuxuryHouse();
            House luxuryHouse = luxuryHouseDirector.GetHouse();
            Console.WriteLine(luxuryHouse);
        }
    }
}
