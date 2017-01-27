using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInc
{
    class CompanyInc
    {
        static void Main(string[] args)
        {
            int requiredHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());
            double workingHours = (days * 0.9) * 8;
            double overtime = employees * (days * 2);
            double totalHours = Math.Floor(workingHours + overtime);
            if (totalHours >= requiredHours)
            {
                Console.WriteLine("Yes!{0} hours left.", totalHours - requiredHours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", requiredHours - totalHours);
            }
        }
    }
}
