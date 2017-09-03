using System;

namespace Division
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    count1++;
                }

                if (number % 3 == 0)
                {
                    count2++;
                }

                if (number % 4 == 0)
                {
                    count3++;
                }
            }

            p1 = (count1 / (double)n) * 100; // explicitly casting the divisor to be double in order the result to be double
            p2 = (count2 / (double)n) * 100;
            p3 = (count3 / (double)n) * 100;

            Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%", p1, p2, p3); // formating the output
        }
    }
}
