using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson6.Lesson6_Home__Work
{
    public class Objects
    {
        // Parent class
        public class Parent
        {
            private string Name;
            private int Age;

            public string GetName() => this.Name;
            public void SetName(string name) => this.Name = name;

            public int GetAge() => this.Age;
            public void SetAge(int age) => this.Age = age;

            public Parent(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        // Child class 1
        public class Child1 : Parent
        {
            private string Hobby;
            private int Grade;

            public string GetHobby() => this.Hobby;
            public void SetHobby(string hobby) => this.Hobby = hobby;

            public int GetGrade() => this.Grade;
            public void SetGrade(int grade) => this.Grade = grade;

            public Child1(string name, int age, string hobby, int grade)
                : base(name, age)
            {   
                Hobby = hobby;
                Grade = grade;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Hobby: {Hobby}, Grade: {Grade}");
            }

            public void DisplayHobby()
            {
                Console.WriteLine($"{this.GetName()}'s hobby is {Hobby}");
            }
        }

        // Child class 2
        public class Child2 : Parent
        {
            public string FavoriteSubject { get; set; }
            public string BestFriend { get; set; }

            public Child2(string name, int age, string favoriteSubject, string bestFriend)
                : base(name, age)
            {
                FavoriteSubject = favoriteSubject;
                BestFriend = bestFriend;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Favorite Subject: {FavoriteSubject}, Best Friend: {BestFriend}");
            }

            public void DisplayBestFriend()
            {
                Console.WriteLine($"{this.GetName()}'s best friend is {BestFriend}");
            }
        }

        // Child class 3
        public class Child3 : Parent
        {
            public string FavoriteSport { get; set; }
            public string DreamJob { get; set; }

            public Child3(string name, int age, string favoriteSport, string dreamJob)
                : base(name, age)
            {
                FavoriteSport = favoriteSport;
                DreamJob = dreamJob;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Favorite Sport: {FavoriteSport}, Dream Job: {DreamJob}");
            }

            public void DisplayDreamJob()
            {
                Console.WriteLine($"{this.GetName()}'s dream job is {DreamJob}");
            }
        }
    }
}
