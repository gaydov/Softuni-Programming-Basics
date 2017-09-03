using System;

namespace CurrencyConverter
{
    public class Launcher
    {
        public static void Main()
        {
            double money = double.Parse(Console.ReadLine()); // money will always be considered to be in BGN
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            switch (inputCurrency)
            {
                // we will use the mathematical relations between each pair of currencies to make the transitions
                case "BGN": break;
                case "USD": money = money * 1.79549;
                    break;
                case "EUR": money = money * 1.95583;
                    break;
                case "GBP": money = money * 2.53405;
                    break;
            }

            switch (outputCurrency)
            {
                case "BGN":
                    break;
                case "USD": money = money / 1.79549;
                    break;
                case "EUR": money = money / 1.95583;
                    break;
                case "GBP": money = money / 2.53405;
                    break;
            }

            Console.WriteLine(Math.Round(money, 2));
        }
    }
}