using System;

namespace NumberTable
{
    public class NumberTable
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int num = row + col + 1;
                    if (num > n)
                    {
                        num = (2 * n) - col - row - 1;
                    }
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }
    }
}
