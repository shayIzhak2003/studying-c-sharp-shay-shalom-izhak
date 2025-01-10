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

        // Constructor
        public CarManngerApp()
        {
            this.cars = new Car[MAX_NUM_OF_CARS];
            this.currentCarCount = 0;
        }

        // a function that prints the count of veichle and card objects count...

        public void CountObjectsInTheArray()
        {
            int veichleCount = 0;
            int carCount = 0;
            for (int i = 0; i < cars.Length; i++)
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
        }

        // adding car function
        public void AddCar(Veichle carOrVeichle)
        {
            if (currentCarCount >= MAX_NUM_OF_CARS)
            {
                Console.WriteLine("you have reached to the car storing limit!!!");
            }
            else
            {
                cars[currentCarCount] = carOrVeichle;
                currentCarCount++;
            }
        }

        //Gettning max priced Veichle in the array function
        public object GetMaxPricedVeichle()
        {
            int maxPricedObject = cars[0].GetPrice();

            foreach(var car in cars)
            {
                if(car.GetPrice() > maxPricedObject)
                {
                    maxPricedObject = car.GetPrice();
                }
            }
            return maxPricedObject;
        }
    }
}
