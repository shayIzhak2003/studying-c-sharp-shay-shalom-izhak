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
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    public class Dog : Animals1
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }

    public class Cat : Animals1
    {
        public override void Eat()
        {
            Console.WriteLine("Cat is eating");
        }

        public void Meow()
        {
            Console.WriteLine("Cat is meowing");
        }
    }

    public class RunAnimals1
    {
        public static void Run()
        {
            // Create an instance of Animals1 directly
            Animals1 animalAsBase = new Animals1();
            Animals1 myDog = new Dog();
            ((Animals1)myDog).Eat();


            // Call the Eat method
            animalAsBase.Eat(); // Outputs "Animal is eating"

            // Check the type directly
            if (animalAsBase.GetType() == typeof(Animals1))
            {
                Console.WriteLine("animalAsBase is of type Animals1");
            }
            else
            {
                Console.WriteLine($"animalAsBase is actually of type {animalAsBase.GetType().Name}");
            }

            // Demonstrate casting with derived types
            Animals1 someAnimal = new Dog(); // Upcasted Dog to Animals1

            // Properly handle downcasting
            if (someAnimal is Dog downcastedDog)
            {
                downcastedDog.Bark();
            }
            else if (someAnimal is Cat downcastedCat)
            {
                downcastedCat.Meow();
            }
            else
            {
                Console.WriteLine("Cannot determine the specific type of someAnimal");
            }

            // Confirm type with a more detailed message
            Console.WriteLine($"someAnimal is actually of type {someAnimal.GetType().Name}");
        }
    }
}



