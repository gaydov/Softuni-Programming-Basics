using System;

namespace SquareOfStars
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n)); // it will print as much chars as we say (in this case it will print * n times 

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine('*' + new string(' ', n - 2) + '*');
            }

            Console.WriteLine(new string('*', n));
        }
    }
}
