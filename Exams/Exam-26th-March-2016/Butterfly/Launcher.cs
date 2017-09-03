using System;

namespace Butterfly
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = ' ';

            // drawing the top part of the figure
            for (int i = 1; i <= n - 2; i++)
            {
                // determining what symbol we will need according to the number of the row
                if (i % 2 != 0)
                {
                    symbol = '*';
                }
                else
                {
                    symbol = '-';
                }

                Console.WriteLine("{0}\\ /{1}", new string(symbol, n - 2), new string(symbol, n - 2));
            }

            Console.Write(new string(' ', n - 1)); // drawing the middle part of the figure
            Console.WriteLine('@');

            // drawing the bottom part of the figure
            for (int i = 1; i <= n - 2; i++) 
            {
                if (i % 2 != 0)
                {
                    symbol = '*';
                }
                else
                {
                    symbol = '-';
                }

                Console.WriteLine("{0}/ \\{1}", new string(symbol, n - 2), new string(symbol, n - 2));
            }
        }
    }
}
