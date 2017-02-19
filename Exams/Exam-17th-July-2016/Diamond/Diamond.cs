using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // drawing the first line:
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));

            // drawing the lines from the second to the line before the line with all the ********:
            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - i), new string('.', (5 * n - (2 * (n - i)) - 2)));
            }

            // drawing the middle line with the multiple ***********:
            Console.WriteLine("{0}", new string('*', 5 * n));

            // drawing the lines from the first line after the solid *** line to the line before the last:
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', (5 * n) - (2 * i) - 2));
            }

            // drawing the last line:
            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('*', n - 2));
        }
    }
}
