using System;

namespace MetricConverter
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine()); // the input value is always considered to be meters
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();
            switch (inputUnit)
            {
                // we  will use the mathematical relations between the metrics to make the transitions
                case "m":
                    break;
                case "mm": number /= 1000;
                    break;
                case "cm": number /= 100;
                    break;
                case "mi": number /= 0.000621371192;
                    break;
                case "in": number /= 39.3700787;
                    break;
                case "km": number /= 0.001;
                    break;
                case "ft": number /= 3.2808399;
                    break;
                case "yd": number /= 1.0936133;
                    break;
            }

            switch (outputUnit)
            {
                case "m":
                    break;
                case "mm": number *= 1000;
                    break;
                case "cm": number *= 100;
                    break;
                case "mi": number *= 0.000621371192;
                    break;
                case "in": number *= 39.3700787;
                    break;
                case "km": number *= 0.001;
                    break;
                case "ft": number *= 3.2808399;
                    break;
                case "yd": number *= 1.0936133;
                    break;
            }

            Console.WriteLine(number + " " + outputUnit);  
        }
    }
}