using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.real_estate_app
{
    public class HouseBuilder : IHouseBuilder
    {
        private House _house;

        public HouseBuilder()
        {
            _house = new House();
        }

        public void BuildBedrooms(int number)
        {
            _house.Bedrooms = number;
        }

        public void BuildBathrooms(int number)
        {
            _house.Bathrooms = number;
        }

        public void BuildGarage()
        {
            _house.HasGarage = true;
        }

        public void BuildGarden()
        {
            _house.HasGarden = true;
        }

        public void BuildSwimmingPool()
        {
            _house.HasSwimmingPool = true;
        }

        public void SetAddress(string address)
        {
            _house.Address = address;
        }

        public House GetHouse()
        {
            return _house;
        }
    }

}
