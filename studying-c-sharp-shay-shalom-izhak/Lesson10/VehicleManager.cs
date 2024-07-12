using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson10
{
    public class VehicleManager
    {
        public List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            Console.WriteLine($"Added: {vehicle.Make} {vehicle.Model}");
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            if (vehicles.Remove(vehicle))
            {
                Console.WriteLine($"Removed: {vehicle.Make} {vehicle.Model}");
            }
            else
            {
                Console.WriteLine($"Vehicle not found: {vehicle.Make} {vehicle.Model}");
            }
        }

        public void DisplayAllVehicles()
        {
            Console.WriteLine("All Vehicles:");
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
            }
        }
    }
}
