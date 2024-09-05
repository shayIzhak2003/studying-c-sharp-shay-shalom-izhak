using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex
{
    public class Fruit
    {
        protected int weight;

        public Fruit(int val)
        {
            weight = val;
        }

        public int GetWeight()
        {
            return weight;
        }
    }

    public class Apple : Fruit
    {
        private string color;

        public Apple(int val, string col) : base(val)
        {
            color = col;
        }

        public string GetColor()
        {
            return color;
        }

        public bool ValidWeight()
        {
            return weight > 80 && weight < 140;
        }
    }
    public class RunFruit
    {
        public static void CountObjectTypes(object[] objects)
        {
            int appleCount = 0;
            int fruitNotAppleCount = 0;
            int notFruitCount = 0;


            for(int i = 0; i < objects.Length; i++)
            {
               object obj = objects[i];
                if (obj is Apple)
                {
                    appleCount++;
                }
                else if (obj is Fruit)
                {
                    fruitNotAppleCount++;
                }
                else
                {
                    notFruitCount++;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"apple count = {appleCount}");
            Console.WriteLine($"fruit count = {fruitNotAppleCount}");
            Console.WriteLine($"nither count = {notFruitCount}");
            Console.ResetColor();
        }
        public static void DemoMain()
        {
            object[] objects = new object[]
    {
            new Apple(100, "Red"),
            new Apple(120, "Green"),
            new Fruit(90),
            new Fruit(110),
            new Apple(85, "Yellow"),
            new object() // This is just a generic object, not a Fruit or Apple
    };

            // Call the method to count and print the types of objects
            CountObjectTypes(objects);


        }
    }

}
