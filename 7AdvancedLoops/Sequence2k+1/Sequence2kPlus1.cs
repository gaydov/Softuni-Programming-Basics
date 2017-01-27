using System;

namespace Sequence2kPlus1
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 1; number <= n; i++)
            {
                Console.WriteLine(number);
                number = (number * 2) + 1;
            }
        }
    }
}
