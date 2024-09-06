using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.FactoryMethodPattern
{
    // Concrete Product - Bike
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a bike.");
        }
    }
}
