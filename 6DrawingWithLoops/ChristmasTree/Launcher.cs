using System;

namespace ChristmasTree
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', n + 1));
            Console.WriteLine("|");

            for (int row = 1; row <= n; row++)
            {
                string spaces = new string(' ', n - row);
                string stars = new string('*', row);

                Console.WriteLine($"{spaces}{stars} | {stars}{spaces}");   
            }
        }
    }
}
