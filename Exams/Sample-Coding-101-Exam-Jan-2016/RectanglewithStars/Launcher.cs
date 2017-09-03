using System;

namespace RectanglewithStars
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int loopEnd = 0;

            Console.WriteLine(new string('%', 2 * n)); // drawing the first line which is static

            // defining end point for our loops in the cases when n is odd or even:
            if (n % 2 == 0)
            {
                loopEnd = (n / 2) - 1;
            }
            else
            {
                loopEnd = n / 2;
            }

            for (int i = 0; i < loopEnd; i++)
            {
                Console.WriteLine("%{0}%", new string(' ', (2 * n) - 2));
            }

            Console.WriteLine("%{0}**{0}%", new string(' ', n - 2)); // drawing the middle line with "**"

            for (int i = 0; i < loopEnd; i++)
            {
                Console.WriteLine("%{0}%", new string(' ', (2 * n) - 2));
            }

            Console.WriteLine(new string('%', 2 * n)); // drawing the last line which is static
        }
    }
}
