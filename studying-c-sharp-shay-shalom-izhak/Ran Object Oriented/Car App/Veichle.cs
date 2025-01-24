using studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.Product_Manngement_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Ran_Object_Oriented.Car_App
{
    public class Veichle
    {
        private string name;
        public static int PublicId = 0;
        private int id = PublicId++;
        private string manufacture;
        private int price;

        public Veichle(string name , string manufacture, int price)
        {
            this.name = name;
            this.manufacture = manufacture;
            this.price = price;
            this.id = PublicId;
        }

        // getters and setters functions

        // Getter and Setter for Name
        public string GetName()
        {
            return this.name;
        }

        public void SetName(string value)
        {
            this.name = value;
        }

        // Getter and Setter for Id
        public int GetId()
        {
            return this.id;
        }

        public void SetId(int value)
        {
            if (value > 0) // Ensure the ID is positive
            {
                this.id = value;
            }
            else
            {
                throw new ArgumentException("ID must be greater than 0.");
            }
        }

        // Getter and Setter for Manufacture
        public string GetManufacture()
        {
            return this.manufacture;
        }

        public void SetManufacture(string value)
        {
            this.manufacture = value;
        }

        // Getter and Setter for Price
        public int GetPrice()
        {
            return this.price;
        }

        public void SetPrice(int value)
        {
            if (value >= 0) // Ensure the price is non-negative
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException("Price cannot be negative.");
            }

            // במהט תרשום 
            //this.price = value
        }

        public override string ToString()
        {
            return $"name: {this.GetName()}, price: {this.GetPrice()}, id: {this.GetId()}, manufacture: {this.GetManufacture()}";
        }



    }
}
