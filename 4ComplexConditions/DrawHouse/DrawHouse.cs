using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawHouse
{
    class DrawHouse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n - 1;
            int width = 2 * n - 1; // the total width of the figure

            // drawing the first line of the roof which is static:
            Console.WriteLine("{0}*{0}", new string('.', dots));

            // drawing the rows between the first and the last (* * * * *):
            for (int i = 0; i < n - 2; i++)
            {
                dots--;
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', dots),
                    new string(' ', width - (2 * dots) - 2),
                    new string('.', dots));
            }

            // drawing the last row from the roof:
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            // drawing the first line of the body of the house which is static:
            Console.WriteLine("+{0}+", new string('-', width - 2));

            // drawing the middle part of the body of the house:
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', width - 2));
            }

            // drawing the last line of the body of the house which is static:
            Console.WriteLine("+{0}+", new string('-', width - 2));
        }
    }
}
