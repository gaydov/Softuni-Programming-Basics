using System;

namespace BikeRace
{
    public class Launcher
    {
        public static void Main()
        {
            int juniorsCount = int.Parse(Console.ReadLine());
            int seniorsCount = int.Parse(Console.ReadLine());
            string traceType = Console.ReadLine();

            double taxJuniors = 0;
            double taxSeniors = 0;

            if (traceType == "trail")
            {
                taxJuniors = 5.50;
                taxSeniors = 7;
            }
            else if (traceType == "cross-country")
            {
                taxJuniors = 8;
                taxSeniors = 9.50;
                if (juniorsCount + seniorsCount >= 50)
                {
                    taxJuniors = taxJuniors * 0.75;
                    taxSeniors = taxSeniors * 0.75;
                }
            }
            else if (traceType == "downhill")
            {
                taxJuniors = 12.25;
                taxSeniors = 13.75;
            }
            else if (traceType == "road")
            {
                taxJuniors = 20;
                taxSeniors = 21.50;
            }

            double expenses = ((juniorsCount * taxJuniors) + (seniorsCount * taxSeniors)) * 0.05;
            double donationSize = ((juniorsCount * taxJuniors) + (seniorsCount * taxSeniors)) - expenses;

            Console.WriteLine("{0:F2}", donationSize);
        }
    }
}
