using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); // the entered numbered must be a three digit number

            int d3 = num % 10; // getting the third digit of the number (e.g. 132 -> 2)

            int d2 = num / 10; // getting the second digit of 
            d2 = d2 % 10;      // the number (e.g. 132 -> 3)

            int d1 = num / 100; // getting the first digit of the number (e.g. 132 -> 1)

            for (int rows = 0; rows < d1 + d2; rows++)
            {
                for (int cols = 0; cols < d1 + d3; cols++)
                {
                    if (num % 5 == 0)
                    {
                        num -= d1;
                    }
                    else if (num % 3 == 0)
                    {
                        num -= d2;
                    }
                    else
                    {
                        num += d3;
                    }
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }
    }
}
