using System;

namespace Sunglasses
{
    public class Sunglasses
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;

            Console.WriteLine("{0}{1}{0}", 
                new string('*', 2 * n), 
                new string(' ', n));

            for (int midRow = 1; midRow <= n - 2; midRow++)
            {
                char middle = ' '; // declaring space char variable which we use for delimiter between the 2 glasses
                if (midRow == (n - 1) / 2)
                {
                    middle = '|'; // when we are on the correct row where the 2 glasses should be connected we change the char variable to |
                }

                Console.WriteLine("*{0}*{1}*{0}*", 
                    new string('/', (width - 4 - n) / 2), 
                    new string(middle, n));
            }

            Console.WriteLine("{0}{1}{0}",
                new string('*', 2 * n),
                new string(' ', n));
        }
    }
}
