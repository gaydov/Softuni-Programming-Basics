using System;

namespace EvenPowersof2
{
    public class EvenPowersof2
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                int pow = i;
                if (pow % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, pow));
                }
            }
        }
    }
}
