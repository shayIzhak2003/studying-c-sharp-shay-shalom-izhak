using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.projectEwler
{
    public class Soultion
    {
        //EX1
        public static int SumOfNumbers()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    continue;
                }
            }
            return sum;
        }
        //EX2
        public static int Fibunachi(int number)
        {
            if (number == 0)
            {
                return 0; // Base case for 0
            }
            if (number == 1)
            {
                return 1; // Base case for 1
            }
            return Fibunachi(number - 2) + Fibunachi(number - 1);
        }
        //EX3
        public static int LargetPrimeFactor(int num)
        {
            int index = 0;
            int maxPrimeFactor = 0;
            int[] primeFactorsArray = new int[num];

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    primeFactorsArray[index++] = i;
                    num /= i;
                }
            }
            for (int i = 0; i < primeFactorsArray.Length; i++)
            {
                if (primeFactorsArray[i] > maxPrimeFactor)
                {
                    maxPrimeFactor = primeFactorsArray[i];
                }
            }

            return maxPrimeFactor;
        }
        //EX4

        public static bool IsPalindrome(int number)
        {
            string str = number.ToString();
            string reversed = new string(str.Reverse().ToArray());
            return str == reversed;
        }

        public static int BiggestPhilandronmProduct()
        {
            int maxPhiandromProduct = 0;
            int product = 0;
            int i, j = 0;

            for (i = 100; i <= 999; i++)
            {
                for (j = 100; j <= 999; j++)
                {
                    product = (i * j);
                    if(IsPalindrome(product) && product > maxPhiandromProduct)
                    {
                        maxPhiandromProduct = product;
                    }
                }
            }
            return maxPhiandromProduct;
        }
        //EX5
        public static int SmallestMultiple()
        {
            int currentNum = 20;

            while (true)
            {
                bool isDivisibleByAll = true;
                for (int i = 1; i <= 20; i++)
                {
                    if(currentNum % i  != 0)
                    {
                        isDivisibleByAll = false;
                        break;
                    }
                }
                if (isDivisibleByAll)
                {
                    return currentNum;
                }
                currentNum++;
            }
        }
        //EX6
        public static double SumSquare()
        {
            double sumSquare = 0;       // Sum of the squares
            double sumAll = 0;          // Sum of the numbers (not squared)

            // Loop to calculate the sum of squares and sum of numbers
            for (int i = 1; i <= 100; i++)
            {
                sumSquare += Math.Pow(i, 2);  // Adding square of the current number to sum of squares
                sumAll += i;                  // Adding the current number to the sum
            }

            // Square of the sum
            double sumAllSquare = Math.Pow(sumAll, 2);

            // Return the difference between the square of the sum and the sum of the squares
            return sumAllSquare - sumSquare;
        }
        //EX7


    }
    public class RunSoultion
    {
        public static void DemoMain()
        {
            Console.WriteLine("Ex1 = " + Soultion.SumOfNumbers());
            Console.WriteLine("Ex2 = " + Soultion.Fibunachi(5));
            Console.WriteLine("Ex3 = " + Soultion.LargetPrimeFactor(13195));
            Console.WriteLine("Ex4 = " + Soultion.BiggestPhilandronmProduct());
            Console.WriteLine("Ex5 = " + Soultion.SmallestMultiple());
            Console.WriteLine("Ex6 = " + Soultion.SumSquare());
        }
    }
}
