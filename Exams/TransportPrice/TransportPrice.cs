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
            string interval = Console.ReadLine();
            double price = 0;

            if (km < 20)
            {
                if (interval == "day")
                {
                    price = km * 0.79 + 0.7;
                }
                else if (interval == "night")
                {
                    price = km * 0.9 + 0.7;
                }
            }
            else if (km >= 20 && km < 100)
            {
                price = km * 0.09;
            }
            else if (km >= 100)
            {
                price = km * 0.06;
            }
            Console.WriteLine(price);
        }
    }
}
