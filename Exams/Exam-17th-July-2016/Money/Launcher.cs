using System;

namespace Money
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double yuansUSD = yuans * 0.15;
            double yuansBGN = yuansUSD * 1.76;
            double comission = double.Parse(Console.ReadLine());
            double totalMoneyBGN = (bitcoins * 1168) + yuansBGN;
            totalMoneyBGN = totalMoneyBGN - (totalMoneyBGN * (comission / 100));
            Console.WriteLine("{0}", totalMoneyBGN / 1.95);
        }
    }
}
