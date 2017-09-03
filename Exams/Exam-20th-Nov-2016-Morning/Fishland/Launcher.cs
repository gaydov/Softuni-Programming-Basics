using System;

namespace Fishland
{
    public class Launcher
    {
        public static void Main()
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKG = double.Parse(Console.ReadLine());
            double safridKG = double.Parse(Console.ReadLine());
            int midiKG = int.Parse(Console.ReadLine());

            double palamudPrice = skumriqPrice + (skumriqPrice * 0.60);
            double safridPrice = cacaPrice + (cacaPrice * 0.80);
            double midiPrice = 7.50;

            double palamudCost = palamudPrice * palamudKG;
            double safridCost = safridPrice * safridKG;
            double midiCost = midiPrice * midiKG;
            double totalCost = palamudCost + safridCost + midiCost;

            Console.WriteLine("{0:F2}", totalCost);
        }
    }
}
