using System;

namespace TriangleofDollars
{
    public class TriangleofDollars
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                Console.Write("$");     //every line starts with a $ sign

                // drawing the rest of each row:
                for (int col = 0; col < row; col++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
