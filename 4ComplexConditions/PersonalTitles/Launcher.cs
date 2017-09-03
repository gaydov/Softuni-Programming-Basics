using System;

namespace PersonalTitles
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();

            if (age >= 16)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else if (gender == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }
            else
            {
                if (gender == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
