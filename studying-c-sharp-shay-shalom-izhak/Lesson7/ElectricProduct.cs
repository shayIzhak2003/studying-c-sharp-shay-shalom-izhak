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

        // Public getters for private fields
        public string GetBrand() => this.Brand;
        public string GetModel() => this.Model;
        public double GetPrice() => this.Price;

        // Constructor
        public ElectronicProduct(string brand, string model, double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

        // Overriding ToString method
        public override string ToString()
        {
            return $"Brand: {this.Brand}, Model: {this.Model}, Price: ${this.Price}";
        }
    }

    public class Screen : ElectronicProduct
    {
        private double Size;
        private string Resolution;
        private bool IsOled;

        // Public getters for private fields
        public double GetSize() => this.Size;
        public string GetResolution() => this.Resolution;
        public bool GetIsOled() => this.IsOled;

        // Constructor
        public Screen(string brand, string model, double price, double size, string resolution, bool isOled)
            : base(brand, model, price) // Passing parameters to the base constructor
        {
            this.Size = size;
            this.Resolution = resolution;
            this.IsOled = isOled;
        }

        // Overriding ToString method
        public override string ToString()
        {
            // Properly chaining the base class's ToString method
            return $"{base.ToString()}, Size: {this.Size} inches, Resolution: {this.Resolution}, OLED: {this.IsOled}";
        }
    }

    public class Tv : Screen
    {
        private string PlaceOfMade;
        private string Position;

        // Public getters for private fields
        public string GetPosition() => this.Position;
        public string GetPlaceOfMade() => this.PlaceOfMade;

        // Constructor
        public Tv(string brand, string model, double price, double size, string resolution, bool isOled, string placeOfMade, string position)
            : base(brand, model, price, size, resolution, isOled) // Passing parameters to the base constructor
        {
            this.PlaceOfMade = placeOfMade;
            this.Position = position;
        }

        // Overriding ToString method
        public override string ToString()
        {
            // Properly chaining the base class's ToString method
            return $"{base.ToString()}, Place of Manufacture: {this.PlaceOfMade}, Position: {this.Position}";
        }
    }

    public class PlayStation : ElectronicProduct
    {
        private int StorageCapacity;
        private string ModelSeries;
        private bool IsVrCompatible;

        // Public getters for private fields
        public int GetStorageCapacity() => this.StorageCapacity;
        public string GetModelSeries() => this.ModelSeries;
        public bool GetIsVrCompatible() => this.IsVrCompatible;

        // Constructor
        public PlayStation(string brand, string model, double price, int storageCapacity, string modelSeries, bool isVrCompatible)
            : base(brand, model, price) // Passing parameters to the base constructor
        {
            this.StorageCapacity = storageCapacity;
            this.ModelSeries = modelSeries;
            this.IsVrCompatible = isVrCompatible;
        }

        // Method to display storage capacity in GB or TB
        public string DisplayStorageCapacity()
        {
            return StorageCapacity >= 1000 ? $"{StorageCapacity / 1000.0} TB" : $"{StorageCapacity} GB";
        }

        // Overriding ToString method
        public override string ToString()
        {
            return $"{base.ToString()}, Storage Capacity: {DisplayStorageCapacity()}, Model Series: {this.ModelSeries}, VR Compatible: {this.IsVrCompatible}";
        }
    }


}
