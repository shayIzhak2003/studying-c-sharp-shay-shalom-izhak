using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson10
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public VehicleType Type { get; set; }

        public Vehicle(string make, string model, int year, VehicleType type)
        {
            Make = make;
            Model = model;
            Year = year;
            Type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Type: {Type}");
        }
    }
    public class RunVehicle
    {
        public static void DemoMain()
        {
            Vehicle car = new Vehicle("Toyota", "Camry", 2020, VehicleType.Car);
            Vehicle motorcycle = new Vehicle("Harley-Davidson", "Iron 883", 2021, VehicleType.Motorcycle);
            Vehicle bus = new Vehicle("Mercedes-Benz", "Citaro", 2018, VehicleType.Bus);

            car.DisplayInfo();
            motorcycle.DisplayInfo();
            bus.DisplayInfo();
        }
    }
}
