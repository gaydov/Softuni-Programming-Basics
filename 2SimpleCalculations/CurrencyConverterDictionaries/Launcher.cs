using System;
using System.Collections.Generic;

namespace CurrencyConverterDictionaries
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            var currencies = new Dictionary<string, double>();
            currencies.Add("BGN", 1);
            currencies.Add("USD", 1.79549);
            currencies.Add("EUR", 1.95583);
            currencies.Add("GBP", 2.53405);
            double num = double.Parse(Console.ReadLine());
            string inputCurr = Console.ReadLine();
            string outputCurr = Console.ReadLine();
            var changer = currencies[inputCurr] / currencies[outputCurr];

            Console.WriteLine(Math.Round(num * changer, 2) + " " + outputCurr);
        }
    }
}
