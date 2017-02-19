using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = ' ';
            for (int i = 1; i <= n - 2; i++) // drawing the top part of the figure
            { 
                if (i % 2 != 0)  // determining what symbol we will need according to the number of the row
                {
                    symbol = '*';
                }
                else
                {
                    symbol = '-';
                }
                Console.WriteLine("{0}\\ /{1}", new string(symbol, n-2), new string(symbol, n - 2));
            }
            Console.Write(new string(' ', n-1)); // drawing the middle part of the figure
            Console.WriteLine('@');
            for (int i = 1; i <= n - 2; i++) // drawing the bottom part of the figure
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
