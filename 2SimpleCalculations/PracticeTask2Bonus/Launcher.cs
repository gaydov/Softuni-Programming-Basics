﻿using System;

namespace PracticeTask2Bonus
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number: ");
            int num = int.Parse(Console.ReadLine());

            while (num <= 0)
            {
                Console.Write("Enter a positive integer number: ");
                num = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= num; i++)
            {
                if (num > 20)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.Write(num - i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
