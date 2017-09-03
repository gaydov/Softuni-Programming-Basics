using System;

namespace CelsiustoFahrenheit
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * (9 / 5.0)) + 32;
            Console.WriteLine(Math.Round(fahrenheit, 2));
        }
    }
}
