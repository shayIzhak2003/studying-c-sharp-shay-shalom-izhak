using System;

namespace c_sharp_basics_lingar.object_basics
{
    public class ThisKeyword
    {
        public static void DoDiscount(Phone phone)
        {
            // Apply discount
            phone.price *= 0.9;
        }

        public static string TheBestOffer(Phone[] arr, string name, double offer)
        {
            double minPrice = double.MaxValue;
            Phone bestPhone = null;

            for (int i = 0; i < arr.Length; i++)
            {
                double discountedPrice = arr[i].price * (1 - offer);
                if (discountedPrice < minPrice)
                {
                    minPrice = discountedPrice;
                    bestPhone = arr[i];
                }
            }

            if (bestPhone != null)
            {
                return $"The best offer for {name} is {bestPhone.color} phone with a price of {minPrice:F2}.";
            }
            else
            {
                return "No phones available for the offer.";
            }
        }

        public static void Demo()
        {
            Phone p = new Phone("black", 20);
            Console.WriteLine("color = " + p.color + "|price = " + p.price);
            Phone p2 = new Phone();
            Console.WriteLine("color = " + p2.color + "|price = " + p2.price);
            Phone p3 = new Phone(200);
            Console.WriteLine("color = " + p3.color + "|price = " + p3.price);
            Console.WriteLine();

            p.DoCount();
            p2.DoCount();
            p3.DoCount();

            Console.WriteLine("price after discount:");
            Console.WriteLine("color = " + p.color + "|price = " + p.price);
            Console.WriteLine("color = " + p2.color + "|price = " + p2.price);
            Console.WriteLine("color = " + p3.color + "|price = " + p3.price);
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
        public string color = "white";
        public double price = 0;

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



