using System;

namespace Rocket
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;

            // drawing the head of the rocket:
            int middleSpaces = 0;
            int leftRightDots = 0;

            for (int headRow = 0; headRow < n; headRow++)
            {
                leftRightDots = (width - middleSpaces - 2) / 2;
                Console.WriteLine("{0}/{1}\\{0}", new string('.', leftRightDots), new string(' ', middleSpaces));
                middleSpaces += 2;
            }

            leftRightDots = (width - (2 * n)) / 2;
            Console.WriteLine("{0}{1}{0}", new string('.', leftRightDots), new string('*', 2 * n));

            // drawing the body of the rocket:
            for (int bodyRow = 0; bodyRow < 2 * n; bodyRow++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', width - n - 2));
            }

            // drawing the tale of the rocket:
            for (int i = 0; i < n / 2; i++)
            {
                int middleStars = width - (2 * ((n / 2) - i)) - 2;
                Console.WriteLine("{0}/{1}\\{0}", new string('.', (n / 2) - i), new string('*', middleStars));
            }
        }
    }
}
