using System;

namespace GreatestCommonDivisor_CGD_
{
    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int remainder = 0;

            while (b != 0)
            {
                int oldB = b;
                remainder = a % b;
                b = remainder; 
                a = oldB;
            }
            Console.WriteLine(a);
        }
    }
}
