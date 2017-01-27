using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class TraingingLab
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            width = width * 100;
            height = (height * 100) - 100; // removing the 1m for the corridor
            double desksPerRow = Math.Truncate(height / 70);
            double rows = Math.Truncate(width / 120);
            double seats = rows * desksPerRow - 3; // removing the spaces for the door and the desk
            Console.WriteLine(seats);
        }
    }
}
