using System;

namespace PointinFigure
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if ((x >= 4 && x <= 10 && y <= 3 && y >= -5) ||
                (x >= 2 && x <= 4 && y <= 1 && y >= -3) ||
                (x >= 10 && x <= 12 & y <= 1 && y >= -3))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
