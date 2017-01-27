using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            double priceVeg = double.Parse(Console.ReadLine());
            double priceFru = double.Parse(Console.ReadLine());
            int kgVeg = int.Parse(Console.ReadLine());
            int kgFru = int.Parse(Console.ReadLine());
            double profit = ((priceVeg * kgVeg) + (priceFru * kgFru)) / 1.94 ;
            Console.WriteLine(profit);
        }
    }
}
