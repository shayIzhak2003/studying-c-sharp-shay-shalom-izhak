using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson7
{

    public class ElectronicProduct
    {
        private string Brand;
        private string Model;
        private double Price;

        public string GetBrand()=> this.Brand;
        public string GetModel() => this.Model;
        public double GetPrice() => this.Price;

        public ElectronicProduct(string brand, string model, double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return($"Brand: {this.Brand}, Model: {this.Model}, Price: ${this.Price}");
        }
    }
    public class Screen : ElectronicProduct
    {
        private double Size;
        private string Resolution;
        private bool IsOled;

        public double GetSize() => this.Size;
        public string GetResolution() => this.Resolution;
        public bool GetIsOled() => this.IsOled;

        public Screen(string brand, string model, double price, double size, string resolution, bool isOled)
        : base(brand, model, price) // Correctly passing parameters to the base constructor
        {
            this.Size = size;
            this.Resolution = resolution;
            this.IsOled = isOled;
        }

        public override string ToString()
        {
            base.ToString();
            return($"Size: {this.Size} inches, Resolution: {this.Resolution}, OLED: {this.IsOled}");
        }
    }
    public class Tv : Screen
    {
        private string PlaceOfMade;
        private string Position;

        public string GetPosition() => this.Position;
        public string GetPlaceOfMade() => this.PlaceOfMade;

        public Tv(string brand, string model, double price, double size, string resolution, bool isOled, string placeOfMade, string position)
         :base(brand, model, price, size, resolution, isOled)
        {
            this.PlaceOfMade = placeOfMade;
            this.Position = position;
        }

        public override string ToString()
        {
            
            return ($"place of made :{base.ToString()} - {this.PlaceOfMade} , Tv Position : {this.Position}");
        }
    }

}
