using studying_c_sharp_shay_shalom_izhak.Lesson6.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson7.Virtual___Ovveride
{
    public class Animal2
    {
        // Virtual method
        public virtual void MakeSound()
        {
            Console.WriteLine("Some sound");
        }
    }

    public class Dog : Animal2
    {
        // Override method
        public override void MakeSound()
        {
            Console.WriteLine("Bark bark!");
        }
    }

    public class Cat : Animal2
    {
        // Override method
        public override void MakeSound()
        {
            Console.WriteLine("Meow meow!");
        }
    }

    public class Bird : Animal2
    {
        // Override method
        public override void MakeSound()
        {
            Console.WriteLine("Tweet tweet!");
        }
    }

    public class RunAnimal2
    {
        public static void RunDemo()
        {
            Animal2 animal1 = new Dog();
            Animal2 animal2 = new Cat();
            Animal2 animal3 = new Bird();

            animal1.MakeSound(); // Outputs: Bark bark!
            animal2.MakeSound(); // Outputs: Meow meow!
            animal3.MakeSound(); // Outputs: Tweet tweet!

            Console.ReadLine();
        }
    }
}
