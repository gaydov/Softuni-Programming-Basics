using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomSleepingCat
{
    class TomSleepingCat
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());
            int playingMins = ((365 - holidays) * 63) + (holidays * 127);

            if (playingMins < 30000)
            {
                int hours = ((30000 - playingMins) / 60);
                int mins = ((30000 - playingMins) % 60);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, mins);
            }
            else
            {
                int hours = ((playingMins - 30000) / 60);
                int mins = ((playingMins - 30000) % 60);
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, mins);
            }
        }
    }
}
