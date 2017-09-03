using System;

namespace SoftUniCamp
{
    public class Launcher
    {
        public static void Main()
        {
            int students = int.Parse(Console.ReadLine());
            int totalPeople = 0;
            int car = 0;
            int microbus = 0;
            int littleBus = 0;
            int bigBus = 0;
            int train = 0;
            double carPercent = 0;
            double microbusPercent = 0;
            double littlebusPercent = 0;
            double bigbusPercent = 0;
            double trainPercent = 0;

            for (int i = 0; i < students; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());

                if (peopleInGroup <= 5)
                {
                    car += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    microbus += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
                else if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    littleBus += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    bigBus += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
                else if (peopleInGroup > 40)
                {
                    train += peopleInGroup;
                    totalPeople += peopleInGroup;
                }

                carPercent = ((double)car / totalPeople) * 100;
                microbusPercent = ((double)microbus / totalPeople) * 100;
                littlebusPercent = ((double)littleBus / totalPeople) * 100;
                bigbusPercent = ((double)bigBus / totalPeople) * 100;
                trainPercent = ((double)train / totalPeople) * 100;
            }

            Console.WriteLine("{0:F2}%\n{1:F2}%\n{2:F2}%\n{3:F2}%\n{4:F2}%", carPercent, microbusPercent, littlebusPercent, bigbusPercent, trainPercent);
        }
    }
}
