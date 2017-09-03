using System;

namespace OddEvenPosition
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;

            // for the min and max values we assign the opposite values for the double type:
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += number;

                    if (number < oddMin)
                    {
                        oddMin = number;
                    }

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                }
                else
                {
                    evenSum += number;

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                }
            }

            Console.WriteLine("OddSum={0},", oddSum);

            if (oddMin == double.MaxValue && oddMax == double.MinValue)
            {
                Console.WriteLine("OddMin=No,\nOddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMin={0},\nOddMax={1},", oddMin, oddMax);
            }

            Console.WriteLine("EvenSum={0},", evenSum);

            if (evenMin == double.MaxValue && evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMin = No,\nEvenMax = No");
            }
            else
            {
                Console.WriteLine("EvenMin={0},\nEvenMax={1}", evenMin, evenMax);
            }
        }
    }
}
