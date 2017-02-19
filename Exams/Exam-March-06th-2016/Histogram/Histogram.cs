using System;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    count1++;
                }
                else if (number >= 200 && number < 400)
                {
                    count2++;
                }
                else if (number >= 400 && number < 600)
                {
                    count3++;
                }
                else if (number >= 600 && number < 800)
                {
                    count4++;
                }
                else if (number >= 800)
                {
                    count5++;
                }
            }

            double p1 = (count1 / (double)n) * 100;
            double p2 = (count2 / (double)n) * 100;
            double p3 = (count3 / (double)n) * 100;
            double p4 = (count4 / (double)n) * 100;
            double p5 = (count5 / (double)n) * 100;

            Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%\n{3:f2}%\n{4:f2}%", p1, p2, p3, p4, p5);
        }
    }
}
