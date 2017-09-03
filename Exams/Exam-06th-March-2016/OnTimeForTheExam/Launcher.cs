using System;

namespace OnTimefortheExam
{
    public class OnTimefortheExam
    {
        public static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            int examTimeInMins = (hourExam * 60) + minExam;
            int arrivalTimeInMins = (arrivalHour * 60) + arrivalMin;

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
                    Console.WriteLine("{0}:{1:D2} hours before the start", (examTimeInMins - arrivalTimeInMins) / 60, (examTimeInMins - arrivalTimeInMins) % 60);
                }
                else if (arrivalTimeInMins - examTimeInMins < 60)
                {
                    Console.WriteLine("{0} minutes after the start", arrivalTimeInMins - examTimeInMins);
                }
                else if (arrivalTimeInMins - examTimeInMins >= 60)
                {
                    Console.WriteLine("{0}:{1:D2} hours after the start", (arrivalTimeInMins - examTimeInMins) / 60, (arrivalTimeInMins - examTimeInMins) % 60);
                }
            }
        }
    }
}
