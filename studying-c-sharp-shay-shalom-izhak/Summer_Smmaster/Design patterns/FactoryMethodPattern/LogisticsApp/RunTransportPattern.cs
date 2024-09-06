using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.FactoryMethodPattern.LogisticsApp
{
    public class RunTransportPattern
    {
        public static void DemoMain()
        {
            // Choose a logistics method based on input
            Logistics logistics;

            Console.WriteLine("Enter 'road', 'sea', or 'air' to choose a delivery method:");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "road":
                    logistics = new RoadLogistics();
                    break;
                case "sea":
                    logistics = new SeaLogistics();
                    break;
                case "air":
                    logistics = new AirLogistics();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to road logistics.");
                    logistics = new RoadLogistics();
                    break;
            }

            // Plan and execute the delivery
            logistics.PlanDelivery();
        }
    }
}
