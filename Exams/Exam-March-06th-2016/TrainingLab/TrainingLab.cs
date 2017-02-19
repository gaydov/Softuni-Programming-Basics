using System;

namespace TrainingLab
{
    class TraingingLab
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            width = width * 100;
            height = (height * 100) - 100;
            double desksPerRow = Math.Truncate(height / 70);
            double rows = Math.Truncate(width / 120);
            double seats = rows * desksPerRow - 3;

            Console.WriteLine(seats);
        }
    }
}
