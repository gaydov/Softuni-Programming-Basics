using System;

namespace CheckPrime
{
    public class CheckPrime
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                // performing the Eratosthenes' algorithm:
                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
