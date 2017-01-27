using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    public class SpecialNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int digit1 = 1; digit1 <= 9; digit1++)
            {
                for (int digit2 = 1; digit2 <= 9; digit2++)
                {
                    for (int digit3 = 1; digit3 <= 9; digit3++)
                    {
                        for (int digit4 = 1; digit4 <= 9; digit4++)
                        {
                            if (number % digit1 == 0 && number % digit2 == 0 && number % digit3 == 0 && number % digit4 == 0)
                            {
                                Console.Write($"{digit1}{digit2}{digit3}{digit4} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
