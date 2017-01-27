using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null); // parsing the input text in a desired format
            date = date.AddDays(999); // adding the required number of days in order to get the result
            Console.WriteLine(date.ToString("dd-MM-yyyy")); // transforming the result to string in order to be able to print it on the console
        }
    }
}
