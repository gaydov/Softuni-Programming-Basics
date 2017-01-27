using System;

namespace House
{
    public class House
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            if (n % 2 == 0)
            {
                stars++;
            }

            for (int roof = 1; roof <= (n + 1) / 2; roof++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('-', (n - stars) / 2),
                    new string('*', stars));
                stars += 2;
            }

            for (int body = 1; body <= n / 2; body++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}
