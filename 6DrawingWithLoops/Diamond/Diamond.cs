using System;

namespace Diamond
{
    public class Diamond
    {
        public static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int leftRightDashes = (width - 1) / 2;

            // drawing the upper part of the figure:
            for (int rowUpperPart = 1; rowUpperPart <= (width + 1) / 2; rowUpperPart++)
            {
                int midDashesUpper = width - 2 - 2 * leftRightDashes;
                Console.Write("{0}*", new string('-', leftRightDashes));
                if (midDashesUpper >= 0)
                {
                    Console.Write("{0}*", new string('-', midDashesUpper));
                }
                Console.WriteLine("{0}", new string('-', leftRightDashes));
                leftRightDashes--;
            }

            // drawing the lower part of the figure:
            for (int rowLowerPart = 1; rowLowerPart <= (width - 1) / 2; rowLowerPart++)
            {
                int midDashesLower = width - 2 * rowLowerPart - 2;
                Console.Write("{0}*", new string('-', rowLowerPart));
                if (midDashesLower >= 0)
                {
                    Console.Write("{0}*", new string('-', midDashesLower));
                }
                Console.WriteLine("{0}", new string('-', rowLowerPart));
            }
        }
    }
}
