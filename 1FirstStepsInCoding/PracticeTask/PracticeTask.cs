using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask
{
    class PracticeTask
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('#', num + 4)); //static line - does not need to be in a loop
            Console.WriteLine(new string('#', num + 4)); //static line - does not need to be in a loop
            for (int i = 1; i <= num; i++)               //for loop for drawing the middle part of the figure
            {
                Console.WriteLine("##{0}##", new string('-', num));
            }
            Console.WriteLine(new string('#', num + 4)); //static line - does not need to be in a loop
            Console.WriteLine(new string('#', num + 4)); //static line - does not need to be in a loop
        }
    }
}
