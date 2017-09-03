using System;

namespace PointonSegment
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            if (point >= Math.Min(first, second) && point <= Math.Max(first, second))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

            // checking if the start or end number is closer to the point:
            if (Math.Abs(point - first) < Math.Abs(point - second))
            {
                Console.WriteLine(Math.Abs(point - first));
            }
            else
            {
                Console.WriteLine(Math.Abs(point - second));
            }
        }
    }
}
