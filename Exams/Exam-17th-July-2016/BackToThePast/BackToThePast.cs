using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double legacy = double.Parse(Console.ReadLine());
            int yearUntil = int.Parse(Console.ReadLine());
            int ageCounter = 18;  // using that counter in order to increase the age with every year passed

            for (int i = 1800; i <= yearUntil; i++)
            {
                if (i % 2 == 0)
                {
                    legacy -= 12000;
                }
                else
                {
                    legacy -= (12000 + (50 * ageCounter));
                }
                ageCounter++;
            }
            
            if (legacy >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", legacy);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(legacy));
            }
        }
    }
}
