using System;

namespace Logistics
{
    public class Launcher
    {
        public static void Main()
        {
            int loadsCount = int.Parse(Console.ReadLine());
            int sumLoads = 0;
            double totalCost = 0;

            int microbusLoads = 0;
            int truckLoads = 0;
            int trainLoads = 0;

            for (int currentLoad = 0; currentLoad < loadsCount; currentLoad++)
            {
                int loadTons = int.Parse(Console.ReadLine());
                double price = 0;

                if (loadTons <= 3)
                {
                    price = loadTons * 200;
                    microbusLoads += loadTons;
                }
                else if (loadTons >= 4 && loadTons <= 11)
                {
                    price = loadTons * 175;
                    truckLoads += loadTons;
                }
                else if (loadTons >= 12)
                {
                    price = loadTons * 120;
                    trainLoads += loadTons;
                }

                totalCost += price;
                sumLoads += loadTons;
            }

            double avgPricePerTon = totalCost / sumLoads;
            double microbusLoadsPercent = ((double)microbusLoads / sumLoads) * 100;
            double truckLoadsPercent = ((double)truckLoads / sumLoads) * 100;
            double trainLoadsPercent = ((double)trainLoads / sumLoads) * 100;

            Console.WriteLine("{0:F2}", avgPricePerTon);
            Console.WriteLine("{0:F2}%", microbusLoadsPercent);
            Console.WriteLine("{0:F2}%", truckLoadsPercent);
            Console.WriteLine("{0:F2}%", trainLoadsPercent);
        }
    }
}
