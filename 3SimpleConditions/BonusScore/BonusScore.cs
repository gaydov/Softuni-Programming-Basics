﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (score <= 100)
            {
                bonusPoints = 5;
            }
            else if (score > 100 && score < 1000)
            {
                bonusPoints = score * 0.2;
            }
            else if (score >= 1000)
            {
                bonusPoints = score * 0.1;
            }
            if (score % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (score % 10 == 5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(score + bonusPoints);
        }
    }
}
