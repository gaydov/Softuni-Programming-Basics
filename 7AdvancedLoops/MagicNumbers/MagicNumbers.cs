using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers
{
    public class MagicNumbers
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
                            for (int digit5 = 1; digit5 <= 9; digit5++)
                            {
                                for (int digit6 = 1; digit6 <= 9; digit6++)
                                {
                                    int product = digit1 * digit2 * digit3 * digit4 * digit5 * digit6;

                                    if (product == number)
                                    {
                                        Console.Write($"{digit1}{digit2}{digit3}{digit4}{digit5}{digit6} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
