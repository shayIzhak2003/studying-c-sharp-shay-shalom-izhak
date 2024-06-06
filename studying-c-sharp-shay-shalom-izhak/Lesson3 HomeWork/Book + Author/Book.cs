using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson3_HomeWork.Book___Author
{
    public class Book
    {
        #region

        private string name;
        private Author author;
        private int Qty;
        private double price;

        public Book() : this("client", new Author(), 3, 300.99)
        { }
        public Book(string name, Author author, int qty, double price)
        {
            this.name = name;
            this.author = author;
            this.Qty = qty;
            this.price = price;
        }
        public string GetName()
        {
            return this.name;
        }
        public Author GetAuthor()
        {
            return this.author;
        }
        public double GetPrice()
        {
            return this.price;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public int GetQty()
        {
            return this.Qty;
        }

        public void SetQty(int qty)
        {
            this.Qty = qty;
        }
        public override string ToString()
        {
            return $"$Book[name = {this.name}, Author[name={this.author.GetName()}, email ={this.author.GetEmail()}, " +
                $"gender ={this.author.GetGender()}] price={this.price}, qty={this.Qty}]";
        }

        #endregion
    }

    public class TestBook
    {
        public static void RunBook()
        {
           
            
                Author author1 = new Author("Shay Shalom", "shay@gmail.com", 'M');
                Author author2 = new Author("Jeniffer Lawrence", "jeniffer@gmail.com", 'F');

                Book book1 = new Book("C# Programming", author1, 10, 99.99);
                Book book2 = new Book("Java Programming", author2, 5, 59.99);
                Book book3 = new Book("Python Programming", author1, 7, 89.99);

                Console.WriteLine(book1.ToString());
                Console.WriteLine(book2.ToString());
                Console.WriteLine(book3.ToString());

                // Update some properties
                book1.SetPrice(89.99);
                book1.SetQty(15);
                Console.WriteLine("\nAfter updating book1 details:");
                Console.WriteLine(book1.ToString());

                book2.SetPrice(49.99);
                book2.SetQty(8);
                Console.WriteLine("\nAfter updating book2 details:");
                Console.WriteLine(book2.ToString());
            
        }
    }

}
