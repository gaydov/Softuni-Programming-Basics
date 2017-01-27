using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimefortheExam
{
    class OnTimefortheExam
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());  // the start hour of the exam
            int minExam = int.Parse(Console.ReadLine()); // the staring minutes of the exam
            int arrivalHour = int.Parse(Console.ReadLine()); // the hour when the student arrives
            int arrivalMin = int.Parse(Console.ReadLine()); // the minutes when the student arrives
            int examTimeInMins = hourExam * 60 + minExam; // converting the exam hours to minutes in order to be easier for calculations
            int arrivalTimeInMins = arrivalHour * 60 + arrivalMin; // converting the arrival hour in minutes

            if (arrivalTimeInMins > examTimeInMins)
            {
                Console.WriteLine("Late");
            }
            else if (examTimeInMins - arrivalTimeInMins <= 30)
            {
                Console.WriteLine("On time");
            }
            else if (examTimeInMins - arrivalTimeInMins > 30)
            {
                Console.WriteLine("Early");
            }

            if (examTimeInMins - arrivalTimeInMins != 0)
            {
                if (examTimeInMins - arrivalTimeInMins < 60 && examTimeInMins - arrivalTimeInMins > 0)
                {
                    Console.WriteLine("{0} minutes before the start", examTimeInMins - arrivalTimeInMins);
                }
                else if (examTimeInMins - arrivalTimeInMins >= 60)
                {
                    Console.WriteLine("{0}:{1:D2} hours before the start", ((examTimeInMins - arrivalTimeInMins) / 60), ((examTimeInMins - arrivalTimeInMins) % 60));
                }
                else if (arrivalTimeInMins - examTimeInMins < 60)
                {
                    Console.WriteLine("{0} minutes after the start", arrivalTimeInMins - examTimeInMins);
                }
                else if (arrivalTimeInMins - examTimeInMins >= 60)
                {
                    Console.WriteLine("{0}:{1:D2} hours after the start", ((arrivalTimeInMins - examTimeInMins) / 60), ((arrivalTimeInMins - examTimeInMins) % 60));
                }
            }
        }
    }
}
