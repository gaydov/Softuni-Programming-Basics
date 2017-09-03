using System;

namespace Vacation
{
    public class Launcher
    {
        public static void Main()
        {
            int seniorPeople = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            double seniorPrice = 0;
            double studentPrice = 0;

            if (transport == "train")
            {
                seniorPrice = 24.99;
                studentPrice = 14.99;
                if (seniorPeople + students >= 50)
                {
                    seniorPrice *= 0.50;
                    studentPrice *= 0.50;
                }
            }
            else if (transport == "bus")
            {
                seniorPrice = 32.50;
                studentPrice = 28.50;
            }
            else if (transport == "boat")
            {
                seniorPrice = 42.99;
                studentPrice = 39.99;
            }
            else if (transport == "airplane")
            {
                seniorPrice = 70;
                studentPrice = 50;
            }

            double hotelPrice = 82.99;
            double hotelCost = hotelPrice * nights;
            double transporCost = ((seniorPeople * seniorPrice) + (students * studentPrice)) * 2;
            double commission = (hotelCost + transporCost) * 0.10;
            double totalCost = hotelCost + transporCost + commission;
            Console.WriteLine("{0:F2}", totalCost);
        }
    }
}
