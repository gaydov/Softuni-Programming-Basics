using System;

namespace _3EqualNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            if (num1 == num2 && num1 == num3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
