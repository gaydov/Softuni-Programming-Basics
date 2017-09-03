using System;

namespace CircleAreaandPerimeter
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = {0}", Math.PI * Math.Pow(radius, 2)); 
            Console.WriteLine("Perimeter = {0}", 2 * Math.PI * radius);
        }
    }
}
