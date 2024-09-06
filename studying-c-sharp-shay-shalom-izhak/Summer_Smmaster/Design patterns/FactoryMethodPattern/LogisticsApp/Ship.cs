using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.FactoryMethodPattern.LogisticsApp
{
    // Concrete Product - Ship
    public class Ship : ITransport
    {
        public string TransportType { get; private set; }
        public int Capacity { get; private set; }
        public int Speed { get; private set; }

        public Ship()
        {
            TransportType = "Ship";
            Capacity = 200000; // Capacity in kilograms
            Speed = 30;        // Speed in knots
        }

        public void Deliver()
        {
            Console.WriteLine($"Delivering by {TransportType} with a capacity of {Capacity} kg at {Speed} knots.");
        }
    }
}
