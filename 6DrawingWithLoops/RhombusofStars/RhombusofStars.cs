using System;

namespace RhombusofStars
{
    public class RhombusofStars
    {
        public static void Main()
        {
            int maxWidth = int.Parse(Console.ReadLine());

            // drawing the upper part of the figure:
            for (int row = 1; row <= maxWidth; row++)
            {
                Console.Write(new string(' ', maxWidth - row));
                Console.Write('*');

                for (int col = 1; col <= row - 1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            // drawing the lower part of the figure:
            for (int row = 1; row <= maxWidth - 1; row++)
            {
                Console.Write(new string(' ', row));
                Console.Write("*");

                for (int col = 1; col <= maxWidth - row - 1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
