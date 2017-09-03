using System;

namespace DailyProfit
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double dollar = double.Parse(Console.ReadLine());
            double yearSalary = ((workingDays * moneyPerDay) * 12) + ((workingDays * moneyPerDay) * 2.5);
            double tax = yearSalary * (25 / 100.0);
            double netProfit = (yearSalary - tax) * dollar;
            double avgDayProfit = netProfit / 365;
            Console.WriteLine("{0:f2}", avgDayProfit); // using :f2 in order to format the string to the second char after "."
        }
    }
}
