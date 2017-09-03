using System;

namespace PoolPipes
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine()); // total volume of the pool
            int firstPipeFlow = int.Parse(Console.ReadLine()); 
            int secondPipeFlow = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double firstPipeLiters = firstPipeFlow * hours; // how many liters are filled by the first pipe
            double secondPipeLiters = secondPipeFlow * hours; // how many liters are filled by the second pipe
            double totalWater = firstPipeLiters + secondPipeLiters;

            double firstPipePercent = (int)((firstPipeLiters / totalWater) * 100); // the percentage from the total filled water by the first pipe
            double secondPipePercent = (int)((secondPipeLiters / totalWater) * 100); // the percentage from the total filled water by the second pipe
            double percentFull = (int)((totalWater / volume) * 100); 

            if (totalWater <= volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentFull, firstPipePercent, secondPipePercent);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, totalWater - volume);
            }
        }
    }
}
