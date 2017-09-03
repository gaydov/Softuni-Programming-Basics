using System;

namespace Nums1to100text
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            // checking if the entered number is a valid entry
            if (number >= 0 && number <= 100)  
            {
                // creating a switch that prints the unique numbers and the "teen" numbers - all of these numbers can appear only once in the interval [1; 99]:
                switch (number)
                {
                    case 0: Console.WriteLine("zero");
                        break;
                    case 10: Console.WriteLine("ten");
                        break;
                    case 11: Console.WriteLine("eleven");
                        break;
                    case 12: Console.WriteLine("twelve");
                        break;
                    case 13: Console.WriteLine("thirteen");
                        break;
                    case 14: Console.WriteLine("fourteen");
                        break;
                    case 15: Console.WriteLine("fifteen");
                        break;
                    case 16: Console.WriteLine("sixteen");
                        break;
                    case 17: Console.WriteLine("seventeen");
                        break;
                    case 18: Console.WriteLine("eighteen");
                        break;
                    case 19: Console.WriteLine("nineteen");
                        break;
                    case 100: Console.WriteLine("one hundred");
                        break;
                }

                // creating 2 arrays that contain the values that can appear more than once in the interval [1; 99]:
                string[] tens = { null, null, "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                string[] ones = { null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                // if the number is between 1 and 9
                if (number > 0 && number < 10)
                {
                    // going throug the ones array and prints the string from it (e.g. number = 5 it will print "five" - the fifth element in the array)
                    for (int i = 1; i <= ones.Length; i++) 
                    {
                        if (number == i)
                        {
                            Console.WriteLine(ones[i]);
                        }
                    }
                }

                // when the number is from the values that can appear more than once in the interval [1; 99]:
                if (number > 19 && number < 100)
                {
                    int firstNum = number / 10;     // getting the first digit of the number (e.g. 23 / 10 = 2)
                    int secondNum = number % 10;    // getting the second digit of the number (e.g. 23 % 10 = 3)

                    // going through the tens array and prints the string from it (e.g. firstNum = 2 it will print "twenty" - the second element of the array)
                    for (int i = 1; i <= tens.Length; i++)  
                    {
                        if (firstNum == i)
                        {
                            Console.Write(tens[i]);
                        }
                    }

                    // going throig the ones array and prints the string from it (e.g. secondNum = 3 it will print " three" - the third element of the array)
                    for (int i = 1; i <= ones.Length; i++) 
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
                Console.WriteLine("invalid number");  // if (number < 0) or (number > 100)
            }
        }
    }
}
