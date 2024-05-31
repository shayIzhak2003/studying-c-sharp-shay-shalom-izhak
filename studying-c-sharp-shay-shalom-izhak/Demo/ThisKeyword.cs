using System;

namespace c_sharp_basics_lingar.object_basics
{
    public class ThisKeyword
    {
        public static void DoDiscount(Phone phone)
        {
            // Apply discount
            phone.SetPrice(phone.GetPrice() * 0.9);
        }

        public static string TheBestOffer(Phone[] arr, string name, double offer)
        {
            double minPrice = double.MaxValue;
            Phone bestPhone = null;

            for (int i = 0; i < arr.Length; i++)
            {
                double discountedPrice = arr[i].GetPrice() * (1 - offer);
                if (discountedPrice < minPrice)
                {
                    minPrice = discountedPrice;
                    bestPhone = arr[i];
                }
            }

            if (bestPhone != null)
            {
                return $"The best offer for {name} is {bestPhone.GetColor()} phone with a price of {minPrice:F2}.";
            }
            else
            {
                return "No phones available for the offer.";
            }
        }

        public static void Demo()
        {
            Phone p = new Phone("black", 20);
            Console.WriteLine("color = " + p.GetColor() + "|price = " + p.GetColor());
            Phone p2 = new Phone();
            Console.WriteLine("color = " + p2.GetColor() + "|price = " + p2.GetColor());
            Phone p3 = new Phone(200);
            Console.WriteLine("color = " + p3.GetColor() + "|price = " + p3.GetColor());
            Console.WriteLine();

            p.DoCount();
            p2.DoCount();
            p3.DoCount();

            Console.WriteLine("price after discount:");
            Console.WriteLine("color = " + p.GetColor() + "|price = " + p.GetColor());
            Console.WriteLine("color = " + p2.GetColor() + "|price = " + p2.GetColor());
            Console.WriteLine("color = " + p3.GetColor() + "|price = " + p3.GetColor());
            Console.WriteLine();

            Phone[] phones = { p, p2, p3 };
            double maxPrice = p.MaxInPrice(phones);
            Console.WriteLine("Max price among phones: " + maxPrice);

            double minPriceForColor = p.MinInColor(phones, "orange");
            Console.WriteLine("Min price among phones with color orange: " + minPriceForColor);

            string bestOffer = ThisKeyword.TheBestOffer(phones, "Special Offer", 0.2);
            Console.WriteLine(bestOffer);
        }
    }

    public class Phone
    {
        private string color = "white";
        private double price = 0;


        public string GetColor()
        {
            return this.color;
        }
        public void SetColor(string color)
        {
             this.color = color;
        }

        public double GetPrice()
        {
            return this.price;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public Phone(string color, double price)
        {
            // Assign parameters to instance variables
            this.color = color;
            this.price = price;
        }

        public Phone() : this("orange", 205.06)
        {
        }

        public Phone(double d) : this("orange", d)
        {
        }

        public Phone(int d) : this("red", d)
        {
        }

        public void DoCount()
        {
            ThisKeyword.DoDiscount(this);
        }

        public void Display()
        {
            Console.WriteLine("Price = " + this.price);
            Console.WriteLine("color = " + this.color);
        }

        public double MaxInPrice(Phone[] arr)
        {
            double max = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].price > max)
                {
                    max = arr[i].price;
                }
            }
            return max;
        }

        public double MinInColor(Phone[] arr, string color)
        {
            double min = double.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].color == color && arr[i].price < min)
                {
                    min = arr[i].price;
                }
            }
            return min;
        }
        
    }
}



