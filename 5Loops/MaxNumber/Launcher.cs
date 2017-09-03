﻿using System;

namespace MaxNumber
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue; // giving the maxNum value of the lowest possible value of int (~ -2000000000)

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
