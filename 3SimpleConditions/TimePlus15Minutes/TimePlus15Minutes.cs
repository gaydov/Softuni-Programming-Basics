using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            mins = mins + 15;
            if (mins > 59)
            {
                mins -= 60;
                hour += 1;
                if (hour > 23)
                {
                    hour = 0;
                }
            }
            Console.WriteLine("{0}:{1}", hour, mins.ToString("00"));
        }
    }
}
