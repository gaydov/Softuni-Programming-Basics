using System;

namespace Bricks
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double trips = bricks / (double)(workers * capacity); // explicitly casting the divisor to be double in order the result to be double

            // using Math.Ceiling() in order to get the result to the top value 
            // because we need the trips to be more than the required if the number is double:
            Console.WriteLine(Math.Ceiling(trips)); 
        }
    }
}
