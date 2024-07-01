using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson9
{
    public class ProjectEuler
    {
        public static void DemoMain()
        {
            //EX1
            /*
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"The sum is {sum}");
            */
            //EX2
            /*
            // Variables to hold the two previous Fibonacci numbers
            int previous = 1;
            int current = 2;
            int sumOfEvens = 0;

            // Loop while the current Fibonacci number is less than or equal to 4 million
            while (current <= 4000000)
            {
                // If the current number is even, add it to the sum
                if (current % 2 == 0)
                {
                    sumOfEvens += current;
                }

                // Calculate the next Fibonacci number
                int next = previous + current;
                previous = current;
                current = next;
            }

            // Output the sum of the even Fibonacci numbers
            Console.WriteLine("Sum of even Fibonacci numbers not exceeding 4 million: " + sumOfEvens);

            */
            //EX3
            /*
            long number = 600851475143;
            long largestPrimeFactor = 0;
            long factor = 2;

            while (factor * factor <= number)
            {
                if (number % factor == 0)
                {
                    largestPrimeFactor = factor;
                    number /= factor;
                }
                else
                {
                    factor++;
                }
            }

            // If there is any prime factor greater than sqrt(number), it will be the remaining number itself
            if (number > largestPrimeFactor)
            {
                largestPrimeFactor = number;
            }

            Console.WriteLine($"The largest prime factor of 600851475143 is {largestPrimeFactor}");
            */
            //EX4
            /*
            int maxProduct = 0;
            for (int i = 100; i <=999; i++)
            {
                for(int j = i; j <=999; j++)
                {
                    int product = i * j;
                    if(IsPalindrome(product) && product > maxProduct)
                    {
                        maxProduct= product;
                    }
                }
            }
            Console.WriteLine($"the number : {maxProduct}");
            */

            //EX5
            /*
                long lcm = 1; // Start with 1 since LCM of any number and 1 is the number itself

                for (int i = 2; i <= 20; i++)
                {
                    lcm = CalculateLCM(lcm, i);
                }

                Console.WriteLine($"The smallest positive number that is evenly divisible by all of the numbers from 1 to 20 is {lcm}");
            
            */
            //EX6
            /*
            // Calculate the sum of the squares of the first 100 natural numbers
            double sumOfSquares = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += Math.Pow(i, 2);
            }
            Console.WriteLine($"The sum of the squares is: {sumOfSquares}");

            // Calculate the square of the sum of the first 100 natural numbers
            int n = 100;
            int sum = (n * (n + 1)) / 2; // Sum of the first 100 natural numbers
            double squareOfSum = Math.Pow(sum, 2); // Square of the sum
            Console.WriteLine($"The square of the sum is: {squareOfSum}");

            // Calculate the difference
            double difference = squareOfSum - sumOfSquares;
            Console.WriteLine($"The difference between the square of the sum and the sum of the squares is: {difference}");
            */
            /*
            //EX7
            int primeIndex = 10001;
            int count = 0;
            int number = 2;

            // Use a for loop with an indefinite upper limit to find the 10,001st prime number
            for (int i = 2; ; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                    if (count == primeIndex)
                    {
                        number = i;
                        break;
                    }
                }
            }

            Console.WriteLine($"The 10,001st prime number is: {number}");
            */
            //EX8
            /*
            // The 1000-digit number as a string
            string numberString =
                "73167176531330624919225119674426574742355349194934" +
                "96983520312774506326239578318016984801869478851843" +
                "85861560789112949495459501737958331952853208805511" +
                "12540698747158523863050715693290963295227443043557" +
                "66896648950445244523161731856403098711121722383113" +
                "62229893423380308135336276614282806444486645238749" +
                "30358907296290491560440772390713810515859307960866" +
                "70172427121883998797908792274921901699720888093776" +
                "65727333001053367881220235421809751254540594752243" +
                "52584907711670556013604839586446706324415722155397" +
                "53697817977846174064955149290862569321978468622482" +
                "83972241375657056057490261407972968652414535100474" +
                "82166370484403199890008895243450658541227588666881" +
                "16427171479924442928230863465674813919123162824586" +
                "17866458359124566529476545682848912883142607690042" +
                "24219022671055626321111109370544217506941658960408" +
                "07198403850962455444362981230987879927244284909188" +
                "84580156166097919133875499200524063689912560717606" +
                "05886116467109405077541002256983155200055935729725" +
                "71636269561882670428252483600823257530420752963450";

            int[] digits = new int[numberString.Length];

            // Convert the string of digits into an array of integers
            for (int i = 0; i < numberString.Length; i++)
            {
                digits[i] = numberString[i] - '0';
            }

            long maxProduct = 0;

            // Calculate the greatest product of thirteen adjacent digits
            for (int i = 0; i <= digits.Length - 13; i++)
            {
                long currentProduct = 1;
                for (int j = 0; j < 13; j++)
                {
                    currentProduct *= digits[i + j];
                }

                if (currentProduct > maxProduct)
                {
                    maxProduct = currentProduct;
                }
            }

            Console.WriteLine($"The greatest product of thirteen adjacent digits is: {maxProduct}");
            */

        }
        //EX4 function
        static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

         
            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }

        // Function to calculate GCD using the Euclidean algorithm
        static long CalculateGCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Function to calculate LCM using GCD
        static long CalculateLCM(long a, long b)
        {
            return (a * b) / CalculateGCD(a, b);
        }

        // a function that checks if the nuber is prime
        static bool IsPrime(long number)
        {
            for(long i = 2; i < number / 2; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
