using System;

namespace PointInTheFigure
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            // outside:
            if ((x < 0 || x > 3 * h || y < 0 || y > 4 * h) ||           // the area left, right, below and above the whole figure
                ((x >= 0 && x < h) && (y > h && y <= 4 * h)) ||         // the area left from the vertical part of the figure
                ((x > 2 * h && x <= 3 * h) && (y > h && y <= 4 * h)))   // the area right from the vertical part of the figure
            {
                Console.WriteLine("outside");
            }
            else if ((x > 0 && x < 3 * h && y > 0 && y < h) || // the area in the horizontal part of the figure
                (x > h && x < 2 * h && y > h && y < 4 * h) ||  // the area in the vertical part of the figure
                (x > h && x < 2 * h && y == h))				   // the segment between the horizontal and vertical part
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
