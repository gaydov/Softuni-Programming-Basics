using System;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int distanceKm = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double taxi = 0.70;
            double autobus = 0.09;
            double train = 0.06;
            double sum = 0;

            if (distanceKm <= 19 && time == "day")
            {
                sum = taxi + distanceKm * 0.79;
            }
            else if (distanceKm <= 19 && time == "night")
            {
                sum = taxi + distanceKm * 0.90;
            }
            // else if (distanceKm >= 20 && distanceKm <= 99)
            else if (distanceKm >= 20 && distanceKm <= 99 && (time == "day" || time == "night"))
            {
                sum = autobus * distanceKm;
            }
            // else if (distanceKm >= 100)
            else if (distanceKm >= 100 && (time == "day" || time == "night"))
            {
                sum = train * distanceKm;
            }

            Console.WriteLine("{0}", sum);
        }
    }
}