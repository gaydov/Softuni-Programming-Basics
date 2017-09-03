using System;

namespace Fox
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = (2 * n) + 3;

            // drawing the upper part of the figure:
            for (int upperRow = 1; upperRow <= n; upperRow++)
            {
                int middle = width - (2 * upperRow) - 2; // variable "middle" is created by subtracting the left and right parts from the width of the figure
                Console.WriteLine("{0}\\{1}/{0}", new string('*', upperRow), new string('-', middle));
            }

            // drawing the middle part of the figure:
            for (int middleRow = 0; middleRow < n / 3; middleRow++)
            {
                int middle = width - 4 - (2 * ((n / 2) + middleRow)); // variable "middle" is created by subtracting the left and right parts from the width of the figure
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', (n / 2) + middleRow), new string('*', middle));
            }

            // drawing the bottom part of the figure:
            for (int bottomRow = 1; bottomRow <= n; bottomRow++)
            {
                int middle = width - (2 * bottomRow) - 2; // variable "middle" is created by subtracting the left and right parts from the width of the figure
                Console.WriteLine("{0}\\{1}/{0}", new string('-', bottomRow), new string('*', middle));
            }
        }
    }
}
