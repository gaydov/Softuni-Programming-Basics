using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapesPerSquare = double.Parse(Console.ReadLine());
            int requiredWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double totalGrapes = area * grapesPerSquare;
            double wine = (totalGrapes * 0.40) / 2.5;
            if (wine >= requiredWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n{1} liters left -> {2} liters per person.", Math.Floor(wine), Math.Ceiling(wine - requiredWine), Math.Ceiling((wine - requiredWine) / workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(requiredWine - wine));
            }

        }
    }
}
