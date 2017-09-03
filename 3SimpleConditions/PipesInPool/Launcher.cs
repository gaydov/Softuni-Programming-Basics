using System;

namespace PipesInPool
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int flowrate1 = int.Parse(Console.ReadLine());
            int flowrate2 = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double pipe1 = flowrate1 * time; // how much water is poored by pipe 1
            double pipe2 = flowrate2 * time; // how much water is poored by pipe 2
            double pooredWater = pipe1 + pipe2;

            if (pooredWater <= volume)
            {
                double percentFull = (int)((pooredWater / volume) * 100);
                double percentPipe1 = (int)((pipe1 / pooredWater) * 100);
                double percentPipe2 = (int)((pipe2 / pooredWater) * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentFull, percentPipe1, percentPipe2);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", time, pooredWater - volume);
            }
        }
    }
}
