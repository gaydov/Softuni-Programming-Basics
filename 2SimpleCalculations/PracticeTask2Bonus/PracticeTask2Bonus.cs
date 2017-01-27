using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask2Bonus
{
    class PracticeTask2Bonus
    {
        static void Main(string[] args)
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
