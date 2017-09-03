using System;

namespace EnterEvenNumber
{
    public class Launcher
    {
        public static void Main()
        {
            bool isEven = false;
            int number = 0;

            do
            {
                try
                {
                    Console.Write("Enter even number: ");
                    number = int.Parse(Console.ReadLine());
                    
                    if (number % 2 == 0)
                    {
                        isEven = true;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            while (isEven == false);

            Console.WriteLine("Even number entered: {0}", number);
        }
    }
}
