using System;

namespace USDtoBGN
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine(Math.Round(bgn, 2));
        }
    }
}
