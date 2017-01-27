using System;

namespace NumbersNto1
{
    public class NumbersNto1
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
