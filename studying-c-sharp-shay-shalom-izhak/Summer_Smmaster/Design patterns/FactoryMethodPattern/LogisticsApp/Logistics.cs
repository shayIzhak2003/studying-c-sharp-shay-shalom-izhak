using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.FactoryMethodPattern.LogisticsApp
{
    public abstract class Logistics
    {
        // Factory method
        public abstract ITransport CreateTransport();

        // An operation that uses the factory method
        public void PlanDelivery()
        {
            // Call the factory method to create a transport
            ITransport transport = CreateTransport();
            transport.Deliver();
        }
    }

}
