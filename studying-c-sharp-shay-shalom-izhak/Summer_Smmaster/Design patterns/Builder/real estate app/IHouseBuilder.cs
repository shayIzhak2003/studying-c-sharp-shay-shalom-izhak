using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.real_estate_app
{
    public interface IHouseBuilder
    {
        void BuildBedrooms(int number);
        void BuildBathrooms(int number);
        void BuildGarage();
        void BuildGarden();
        void BuildSwimmingPool();
        void SetAddress(string address);
        House GetHouse();
    }
}
