using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string tax = Console.ReadLine();
            double total = 0;
            if (km < 20)
            {
                double initialRate = 0.7;
                if (tax == "day")
                {
                    total = initialRate + km * 0.79;
                }
                else if (tax == "night")
                {
                    total = initialRate + km * 0.9;
                }
            }
            else if (km >= 20 && km < 100)
            {
                total = km * 0.09;
            }
            else if (km >= 100)
            {
                total = km * 0.06;
            }
            Console.WriteLine(total);
        }
    }
}
