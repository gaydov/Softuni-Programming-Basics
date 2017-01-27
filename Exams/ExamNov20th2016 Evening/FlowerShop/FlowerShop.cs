using System;

namespace FlowerShop
{
    public class FlowerShop
    {
        public static void Main()
        {
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double tax = ((magnoliasCount * 3.25) + (hyacinthsCount * 4) + (rosesCount * 3.50) + (cactusesCount * 8)) * 0.05;
            double netProfit = ((magnoliasCount * 3.25) + (hyacinthsCount * 4) + (rosesCount * 3.50) + (cactusesCount * 8)) - tax;
            
            if (netProfit >= presentPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(netProfit - presentPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(presentPrice - netProfit));
            }
        }
    }
}
