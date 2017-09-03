using System;

namespace TrainingLab
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double rows = (h * 100) / 120;
            double tablesInRow = ((w * 100) - 100) / 70;
            double places = Math.Truncate(rows) * (Math.Truncate(tablesInRow) - 3);
            Console.WriteLine(places);
        }
    }
}
