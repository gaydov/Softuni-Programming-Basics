using System;

namespace Hospital
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int examinedPatients = 0;
            int notExaminedPatients = 0;
            int doctors = 7;
            int examinedSum = 0;
            int notExaminedSum = 0;

            for (int i = 1; i <= period; i++)
            {
                // condition when new doctors are assinged
                if (i % 3 == 0 && notExaminedSum > examinedSum) 
                {
                    doctors++;
                }

                int arrivingPatiens = int.Parse(Console.ReadLine());

                if (arrivingPatiens >= doctors)
                {
                    examinedPatients = doctors;
                    notExaminedPatients = arrivingPatiens - doctors;
                }
                else
                {
                    examinedPatients = arrivingPatiens;
                    notExaminedPatients = 0; // if the doctors are more than the patients so all the pations are examined
                }

                examinedSum += examinedPatients;
                notExaminedSum += notExaminedPatients;
            }

            Console.WriteLine("Treated patients: {0}.", examinedSum);
            Console.WriteLine("Untreated patients: {0}.", notExaminedSum);
        }
    }
}
