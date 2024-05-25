using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.OOP_Stock_App
{
    public class ExchangeDemoHomeWork
    {
        public static void Demo()
        {
            
            Stock apple = new Stock("Apple Inc.", "AAPL", "Technology", "NASDAQ");
            Stock tesla = new Stock("Tesla Inc.", "TSLA", "Automobile", "NASDAQ");
            Stock coke = new Stock("Coca-Cola Company", "COKE", "Beverages", "NYSE");

           
            apple.StartDay(150.00m);
            tesla.StartDay(600.00m);
            coke.StartDay(55.00m);

            
            apple.DisplayPrice();
            tesla.DisplayPrice();
            coke.DisplayPrice();

            
            apple.SetPrice(155.00m);
            tesla.SetPrice(610.00m);
            coke.SetPrice(57.00m);

            
            apple.DisplayPrice();
            tesla.DisplayPrice();
            coke.DisplayPrice();

           
            apple.PrintChangesPercentage();
            tesla.PrintChangesPercentage();
            coke.PrintChangesPercentage();

          
            apple.FinishDay(153.00m);
            tesla.FinishDay(605.00m);
            coke.FinishDay(56.00m);

            
            apple.DisplayPrice();
            tesla.DisplayPrice();
            coke.DisplayPrice();

           
            apple.PrintChangesPercentage();
            tesla.PrintChangesPercentage();
            coke.PrintChangesPercentage();

          
            PrintTheBestStockOption(new List<Stock> { apple, tesla, coke });
        }

        public static void PrintTheBestStockOption(List<Stock> stocks)
        {
            Stock bestStock = null;
            decimal maxChange = decimal.MinValue;

            foreach (var stock in stocks)
            {
                decimal change = stock.GetPercentageChange();
                if (change > maxChange)
                {
                    maxChange = change;
                    bestStock = stock;
                }
            }

            if (bestStock != null)
            {
                Console.WriteLine($"The best stock option is {bestStock.Sign} with a percentage change of {maxChange:F2}%.");
            }
            else
            {
                Console.WriteLine("No best stock option available.");
            }
        }
    }

    public class Stock
    {
        public string OfficialName { get; private set; }
        public string Sign { get; private set; }
        public string Industry { get; private set; }
        public string Exchange { get; private set; }
        public decimal Price { get; private set; }
        public decimal StartingPrice { get; private set; }
        public decimal ClosingPrice { get; private set; }
        public bool IsDayActive { get; private set; }

        public Stock(string officialName, string sign, string industry, string exchange)
        {
            OfficialName = officialName;
            Sign = sign;
            Industry = industry;
            Exchange = exchange;
        }

        public void StartDay(decimal startingPrice)
        {
            StartingPrice = startingPrice;
            Price = startingPrice;
            IsDayActive = true;
        }

        public void FinishDay(decimal closingPrice)
        {
            ClosingPrice = closingPrice;
            Price = closingPrice;
            IsDayActive = false;
        }

        public void SetPrice(decimal price)
        {
            if (IsDayActive)
            {
                Price = price;
            }
        }

        public void PrintChangesPercentage()
        {
            if (IsDayActive)
            {
                Console.WriteLine($"The day is still active for {Sign}. Cannot calculate percentage change yet.");
            }
            else
            {
                decimal percentChange = GetPercentageChange();
                Console.WriteLine($"Percentage change for {Sign}: {percentChange:F2}%");
            }
        }

        public decimal GetPercentageChange()
        {
            if (!IsDayActive)
            {
                return ((ClosingPrice - StartingPrice) / StartingPrice) * 100;
            }
            return 0;
        }

        public void DisplayPrice()
        {
            Console.WriteLine($"{Sign}: Current Price = {Price:C}");
        }
    }

}
