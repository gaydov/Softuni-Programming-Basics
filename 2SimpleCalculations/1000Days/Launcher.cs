using System;

namespace P1000Days
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null); // parsing the input text in a desired format
            date = date.AddDays(999); // adding the required number of days in order to get the result
            Console.WriteLine(date.ToString("dd-MM-yyyy")); // transforming the result to string in order to be able to print it on the console
        }
    }
}
