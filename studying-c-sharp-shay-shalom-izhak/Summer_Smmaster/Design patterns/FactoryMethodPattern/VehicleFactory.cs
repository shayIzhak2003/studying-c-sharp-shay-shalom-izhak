using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.FactoryMethodPattern
{
    // Creator abstract class
    public abstract class VehicleFactory
    {
        // Factory method
        public abstract IVehicle CreateVehicle();

        // An operation that uses the factory method
        public void DeliverVehicle()
        {
            // Call the factory method to create a product
            IVehicle vehicle = CreateVehicle();
            vehicle.Drive();
        }
    }
}
