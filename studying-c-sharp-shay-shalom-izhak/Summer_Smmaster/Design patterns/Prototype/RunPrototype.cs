using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Prototype
{
    public class RunPrototype
    {
        public static void DemoMain() 
        {
            CarRepository carRepo = new CarRepository();

            // Adding cars
            carRepo.AddCar(new Car("Toyota", "Camry", 2022, "White"));
            carRepo.AddCar(new Car("Ford", "Mustang", 2021, "Red"));

            Console.WriteLine();
            carRepo.ListCars();

            // Update a car
            carRepo.UpdateCar(0, new Car("Toyota", "Corolla", 2023, "Blue"));

            Console.WriteLine();
            carRepo.ListCars();

            // Clone a car
            carRepo.CloneCar(1);

            Console.WriteLine();
            carRepo.ListCars();

            // Delete a car
            carRepo.DeleteCar(0);

            Console.WriteLine();
            carRepo.ListCars();
        }
    }
}
