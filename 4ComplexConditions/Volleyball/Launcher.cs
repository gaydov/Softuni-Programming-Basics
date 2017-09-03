using System;

namespace Volleyball
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsHometown = int.Parse(Console.ReadLine());
            int weekendsSofia = 48 - weekendsHometown;
            double gamesSofia = weekendsSofia * 3 / 4.0;
            double gamesHolidays = holidays * 2 / 3.0;
            double gamesTotal = gamesSofia + gamesHolidays + weekendsHometown;

            if (yearType == "leap")
            {
                gamesTotal += gamesTotal * 0.15;
                Console.WriteLine(Math.Truncate(gamesTotal));
            }
            else if (yearType == "normal")
            {
                Console.WriteLine(Math.Truncate(gamesTotal));
            }
        }
    }
}
