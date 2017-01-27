using System;

namespace ChangeTiles
{
    public class ChangeTiles
    {
        public static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            double widthFloor = double.Parse(Console.ReadLine());
            double lengthFloor = double.Parse(Console.ReadLine());
            double sideTriangle = double.Parse(Console.ReadLine());
            double heightTriangle = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double workerPay = double.Parse(Console.ReadLine());

            double area = widthFloor * lengthFloor;
            double tileArea = sideTriangle * (heightTriangle / 2);
            double tilesNeeded = Math.Ceiling(area / tileArea) + 5;
            double totalCost = (tilesNeeded * pricePerTile) + workerPay;

            if (money >= totalCost)
            {
                Console.WriteLine("{0:F2} lv left.", money-totalCost);
            }
            else
            {
                Console.WriteLine("You'll need {0:F2} lv more.", totalCost - money);
            }
        }
    }
}
