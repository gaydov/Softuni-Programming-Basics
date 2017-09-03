using System;

namespace AreaofFigures
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * (radius * radius);
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = a * (h / 2);
            }

            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
