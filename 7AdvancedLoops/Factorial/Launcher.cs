using System;

namespace Factorial
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;

            for (int currentNum = 1; currentNum <= n; currentNum++)
            {
                result *= currentNum;
            }

            Console.WriteLine(result);
        }
    }
}
