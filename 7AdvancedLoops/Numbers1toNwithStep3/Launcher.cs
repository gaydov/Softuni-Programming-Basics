using System;

namespace Numbers1toNwithStep3
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
