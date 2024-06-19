using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace studying_c_sharp_shay_shalom_izhak.OOP_DB_App
{
    public class ParntObjects
    {
        private string _name;
        private double _age;
        private double _balance;
        private int _CustomrId;

        // Public constructor to allow instantiation
        public ParntObjects(string name, double age, double balance, int customerId)
        {
            this._name = name;
            this._age = age;
            this._balance = balance;

            if (CheckCustIdValidation(customerId))
            {
                this._CustomrId = customerId;
            }
            else
            {
                throw new ArgumentException("The customer ID must be exactly 9 digits.");
            }
        }

        // Public getter methods
        public string GetName() => this._name;
        public double GetAge() => this._age;
        public double GetBalance() => this._balance;
        public int GetCustomerId() => this._CustomrId;

        // Public setter methods
        public void SetName(string name) => this._name = name;
        public void SetAge(double age) => this._age = age;
        public void SetBalance(double balance) => this._balance = balance;

        // Corrected method name and functionality
        public void SetCustomerId(int customerId)
        {
            if (CheckCustIdValidation(customerId))
            {
                this._CustomrId = customerId;
            }
            else
            {
                throw new ArgumentException("The customer ID must be exactly 9 digits.");
            }
        }

        // Validation method
        public bool CheckCustIdValidation(int custId)
        {
            string newStringFromInt = custId.ToString();
            if (newStringFromInt.Length != 9)
            {
                return false;
            }

            foreach (char digit in newStringFromInt)
            {
                if (!char.IsDigit(digit))
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class stockCusomers : ParntObjects
    {
        private double stockWorth;
        private int totalStocks;
        private ParntObjects[] amountOfCumtomers;

        // Constructor that invokes base class constructor and initializes additional properties
        public stockCusomers(
            string name,
            double age,
            double balance,
            int customerId,
            double stockWorth,
            int totalStocks,
            ParntObjects[] amountOfCumtomers)
            : base(name, age, balance, customerId)
        {
            this.stockWorth = stockWorth;
            this.totalStocks = totalStocks;
            this.amountOfCumtomers = amountOfCumtomers;
        }

        // Getter and setter methods for new properties
        public double GetStockWorth() => stockWorth;
        public void SetStockWorth(double value) => stockWorth = value;

        public int GetTotalStocks() => totalStocks;
        public void SetTotalStocks(int value) => totalStocks = value;

        public ParntObjects[] GetAmountOfCumtomers() => amountOfCumtomers;
        public void SetAmountOfCumtomers(ParntObjects[] customers) => amountOfCumtomers = customers;

        // Methods to add or remove customers
        public void AddCustomer(ParntObjects customer)
        {
            int newSize = amountOfCumtomers.Length + 1;
            Array.Resize(ref amountOfCumtomers, newSize);
            amountOfCumtomers[newSize - 1] = customer;
        }

        public void RemoveCustomer(int index)
        {
            if (index < 0 || index >= amountOfCumtomers.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            for (int i = index; i < amountOfCumtomers.Length - 1; i++)
            {
                amountOfCumtomers[i] = amountOfCumtomers[i + 1];
            }

            Array.Resize(ref amountOfCumtomers, amountOfCumtomers.Length - 1);
        }

        // Method to sell all stocks
        public void SellAllStocks()
        {
            double totalValue = totalStocks * stockWorth;
            SetBalance(GetBalance() + totalValue);
            totalStocks = 0;
            Console.WriteLine($"Sold all stocks. Total value added to balance: {totalValue}");
        }

        // Method to sell part of the stocks
        public void SellPartOfStocks(int quantity)
        {
            if (quantity > totalStocks)
            {
                Console.WriteLine("Cannot sell more stocks than owned.");
                return;
            }

            double value = quantity * stockWorth;
            SetBalance(GetBalance() + value);
            totalStocks -= quantity;
            Console.WriteLine($"Sold {quantity} stocks. Value added to balance: {value}");
        }

        // Method to buy stocks
        public void BuyStock(int quantity, double stockPrice)
        {
            double totalCost = quantity * stockPrice;

            if (totalCost > GetBalance())
            {
                Console.WriteLine("Insufficient balance to buy stocks.");
                return;
            }

            SetBalance(GetBalance() - totalCost);
            totalStocks += quantity;
            stockWorth = stockPrice; // Update stockWorth to reflect the latest price
            Console.WriteLine($"Bought {quantity} stocks at {stockPrice} each. Total cost: {totalCost}");
        }
    }

}
