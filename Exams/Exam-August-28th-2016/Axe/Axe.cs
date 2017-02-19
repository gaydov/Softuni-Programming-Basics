using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), new string('-', i), new string('-', 5 * n - 3 * n - 2 - i));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', 3 * n), new string('-', n - 1), new string('-', n - 1));
            }

            for (int i = 0; i <= (n / 2) - 1 ; i++)
            {
                char element = '-';
                if (i == n / 2 - 1)
                {
                    element = '*';
                }
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - i), new string(element, (5 * n)- (3 * n-i) - 2 - (n-i-1) ), new string('-', n - i - 1));
            }
        }
    }
}
