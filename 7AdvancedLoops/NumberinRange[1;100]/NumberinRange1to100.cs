using System;

namespace NumberinRange1to100
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", number);
        }
    }
}
