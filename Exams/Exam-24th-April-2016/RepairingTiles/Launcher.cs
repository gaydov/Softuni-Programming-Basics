using System;

namespace RepairingTiles
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int sideLength = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLength = int.Parse(Console.ReadLine());

            int totalArea = sideLength * sideLength;
            double benchArea = benchWidth * benchLength;
            double areaToBeCovered = totalArea - benchArea;
            double tileArea = tileWidth * tileLength;
            double requiredTiles = areaToBeCovered / tileArea;
            double time = requiredTiles * 0.2;
            Console.WriteLine("{0}\n{1}", requiredTiles, time);
        }
    }
}
