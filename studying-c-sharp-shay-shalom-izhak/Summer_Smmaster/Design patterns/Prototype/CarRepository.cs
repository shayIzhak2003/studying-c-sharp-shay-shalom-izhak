using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Prototype
{
    public class CarRepository
    {
        private List<Car> cars = new List<Car>();

        // Add a new car
        public void AddCar(Car car)
        {
            cars.Add(car);
            Console.WriteLine($"Car added: {car}");
        }

        // Update an existing car
        public void UpdateCar(int index, Car updatedCar)
        {
            if (index >= 0 && index < cars.Count)
            {
                cars[index] = updatedCar;
                Console.WriteLine($"Car at index {index} updated to: {updatedCar}");
            }
            else
            {
                Console.WriteLine("Invalid index. Car not found.");
            }
        }

        // Delete a car by index
        public void DeleteCar(int index)
        {
            if (index >= 0 && index < cars.Count)
            {
                Console.WriteLine($"Car deleted: {cars[index]}");
                cars.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index. Car not found.");
            }
        }

        // Clone a car by index and add the cloned car to the list
        public void CloneCar(int index)
        {
            if (index >= 0 && index < cars.Count)
            {
                Car clonedCar = (Car)cars[index].Clone();
                cars.Add(clonedCar);
                Console.WriteLine($"Car cloned: {clonedCar}");
            }
            else
            {
                Console.WriteLine("Invalid index. Car not found.");
            }
        }

        // List all cars
        public void ListCars()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("No cars available.");
            }
            else
            {
                Console.WriteLine("Listing all cars:");
                for (int i = 0; i < cars.Count; i++)
                {
                    Console.WriteLine($"{i}: {cars[i]}");
                }
            }
        }
    }
}
