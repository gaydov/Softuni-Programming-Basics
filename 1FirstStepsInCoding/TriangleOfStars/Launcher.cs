using System;

namespace TriangleOfStars
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('*', i));
            }

            // alternative code using nested loops:
            // for (int i = 1; i <= 10; i++)
            // {
            //     for (int j = 1; j <= i; j++)
            //     {
            //         Console.Write('*');
            //     }
            //     Console.WriteLine();
            // }
        }
    }
}
