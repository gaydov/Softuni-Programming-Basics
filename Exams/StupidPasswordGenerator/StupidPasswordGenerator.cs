using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int d1 = 1; d1 <= n; d1++)
            {
                for (int d2 = 1; d2 <= n; d2++)
                {
                    for (char l1 = 'a'; l1 < 'a' + l; l1++)  // getting the first l letters from the alphabet starting with 'a'
                    {
                        for (char l2 = 'a'; l2 < 'a' + l; l2++) // getting the first l letters from the alphabet starting with 'a'
                        {
                            for (int d3 = 1; d3 <= n; d3++)
                            {
                                if (d3 > d1 && d3 > d2) // getting the first number that is bigger than d1 and d2
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", d1, d2, l1, l2, d3);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
