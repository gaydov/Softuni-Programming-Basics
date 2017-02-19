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
            double priceFruit = double.Parse(Console.ReadLine());
            int kgsVeg = int.Parse(Console.ReadLine());
            int kgsFruit = int.Parse(Console.ReadLine());
            double total = ((priceVeg * kgsVeg) + (priceFruit * kgsFruit)) / 1.94;
            Console.WriteLine(total);
        }
    }
}
