using System;

namespace Increasing4Numbers
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b - a < 3)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int d1 = a; d1 <= b; d1++)
                {
                    for (int d2 = d1 + 1; d2 <= b; d2++)
                    {
                        for (int d3 = d2 + 1; d3 <= b; d3++)
                        {
                            for (int d4 = d3 + 1; d4 <= b; d4++)
                            {
                                Console.WriteLine($"{d1} {d2} {d3} {d4}");
                            }
                        }
                    }
                }
            }
        }
    }
}
