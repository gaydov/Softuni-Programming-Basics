using System;

namespace MaxNumber
{
    public class MaxNumber
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue; // giving the minNum the highest possible value of int (~ 2000000000)

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < minNum)
                {
                    minNum = num;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
