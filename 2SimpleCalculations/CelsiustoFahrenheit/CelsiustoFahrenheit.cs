﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiustoFahrenheit
{
    class CelsiustoFahrenheit
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * (9 / 5.0) + 32;
            Console.WriteLine(Math.Round(fahrenheit, 2));
        }
    }
}
