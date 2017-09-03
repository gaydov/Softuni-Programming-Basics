using System;

namespace TriangleArea
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = a * (h / 2);
            Console.WriteLine("Triangle area = {0}", Math.Round(area, 2));
        }
    }
}
