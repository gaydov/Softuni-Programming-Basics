using System;

namespace OddEvenSum
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += number;
                }
                else
                {
                    evenSum += number;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes\nSum = {0}", oddSum); // using \n in order to print the part after it on a new line
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(oddSum - evenSum)); // using \n in order to print the part after it on a new line
            }
        }
    }
}
