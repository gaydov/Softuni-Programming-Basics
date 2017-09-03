using System;

namespace SquareofStars
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                Console.Write("*"); // on every row we start with a static *

                // drawing the rest of the stars plus interval before each star:
                for (int col = 0; col < n - 1; col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
