using System;

namespace Pets
{
    public class Pets
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int foodTotal = int.Parse(Console.ReadLine());
            double dogFoodDaily = double.Parse(Console.ReadLine());
            double catFoodDaily = double.Parse(Console.ReadLine());
            double turtleFoodDaily = double.Parse(Console.ReadLine());

            double totalFoodEaten = (dogFoodDaily * days) + (catFoodDaily * days) + ((turtleFoodDaily / 1000) * days);

            if(foodTotal >= totalFoodEaten)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodTotal - totalFoodEaten));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalFoodEaten - foodTotal));
            }
        }
    }
}
