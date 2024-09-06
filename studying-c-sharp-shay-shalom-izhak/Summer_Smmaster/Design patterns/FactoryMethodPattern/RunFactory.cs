using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.FactoryMethodPattern
{
    public class RunFactory
    {
        public static void DemoMain()
        {
            // Choose a factory based on input
            VehicleFactory factory;

            Console.WriteLine("Enter 'car', 'bike', or 'truck' to choose a vehicle:");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "car":
                    factory = new CarFactory();
                    break;
                case "bike":
                    factory = new BikeFactory();
                    break;
                case "truck":
                    factory = new TruckFactory();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to car.");
                    factory = new CarFactory();
                    break;
            }

            // Use the factory to create and deliver the vehicle
            factory.DeliverVehicle();
        }
    }
}
