using System;

namespace StupidPasswordGenerator
{
    public class StupidPasswordGenerator
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());

            for (int digit1 = 1; digit1 < n; digit1++)
            {
                for (int digit2 = 1; digit2 < n; digit2++)
                {
                    for (char letter1 = 'a'; letter1 < 'a' + L; letter1++)
                    {
                        for (char letter2 = 'a'; letter2 < 'a' + L; letter2++)
                        {
                            for (int lastDigit = 1; lastDigit <= n; lastDigit++)
                            {
                                if (lastDigit > digit1 && lastDigit > digit2)
                                {
                                    Console.Write($"{digit1}{digit2}{letter1}{letter2}{lastDigit} ");
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
