using System;

namespace SumSeconds
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int player1Time = int.Parse(Console.ReadLine());
            int player2Time = int.Parse(Console.ReadLine());
            int player3Time = int.Parse(Console.ReadLine());
            int totalSecs = player1Time + player2Time + player3Time;
            if (totalSecs > 0 && totalSecs <= 59)
            {
                Console.WriteLine("0:{0}", totalSecs.ToString().PadLeft(2, '0')); // formating the result to be string and with leading zeros
            }
            else if (totalSecs >= 60 && totalSecs <= 119)
            {
                Console.WriteLine("1:{0}", (totalSecs - 60).ToString().PadLeft(2, '0')); // formating the result to be string and with leading zeros
            }
            else if (totalSecs >= 120 && totalSecs <= 179)
            {
                Console.WriteLine("2:{0}", (totalSecs - 120).ToString().PadLeft(2, '0')); // formating the result to be string and with leading zeros
            }
        }
    }
}
