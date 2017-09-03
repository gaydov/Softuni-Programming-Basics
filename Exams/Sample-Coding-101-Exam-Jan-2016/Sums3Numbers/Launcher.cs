using System;

namespace Sums3Numbers
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 + num2 == num3)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(num1, num2), Math.Max(num1, num2), num3);
            }
            else if (num1 + num3 == num2)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(num1, num3), Math.Max(num1, num3), num2);
            }
            else if (num2 + num3 == num1)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(num2, num3), Math.Max(num2, num3), num1);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
