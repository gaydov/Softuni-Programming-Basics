using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine()); // the input value is always considered to be meters
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();
            switch (inputUnit)
            {
                // we  will use the mathematical relations between the metrics to make the transitions
                case "m": break;
                case "mm": number /= 1000; break;
                case "cm": number /= 100; break;
                case "mi": number /= 0.000621371192; break;
                case "in": number /= 39.3700787; break;
                case "km": number /= 0.001; break;
                case "ft": number /= 3.2808399; break;
                case "yd": number /= 1.0936133; break;
                default: break;
            }
            switch (outputUnit)
            {
                case "m": break;
                case "mm": number *= 1000; break;
                case "cm": number *= 100; break;
                case "mi": number *= 0.000621371192; break;
                case "in": number *= 39.3700787; break;
                case "km": number *= 0.001; break;
                case "ft": number *= 3.2808399; break;
                case "yd": number *= 1.0936133; break;
                default: break;
            }
            Console.WriteLine(number + " " + outputUnit);  
        }
    }
}
