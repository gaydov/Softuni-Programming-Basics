﻿using System;

namespace P2DRectangleArea
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double S = Math.Abs(x1 - x2) * Math.Abs(y1 - y2); // we get the sides' lengths using the difference between the coordinates of the points
            double P = (2 * Math.Abs(x1 - x2)) + (2 * Math.Abs(y1 - y2));
            Console.WriteLine(S);
            Console.WriteLine(P);
        }
    }
}
