using System;

namespace HousePrice
{
    public class HousePrice
    {
        public static void Main()
        {
            double smallestRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double priceForSquareMeter = double.Parse(Console.ReadLine());

            double bathroomArea = smallestRoomArea / 2;
            double secondRoomArea = smallestRoomArea + (smallestRoomArea * 0.10);
            double thirdRoomArea = secondRoomArea + (secondRoomArea * 0.10);
            double hallwayArea = (smallestRoomArea + secondRoomArea + thirdRoomArea + kitchenArea + bathroomArea) * 0.05;
            double totalArea = smallestRoomArea + secondRoomArea + thirdRoomArea + kitchenArea + bathroomArea + hallwayArea;

            double price = totalArea * priceForSquareMeter;
            Console.WriteLine("{0:F2}", price);
        }
    }
}
