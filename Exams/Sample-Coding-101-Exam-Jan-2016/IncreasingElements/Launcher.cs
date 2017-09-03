using System;

namespace IncreasingElements
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int previousNumber = int.MinValue;
            int number = 0;
            int length = 0;
            int maxLength = 0;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number > previousNumber)
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                    }
                }
                else
                {
                    length = 1;
                }

                previousNumber = number;
            }

            Console.WriteLine(maxLength);
        }
    }
}
