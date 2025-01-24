using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Ran_Object_Oriented.Car_App
{
    public class CarManngerApp
    {
        public const int MAX_NUM_OF_CARS = 300;
        public Veichle[] cars;
        public int currentCarCount;

        public CarManngerApp()
        {
            this.cars = new Veichle[MAX_NUM_OF_CARS];
            this.currentCarCount = 0;
        }

        // Count the number of vehicles and cars
        public void CountObjectsInTheArray()
        {
            int veichleCount = 0;
            int carCount = 0;

            for (int i = 0; i < currentCarCount; i++)
            {
                if (cars[i] is Car)
                {
                    carCount++;
                }
                else
                {
                    veichleCount++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Total Cars: {carCount}, Total Vehicles (excluding cars): {veichleCount}");
            Console.ResetColor();
        }

        // Add a vehicle or car to the array
        public void AddCar(Veichle carOrVeichle)
        {
            if (currentCarCount >= MAX_NUM_OF_CARS)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have reached the car storing limit!");
                Console.ResetColor();
            }
            else
            {
                cars[currentCarCount] = carOrVeichle;
                currentCarCount++;
            }
        }

        // Remove vehicle or car from the array
        public void RemoveCar(int CarId)
        {
            if (currentCarCount == 0)
            {
                Console.WriteLine("there is zero car stored!");
                return;
            }
            else
            {
                for (int i = 0;i < currentCarCount;i++)
                {
                    if (cars[i] != null && cars[i].GetId() == CarId)
                    {
                        // Swap the car to remove with the last car in the array
                        cars[i] = cars[currentCarCount - 1];
                        cars[currentCarCount - 1] = null;

                        // Decrement the car count
                        currentCarCount--;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Car with the ID ({CarId}) was successfully removed!");
                        Console.ResetColor();
                        return;
                    }
                }

            }

        }

        // Get the vehicle with the maximum price
        public Veichle GetMaxPricedVeichle()
        {
            if (currentCarCount == 0)
            {
                // if the editor is entering the block throw this erorr!!!!
                throw new InvalidOperationException("No vehicles in the manager.");
            }

            Veichle maxPricedVehicle = cars[0];

            for (int i = 1; i < currentCarCount; i++)
            {
                if (cars[i].GetPrice() > maxPricedVehicle.GetPrice())
                {
                    maxPricedVehicle = cars[i];
                }
            }

            return maxPricedVehicle;
        }
    }

    public class RunCarManngerApp
    {
        public static void DemoMain()
        {
            // Create an instance of CarManngerApp
            CarManngerApp manager = new CarManngerApp();

            // Create some vehicles and cars
            Veichle v1 = new Veichle("mazda3", "mazda", 30000);
            Veichle v2 = new Veichle("mazda2", "mazda", 45000);
            Car v3 = new Car("mazda2", "mazda", 40000, 4, 4);
            Veichle v4 = new Car("mazda6", "mazda", 70000, 4, 4);
            Veichle v5 = new Car("mazda2", "mazda", 40000, 4, 4);
            // Add vehicles to the manager
            manager.AddCar(v1);
            manager.AddCar(v2);
            manager.AddCar(v3);
            manager.AddCar(v4);

            // Display all vehicles stored in the manager
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < manager.currentCarCount; i++)
            {
                Console.WriteLine(manager.cars[i]);
            }
            Console.ResetColor();

            // Count objects in the array
            manager.CountObjectsInTheArray();
            manager.AddCar(v5);

            manager.RemoveCar(3);
            Console.WriteLine("---------");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < manager.currentCarCount; i++)
            {
                Console.WriteLine(manager.cars[i]);
            }
            Console.ResetColor();

            // Find and display the maximum priced vehicle
            Veichle maxPricedVehicle = manager.GetMaxPricedVeichle();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The vehicle with the highest price is: {maxPricedVehicle}");
            Console.ResetColor();
        }
    }
}
