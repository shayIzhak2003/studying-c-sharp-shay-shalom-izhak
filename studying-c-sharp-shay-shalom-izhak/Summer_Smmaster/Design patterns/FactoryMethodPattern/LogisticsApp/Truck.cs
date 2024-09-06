using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.FactoryMethodPattern.LogisticsApp
{
    // Concrete Product - Truck
    public class Truck : ITransport
    {
        public string TransportType { get; private set; }
        public int Capacity { get; private set; }
        public int Speed { get; private set; }

        public Truck()
        {
            TransportType = "Truck";
            Capacity = 10000; // Capacity in kilograms
            Speed = 80;       // Speed in km/h
        }

        public void Deliver()
        {
            Console.WriteLine($"Delivering by {TransportType} with a capacity of {Capacity} kg at {Speed} km/h.");
        }
    }
}
