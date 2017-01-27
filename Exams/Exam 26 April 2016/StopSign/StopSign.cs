using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopSign
{
    class StopSign
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // n * 4 + 3 (total number of colums)
            // 2 * n + 2 (total number of rows)

            // drawing the first row:
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1)); 

            // drawing the part above STOP!:
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', n - i), new string('_', (n * 4 + 3) - (2 * (n - i) + 4)));
            }

            // drawing the STOP row:
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', ((n * 4 + 3 - 5 - 4)) / 2));

            // drawing the part below STOP:
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', i), new string('_', (n * 4 + 3 - 4 - 2 * i)));
            }
        }
    }
}
