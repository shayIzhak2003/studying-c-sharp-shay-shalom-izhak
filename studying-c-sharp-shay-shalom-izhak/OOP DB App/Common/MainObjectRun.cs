using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.OOP_DB_App.Common
{
    public class MainObjectRun
    {
        private List<stockCusomers> customers = new List<stockCusomers>();
        private ChangeBgAndFontColor colorChanger = new ChangeBgAndFontColor();

        public void Run()
        {
            Console.WriteLine("Welcome to the Stock Management App!");

            while (true)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Add a new customer");
                Console.WriteLine("2. List all customers");
                Console.WriteLine("3. Manage stocks for a customer");
                Console.WriteLine("4. Change background color");
                Console.WriteLine("5. Change font color");
                Console.WriteLine("6. Print detailed customer info");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewCustomer();
                        break;
                    case "2":
                        ListAllCustomers();
                        break;
                    case "3":
                        ManageStocks();
                        break;
                    case "4":
                        colorChanger.ChangeBackgroundColor();
                        break;
                    case "5":
                        colorChanger.ChangeFontColor();
                        break;
                    case "6":
                        PrintDetailedCustomerInfo();
                        break;
                    case "7":
                        Console.WriteLine("Exiting the application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private void AddNewCustomer()
        {
            try
            {
                Console.Write("Enter customer name: ");
                string name = Console.ReadLine();

                Console.Write("Enter customer age: ");
                double age = double.Parse(Console.ReadLine());

                Console.Write("Enter customer balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Enter customer ID (9 digits): ");
                int customerId = int.Parse(Console.ReadLine());

                Console.Write("Enter initial stock worth: ");
                double stockWorth = double.Parse(Console.ReadLine());

                Console.Write("Enter total stocks: ");
                int totalStocks = int.Parse(Console.ReadLine());

                stockCusomers newCustomer = new stockCusomers(name, age, balance, customerId, stockWorth, totalStocks, new ParntObjects[0]);
                customers.Add(newCustomer);

                Console.WriteLine("Customer added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding customer: " + ex.Message);
            }
        }

        private void ListAllCustomers()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
                return;
            }

            Console.WriteLine("\nList of Customers:");
            for (int i = 0; i < customers.Count; i++)
            {
                var customer = customers[i];
                Console.WriteLine($"Customer {i + 1}: {customer.GetName()}, Age: {customer.GetAge()}, Balance: {customer.GetBalance()}, ID: {customer.GetCustomerId()}, Stocks: {customer.GetTotalStocks()}, Stock Worth: {customer.GetStockWorth()}");
            }
        }

        private void PrintDetailedCustomerInfo()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
                return;
            }

            Console.WriteLine("\nDetailed Customer Information:");
            Console.WriteLine("{0,-5} {1,-20} {2,-5} {3,-10} {4,-15} {5,-10} {6,-15}",
                "Index", "Name", "Age", "Balance", "Customer ID", "Stocks", "Stock Worth");

            for (int i = 0; i < customers.Count; i++)
            {
                var customer = customers[i];
                Console.WriteLine("{0,-5} {1,-20} {2,-5} {3,-10} {4,-15} {5,-10} {6,-15}",
                    i + 1, customer.GetName(), customer.GetAge(), customer.GetBalance(), customer.GetCustomerId(), customer.GetTotalStocks(), customer.GetStockWorth());
            }
        }

        private void ManageStocks()
        {
            Console.Write("Enter the customer index (1, 2, 3, etc.): ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= customers.Count)
            {
                var customer = customers[index - 1];

                Console.WriteLine($"\nManaging stocks for {customer.GetName()}:");
                Console.WriteLine("1. Buy stocks");
                Console.WriteLine("2. Sell part of stocks");
                Console.WriteLine("3. Sell all stocks");
                Console.WriteLine("4. Back to main menu");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BuyStocks(customer);
                        break;
                    case "2":
                        SellPartOfStocks(customer);
                        break;
                    case "3":
                        SellAllStocks(customer);
                        break;
                    case "4":
                        Console.WriteLine("Returning to main menu.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Returning to main menu.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid customer index. Returning to main menu.");
            }
        }

        private void BuyStocks(stockCusomers customer)
        {
            try
            {
                Console.Write("Enter the quantity of stocks to buy: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.Write("Enter the price per stock: ");
                double price = double.Parse(Console.ReadLine());

                customer.BuyStock(quantity, price);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error buying stocks: " + ex.Message);
            }
        }

        private void SellPartOfStocks(stockCusomers customer)
        {
            try
            {
                Console.Write("Enter the quantity of stocks to sell: ");
                int quantity = int.Parse(Console.ReadLine());

                customer.SellPartOfStocks(quantity);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error selling stocks: " + ex.Message);
            }
        }

        private void SellAllStocks(stockCusomers customer)
        {
            try
            {
                customer.SellAllStocks();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error selling all stocks: " + ex.Message);
            }
        }
        
     
    }
}
