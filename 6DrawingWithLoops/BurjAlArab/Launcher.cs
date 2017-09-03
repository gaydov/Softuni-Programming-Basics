using System;

namespace BurjAlArab
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // drawing the lightning - conductor:
            for (int roofStick = 0; roofStick < n / 2; roofStick++)
            {
                Console.WriteLine("|");
            }

            // drawing the widening rows:
            for (int widenRow = 0; widenRow < (n * 2) + 1; widenRow++)
            {
                char filling = ' ';

                if (widenRow >= n - 1)
                {
                    filling = '*';
                }

                Console.WriteLine("|{0}\\", new string(filling, widenRow));
            }

            // drawing the middle part:
            for (int middleRow = 0; middleRow < n + 1; middleRow++)
            {
                Console.WriteLine("|{0}|", new string('*', n * 2));
            }

            // drawing the narrowing rows:
            for (int narrowRow = 0; narrowRow < n - 2; narrowRow++)
            {
                Console.WriteLine("|{0}/", new string('*', (n * 2) - narrowRow));
            }

            // drawing the base:
            Console.WriteLine(new string('-', n * 3));
        }
    }
}
