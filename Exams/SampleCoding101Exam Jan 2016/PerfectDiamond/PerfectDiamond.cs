using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamond
{
    class PerfectDiamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // drawing the top part of the figure:
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}*", new string(' ', n - i));
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }

            // drawing the bottom part of the figure:
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write("{0}*", new string(' ', i));
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}
