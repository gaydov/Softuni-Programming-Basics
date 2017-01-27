using System;

namespace MaxCombination
{
    public class MaxCombination
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int num1 = startNum; num1 <= endNum; num1++)
            {
                for (int num2 = startNum; num2 <= endNum; num2++)
                {
                    if (counter == maxCombinations)
                    {
                        Console.WriteLine();
                        return;
                    }
                    Console.Write("<{0}-{1}>", num1, num2);
                    counter++;
                }
            }
            Console.WriteLine();
        }
    }
}
