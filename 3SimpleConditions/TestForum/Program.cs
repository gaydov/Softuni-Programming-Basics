using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number >= 0 && number <= 100)  // checking if the entered number is valid entry
            {
                if (number == 0)        // borderline case - it can appear only once
                {
                    Console.WriteLine("zero");
                }
                else if (number == 100) // borderline case - it can appear only once
                {
                    Console.WriteLine("one hundred");
                }

                // creating 2 arrays to contain the values that can appear more than once in the interval [1; 99]:
                string[] tens = { null, null, "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" }; 
                string[] ones = { null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                if (number < 10) // if the number is between 1 and 9
                {
                    for (int i = 1; i <= ones.Length; i++) // going throug the ones array and prints the string from it (e.g. number = 5 it will print "five" - the fifth element in the array)
                    {
                        if (number == i)
                        {
                            Console.WriteLine(ones[i]);
                        }
                    }
                }

                // creating a switch that prints the unique numbers and the "teen" numbers - all of these numbers can appear only once in the interval [1; 99]:
                switch (number)
                {
                    case 10: Console.WriteLine("ten"); break;
                    case 11: Console.WriteLine("eleven"); break;
                    case 12: Console.WriteLine("twelve"); break;
                    case 13: Console.WriteLine("thirteen"); break;
                    case 14: Console.WriteLine("fourteen"); break;
                    case 15: Console.WriteLine("fifteen"); break;
                    case 16: Console.WriteLine("sixteen"); break;
                    case 17: Console.WriteLine("seventeen"); break;
                    case 18: Console.WriteLine("eighteen"); break;
                    case 19: Console.WriteLine("nineteen"); break;
                    default: break;
                }

                // when the number is between the values that can appear more than once in the interval [1; 99]:
                if (number > 19 && number < 100)
                {
                    int firstNum = number / 10;     // getting the first digit of the number (e.g. 23 / 10 = 2)
                    int secondNum = number % 10;    // getting the second digit of the number (e.g. 23 % 10 = 3)

                    for (int i = 1; i <= tens.Length; i++)  // going through the tens array and prints the string from it (e.g. firstNum = 2 it will print "twenty" - the second element of the array)
                    {
                        if (firstNum == i)
                        {
                            Console.Write(tens[i]);
                        }
                    }
                    for (int i = 1; i <= ones.Length; i++) // going throig the ones array and prints the string from it (e.g. secondNum = 3 it will print "three" - the third element of the array)
                    {
                        if (secondNum == i)
                        {
                            Console.WriteLine(" " + ones[i]);
                        }
                    }
                }
            }
            else  
            {
                Console.WriteLine("invalid number");  //if (number < 0) or (number > 100)
            }
        }
    }
}
