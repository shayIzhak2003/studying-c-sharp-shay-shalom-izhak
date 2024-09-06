using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.FactoryMethodPattern.LogisticsApp
{
    // Product interface - Transport
    public interface ITransport
    {
        string TransportType { get; }
        int Capacity { get; }
        int Speed { get; }
        void Deliver();
    }
}
