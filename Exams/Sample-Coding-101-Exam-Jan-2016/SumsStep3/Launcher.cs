using System;

namespace SumsStep3
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int number = 0;

            for (int i = 1; i <= n; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (i % 3 == 1)
                {
                    sum1 += number;
                }
                else if (i % 3 == 2)
                {
                    sum2 += number;
                }
                else if (i % 3 == 0)
                {
                    sum3 += number;
                }
            }

            Console.WriteLine("sum1 = {0}", sum1);
            Console.WriteLine("sum2 = {0}", sum2);
            Console.WriteLine("sum3 = {0}", sum3);
        }
    }
}
