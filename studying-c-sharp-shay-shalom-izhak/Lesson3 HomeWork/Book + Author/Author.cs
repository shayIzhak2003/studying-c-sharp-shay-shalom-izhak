using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson3_HomeWork.Book___Author
{
    public class Author
    {
        #region

        private string Name;
        private string Email;
        private char Gender;

        public Author() : this("user", "user@gmail.com", 'M')
        { }

        public Author(string name, string email, char gender)
        {
            this.Name = name;
            this.Email = email;
            if (gender != 'M' && gender != 'F')
            {
                throw new ArgumentException("The gender can only be 'M' or 'F'!");
            }
            else
            {
                this.Gender = gender;
            }
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public char GetGender()
        {
            return this.Gender;
        }

        public void SetGender(char gender)
        {
            if (gender != 'M' && gender != 'F')
            {
                throw new ArgumentException("The gender can only be 'M' or 'F'!");
            }
            this.Gender = gender;
        }

        public void SetEmail(string email)
        {
            this.Email = email;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Author: [Name: {this.Name}, Email: {this.Email}, Gender: {this.GetGender()}]";
        }

        public static int CountMale(Author[] arr)
        {
            int countM = 0;
            foreach (Author a in arr)
            {
                if (a.GetGender() == 'M')
                    countM++;
            }
            return countM;
        }

        public static int CountFemale(Author[] arr)
        {
            int countF = 0;
            foreach (Author a in arr)
            {
                if (a.GetGender() == 'F')
                    countF++;
            }
            return countF;
        }

        #endregion
    }

    public class TestAuthor
    {
        public static void RunAuthor()
        {
            Author[] arr = new Author[3];
            arr[0] = new Author();
            arr[1] = new Author("Shay", "shay@gmail.com", 'M');
            arr[2] = new Author("Jeniffer", "jeniffer@gmail.com", 'F');
            // Uncommenting the next line will throw an exception due to invalid gender
            // arr[3] = new Author("Jeniffer", "jeniffer@gmail.com", 'J');

            foreach (Author a in arr)
            {
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine($"\nThe number of males is: {Author.CountMale(arr)}");
            Console.WriteLine($"\nThe number of females is: {Author.CountFemale(arr)}");
        }
    }
}
