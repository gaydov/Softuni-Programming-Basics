using System;

namespace SumDigits
{
    public class SumDigits
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int digitsSum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                digitsSum += lastDigit;
                number /= 10;
            }
            Console.WriteLine(digitsSum);
        }
    }
}
