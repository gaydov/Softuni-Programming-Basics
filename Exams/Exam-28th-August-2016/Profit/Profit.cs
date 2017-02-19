using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            int daysWorking = int.Parse(Console.ReadLine());
            double moneyEarnedDaily = double.Parse(Console.ReadLine());
            double USDtoBGN = double.Parse(Console.ReadLine());
            double monthlySalaryUSD = daysWorking * moneyEarnedDaily;
            double yearlySalaryUSD = (monthlySalaryUSD * 12) + (monthlySalaryUSD * 2.5);
            double tax = yearlySalaryUSD * 0.25;
            double netMoneyUSD = yearlySalaryUSD - tax;
            double netMoneyBGN = netMoneyUSD * USDtoBGN;
            double avgProfitDay = netMoneyBGN / 365;
            Console.WriteLine("{0:F2}", avgProfitDay);
        }
    }
}
