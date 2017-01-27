using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            int hoursRequired = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employeesOvertime = int.Parse(Console.ReadLine());

            double hoursWorking = (days * 0.9) * 8;
            int overtime = employeesOvertime * (2 * days);
            double hoursTotal = Math.Floor(hoursWorking + overtime);
            if (hoursRequired <= hoursTotal)
            {
                Console.WriteLine("Yes!{0} hours left.", hoursTotal - hoursRequired);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(hoursRequired - hoursTotal));
            }
        }
    }
}
