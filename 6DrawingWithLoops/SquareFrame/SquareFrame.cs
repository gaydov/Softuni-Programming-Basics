using System;

namespace SquareFrame
{
    public class SquareFrame
    {
        public static void Main()
        {
            int sideWidth = int.Parse(Console.ReadLine());

            // drawing the first row(identical with the last):
            Console.Write("+");
            for (int i = 0; i < sideWidth - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            // drawing the middle rows:
            for (int row = 0; row < sideWidth - 2; row++)
            {
                Console.Write("|");
                for (int col = 0; col < sideWidth - 2; col++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            // drawing the last row(identical with the first):
            Console.Write("+");
            for (int i = 0; i < sideWidth - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
