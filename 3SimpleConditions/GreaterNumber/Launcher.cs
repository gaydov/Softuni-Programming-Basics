using System;

namespace GreaterNumber
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            if (firstNum > secondNum)
            {
                Console.WriteLine(firstNum);
            }
            else
            {
                Console.WriteLine(secondNum);
            }
        }
    }
}