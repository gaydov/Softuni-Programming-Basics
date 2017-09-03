using System;

namespace GreetingbyName
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
