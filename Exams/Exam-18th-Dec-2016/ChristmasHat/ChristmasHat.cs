using System;

namespace ChristmasHat
{
    public class ChristmasHat
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int width = 4 * N + 1;

            // Drawing the first 3 rows which are static:
            Console.WriteLine("{0}/|\\{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\|/{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}***{0}", new string('.', (width - 3) / 2));

            // Drawing the middle rows:
            int dashesCount = 0;

            for (int i = 1; i <= 2 * N - 1; i++)
            {
                dashesCount = i;
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', (width - 3 - 2 * dashesCount) / 2), new string('-', dashesCount));
            }

            // Drawing the last 3 rows:
            Console.WriteLine(new string('*', width));

            Console.Write("*");
            for (int i = 0; i < 2 * N; i++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();

            Console.WriteLine(new string('*', width));
        }
    }
}
