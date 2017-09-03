using System;

namespace PracticeTask
{
    public class PracticeTask
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); 
            Console.WriteLine(new string('#', num + 4));            // static line - does not need to be in a loop
            Console.WriteLine("#{0}#", new string('*', num + 2));   // static line - does not need to be in a loop

            // for loop for drawing the middle part of the figure
            for (int i = 0; i < num; i++)                           
            {
                Console.WriteLine("#*{0}*#", new string('-', num));
            }

            Console.WriteLine("#{0}#", new string('*', num + 2));  // static line - does not need to be in a loop
            Console.WriteLine(new string('#', num + 4));           // static line - does not need to be in a loop
        }
    }
}
