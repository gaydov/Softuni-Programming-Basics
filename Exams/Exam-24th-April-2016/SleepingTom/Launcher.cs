using System;

namespace SleepingTom
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());
            int workDays = 365 - freeDays;
            int playMinsTotal = (freeDays * 127) + (workDays * 63);
            int playHours = playMinsTotal / 60; // converting the total mins to hours
            int playMins = playHours % 60;

            if (playMinsTotal > 30000)
            {
                int playTimeHours = (playMinsTotal - 30000) / 60;
                int playTimeMins = (playMinsTotal - 30000) % 60;
                Console.WriteLine("Tom will run away\n{0} hours and {1} minutes more for play", playTimeHours, playTimeMins);
            }
            else
            {
                int playTimeHours = (30000 - playMinsTotal) / 60;
                int playTimeMins = (30000 - playMinsTotal) % 60;
                Console.WriteLine("Tom sleeps well\n{0} hours and {1} minutes less for play", playTimeHours, playTimeMins);
            }
        }
    }
}
