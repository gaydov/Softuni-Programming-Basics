using System;

namespace NumbersEndingin7
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            for (int number = 0; number < 1000; number++)
            {
                if (number % 10 == 7)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
