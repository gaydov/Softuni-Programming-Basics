using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawaHouse
{
    class DrawaHouse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{1}", new string('.', n - 1), new string('.', n - 1));

            for (int i = 2; i <= n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('.', n - i), new string(' ', ((2 * n - 1) - 2 * (n - i + 1))), new string('.', n - i));
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            Console.WriteLine("+{0}+", new string('-', 2 * n - 3));
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', 2 * n - 3));
            }

            Console.WriteLine("+{0}+", new string('-', 2 * n - 3));

        }
    }
}
