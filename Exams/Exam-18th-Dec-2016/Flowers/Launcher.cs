using System;

namespace Flowers
{
    public class Launcher
    {
        public static void Main()
        {
            int chrysanthemumsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char isThisAHoliday = char.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (season == "Spring" || season == "Summer")
            {
                double priceChrysanthemum = 2;
                double priceRose = 4.1;
                double priceTulip = 2.5;

                totalPrice = (chrysanthemumsCount * priceChrysanthemum) + (rosesCount * priceRose) + (tulipsCount * priceTulip);

                if (tulipsCount > 7 && season == "Spring")
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }
            else if (season == "Autumn" || season == "Winter")
            {
                double priceHrizantema = 3.75;
                double priceRose = 4.5;
                double priceTulip = 4.15;

                totalPrice = (chrysanthemumsCount * priceHrizantema) + (rosesCount * priceRose) + (tulipsCount * priceTulip);

                if (rosesCount >= 10 && season == "Winter")
                {
                    totalPrice -= totalPrice * 0.1;
                }
            }
            
            if (isThisAHoliday == 'Y')
            {
                totalPrice += totalPrice * 0.15;
            }

            if (chrysanthemumsCount + rosesCount + tulipsCount > 20)
            {
                totalPrice -= totalPrice * 0.2;
            }

            Console.WriteLine("{0:F2}", totalPrice + 2);
        }
    }
}
