using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.real_estate_app
{
    public class HouseDirector
    {
        private readonly IHouseBuilder _houseBuilder;

        public HouseDirector(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void BuildSimpleHouse()
        {
            _houseBuilder.BuildBedrooms(2);
            _houseBuilder.BuildBathrooms(1);
            _houseBuilder.SetAddress("123 Simple St");
        }

        public void BuildLuxuryHouse()
        {
            _houseBuilder.BuildBedrooms(5);
            _houseBuilder.BuildBathrooms(4);
            _houseBuilder.BuildGarage();
            _houseBuilder.BuildGarden();
            _houseBuilder.BuildSwimmingPool();
            _houseBuilder.SetAddress("456 Luxury Ave");
        }

        public House GetHouse()
        {
            return _houseBuilder.GetHouse();
        }
    }

}
