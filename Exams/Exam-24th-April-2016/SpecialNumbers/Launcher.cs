using System;

namespace SpecialNumbers
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            // creating 4 nested loops in order to cycle all numbers between 1111 and 9999:
            for (int d1 = 1; d1 <= 9; d1++)
            {
                for (int d2 = 1; d2 <= 9; d2++)
                {
                    for (int d3 = 1; d3 <= 9; d3++)
                    {
                        for (int d4 = 1; d4 <= 9; d4++)
                        {
                            // printint only the results that has a remainder 0
                            if (num % d1 == 0 && num % d2 == 0 && num % d3 == 0 && num % d4 == 0)
                            {
                                Console.Write($"{d1}{d2}{d3}{d4} ");
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
