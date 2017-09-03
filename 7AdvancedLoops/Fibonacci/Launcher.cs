using System;

namespace Fibonacci
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int num0 = 1;
            int num1 = 1;
            int current = 1;

            for (int i = 2; i <= n; i++)
            {
                current = num0 + num1;
                num0 = num1;
                num1 = current;
            }

            Console.WriteLine(current);
        }
    }
}
