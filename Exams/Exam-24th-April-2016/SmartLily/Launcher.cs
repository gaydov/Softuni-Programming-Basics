using System;

namespace SmartLily
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            int toysCounter = 0;
            int money = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toysCounter++;
                }
                else
                {
                    money += (i * 5) - 1; // using "i" in order to create the ascending gift money value through the years
                }
            }

            money += toysCounter * priceToy;
            if (money >= priceMachine)
            {
                Console.WriteLine("Yes! {0:f2}", money - priceMachine);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", priceMachine - money);
            }
        }
    }
}
