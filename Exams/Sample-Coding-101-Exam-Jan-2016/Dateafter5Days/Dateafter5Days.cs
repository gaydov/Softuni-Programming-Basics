using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateafter5Days
{
    class Dateafter5Days
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int daysInMonth = 0;

            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = 28;
                    break;
                default:
                    daysInMonth = 31;
                    break;
            }

            if (d + 5 > daysInMonth)
            {
                d = (d + 5) - daysInMonth;
                m += 1;
                if (m > 12)
                {
                    m -= 12;
                }
            }
            else
            {
                d += 5;
            }
            Console.WriteLine("{0}.{1:D2}", d, m);

        }
    }
}
