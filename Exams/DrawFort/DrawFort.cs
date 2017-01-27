using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("/{0}\\{1}/{2}\\", (new string('^', n / 2)), (new string('_', 2 * n - 4 - 2 * (n / 2))), (new string('^', n / 2))); // drawing the first line of the fort
            for (int i = 0; i < n - 2 - 1; i++)  // drawing the middle part of the fort
            {
                Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
            }
            Console.WriteLine("|{0}{1}{2}|", (new string(' ', (n / 2) + 1)), (new string('_', 2 * n - 4 - 2 * (n / 2))), (new string(' ', (n / 2) + 1))); // drawing the line before the last
            Console.WriteLine("\\{0}/{1}\\{2}/", (new string('_', n / 2)), (new string(' ', 2 * n - 4 - 2 * (n / 2))), (new string('_', n / 2))); // drawing the last line of the fort
        }
    }
}
