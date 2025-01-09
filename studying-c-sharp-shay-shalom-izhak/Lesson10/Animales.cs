using studying_c_sharp_shay_shalom_izhak.Lesson6.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson10
{
    public class Animales
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsPredator { get; set; }
        public int CaloriesPerMeal { get; set; }

        public Animales(string name, int age, bool isPredator, int caloriesPerMeal)
        {
            this.Name = name;
            this.Age = age;
            this.IsPredator = isPredator;
            this.CaloriesPerMeal = caloriesPerMeal;
        }
        public virtual int Eat()
        {
            return this.CaloriesPerMeal * 3;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Is Predator: {IsPredator}, Calories Per Meal: {CaloriesPerMeal}";
        }
    }
    public class Mammal : Animales
    {
        public int MilkCalories { get; set; }
        public int PregnancyMonths { get; set; }

        public Mammal(string name, int age, bool isPredator, int caloriesPerMeal, int milkCalories, int pregnancyMonths)
            : base(name, age, isPredator, caloriesPerMeal)
        {
            MilkCalories = milkCalories;
            PregnancyMonths = pregnancyMonths;
        }
        public override int Eat()
        {
            return base.Eat() + MilkCalories;
        }

        public override string ToString()
        {
            return base.ToString() + $", Milk Calories: {MilkCalories}, Pregnancy Months: {PregnancyMonths}";
        }
    }
    public class Reptile : Animales
    {
        public double TailLength { get; set; }

        public Reptile(string name, int age, bool isPredator, int caloriesPerMeal, double tailLength)
            : base(name, age, isPredator, caloriesPerMeal)
        {
            TailLength = tailLength;
        }

        public override string ToString()
        {
            return base.ToString() + $", Tail Length: {TailLength}";
        }
    }

    public class Bird : Animales
    {
        public double FlightHeight { get; set; }
        public double WingSpan { get; set; }

        public Bird(string name, int age, bool isPredator, int caloriesPerMeal, double flightHeight, double wingSpan)
            : base(name, age, isPredator, caloriesPerMeal)
        {
            FlightHeight = flightHeight;
            WingSpan = wingSpan;
        }

        public override string ToString()
        {
            return base.ToString() + $", Flight Height: {FlightHeight}, Wing Span: {WingSpan}";
        }
    }

    public class Cow : Mammal
    {
        public int NumberOfCalves { get; set; }

        public Cow(string name, int age, bool isPredator, int caloriesPerMeal, int milkCalories, int pregnancyMonths, int numberOfCalves)
            : base(name, age, isPredator, caloriesPerMeal, milkCalories, pregnancyMonths)
        {
            NumberOfCalves = numberOfCalves;
        }

        public override int Eat()
        {
            return base.Eat() / 4; 
        }

        public override string ToString()
        {
            return base.ToString() + $", Number Of Calves: {NumberOfCalves}";
        }
    }

    public class Hipo : Mammal
    {
        public double FatPercentage { get; set; }

        public Hipo(string name, int age, bool isPredator, int caloriesPerMeal, int milkCalories, int pregnancyMonths, double fatPercentage)
            : base(name, age, isPredator, caloriesPerMeal, milkCalories, pregnancyMonths)
        {
            FatPercentage = fatPercentage;
        }

        public override string ToString()
        {
            return base.ToString() + $", Fat Percentage: {FatPercentage}";
        }
    }

    public class Crocodile : Reptile
    {
        public bool HasDentalTreatment { get; set; }

        public Crocodile(string name, int age, bool isPredator, int caloriesPerMeal, double tailLength, bool hasDentalTreatment)
            : base(name, age, isPredator, caloriesPerMeal, tailLength)
        {
            HasDentalTreatment = hasDentalTreatment;
        }

        public override string ToString()
        {
            return base.ToString() + $", Has Dental Treatment: {HasDentalTreatment}";
        }
    }

    public class Snake : Reptile
    {
        public bool IsVenomous { get; set; }

        public Snake(string name, int age, bool isPredator, int caloriesPerMeal, double tailLength, bool isVenomous)
            : base(name, age, isPredator, caloriesPerMeal, tailLength)
        {
            IsVenomous = isVenomous;
        }

        public override string ToString()
        {
            return base.ToString() + $", Is Venomous: {IsVenomous}";
        }
    }
    //part 2
    public class Parrot : Bird
    {
        public string FeatherColor { get; set; }

        public Parrot(string name, int age, bool isPredator, int caloriesPerMeal, double flightHeight, double wingSpan, string featherColor)
            : base(name, age, isPredator, caloriesPerMeal, flightHeight, wingSpan)
        {
            FeatherColor = featherColor;
        }

        public override string ToString()
        {
            return base.ToString() + $", Feather Color: {FeatherColor}";
        }
    }
    public class DairyCow : Cow
    {
        public double MilkProduction { get; set; } // liters per day

        public DairyCow(string name, int age, bool isPredator, int caloriesPerMeal, int milkCalories, int pregnancyMonths, int numberOfCalves, double milkProduction)
            : base(name, age, isPredator, caloriesPerMeal, milkCalories, pregnancyMonths, numberOfCalves)
        {
            MilkProduction = milkProduction;
        }

        public override string ToString()
        {
            return base.ToString() + $", Milk Production: {MilkProduction} liters/day";
        }
    }


}
