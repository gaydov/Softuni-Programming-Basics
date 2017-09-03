using System;

namespace Harvest
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapesPerSquare = double.Parse(Console.ReadLine());
            int requiredLiters = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double totalGrapes = area * grapesPerSquare;
            double wine = (totalGrapes / 2.5) * (40.0 / 100.0);
            if (wine >= requiredLiters)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - requiredLiters), Math.Ceiling((wine - requiredLiters) / workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(requiredLiters - wine));
            }
        }
    }
}
