using System;

namespace TicketsGame
{
    public class TicketsGame
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double ticketPrice = 0;
            double transport = 0;
            if (people >= 1 && people <= 4)
            {
                transport = budget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transport = budget * 0.60;
            }
            else if (people >= 10 && people <= 24)
            {
                transport = budget * 0.50;
            }
            else if (people >= 25 && people <= 49)
            {
                transport = budget * 0.40;
            }
            else if (people > 50)
            {
                transport = budget * 0.25;
            }

            if (category == "VIP")
            {
                ticketPrice = 499.99;
            }
            else if (category == "Normal")
            {
                ticketPrice = 249.99;
            }

            budget -= transport;
            if (budget >= (people * ticketPrice))
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", budget - (people * ticketPrice));
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs((people * ticketPrice) - budget));
            }
        }
    }
}
