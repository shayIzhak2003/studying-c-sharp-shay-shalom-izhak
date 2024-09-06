using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.FactoryMethodPattern.LogisticsApp
{
    // Concrete Creator - Air Logistics (uses airplanes)
    public class AirLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Airplane();
        }
    }

}
