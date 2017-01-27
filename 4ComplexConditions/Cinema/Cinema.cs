using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double price = 0;
            double result = 0;

            if (projection == "Premiere")
            {
                price = 12;
            }
            else if (projection == "Normal")
            {
                price = 7.5;
            }
            else if (projection == "Discount")
            {
                price = 5;
            }

            result = (rows * cols) * price;
            Console.WriteLine("{0:f2} leva", result);
        }
    }
}
