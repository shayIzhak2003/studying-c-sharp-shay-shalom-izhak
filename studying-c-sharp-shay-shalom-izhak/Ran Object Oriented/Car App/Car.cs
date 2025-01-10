using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Ran_Object_Oriented.Car_App
{
    public class Car : Veichle
    {
        private int numOfDoors;
        private int numOfWheels;

        public Car(string name, string manufacture, int price, int numOfDoors, int numOfWheels) :
            base( name,  manufacture, price)
        {
            this.numOfDoors = numOfDoors;
            this.numOfWheels = numOfWheels;
        }


        // Getter and Setter for numOfDoors
        public int GetNumOfDoors()
        {
            return this.numOfDoors;
        }

        public void SetNumOfDoors(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Number of doors cannot be negative.");
            }
            this.numOfDoors = value;
        }

        // Getter and Setter for numOfWheels
        public int GetNumOfWheels()
        {
            return this.numOfWheels;
        }

        public void SetNumOfWheels(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Number of wheels cannot be negative.");
            }
           this.numOfWheels = value;
        }

        public override string ToString()
        {
            return base.ToString() + $"num of wheels: {this.GetNumOfWheels()}, num of doors: {this.GetNumOfDoors()}";
        }

    }
}
