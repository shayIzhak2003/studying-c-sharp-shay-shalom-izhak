using studying_c_sharp_shay_shalom_izhak.Lesson6.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson8.Casting
{
    public class Animals1
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    public class Dog : Animals1
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }

    public class Cat : Animals1
    {
        public void Meow()
        {
            Console.WriteLine("Cat is meowing");
        }
    }

    public class RunAnimals1
    {
        public static void Run()
        {
            // Upcasting: Dog to Animals1
            Dog myDog = new Dog();
            Animals1 animal = myDog; // Upcasting

            // Downcasting: Animals1 to Cat (handling without throwing exceptions)
            Animals1 someAnimal = new Cat(); // Upcasted Cat to Animals1

            if (someAnimal is Dog)
            {
                Dog dog = (Dog)someAnimal; // This won't execute because someAnimal is not Dog
                dog.Bark();
            }
            else if (someAnimal is Cat)
            {
                Cat cat = (Cat)someAnimal; // Downcasting to Cat
                cat.Meow();
            }
            else
            {
                Console.WriteLine("Cannot cast someAnimal to Cat");
            }
        }
    }
}



