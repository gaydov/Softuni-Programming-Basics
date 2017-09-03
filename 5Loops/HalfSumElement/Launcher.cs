using System;

namespace HalfSumElement
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue; // giving the max variable the value of the lowest possible int value (~ 2000000000)

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }

            if (max == (sum - max))
            {
                Console.WriteLine("Yes\nSum = {0}", max);
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(max - (sum - max)));
            }
        }
    }
}
