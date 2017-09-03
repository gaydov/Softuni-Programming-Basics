using System;

namespace Money
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());
            bitcoins = bitcoins * 1168;
            yuans = yuans * 0.15; // converting yuans to dollars
            yuans = yuans * 1.76; // converting the yuans in dollars to levs
            double total = (bitcoins + yuans) / 1.95;
            comission = total * (comission / 100);
            double result = total - comission;
            Console.WriteLine(result);
        }
    }
}
