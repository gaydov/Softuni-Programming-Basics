using System;

namespace Distance
{
    public class Distance
    {
        public static void Main()
        {
            int initialSpeed = int.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());

            firstTime = firstTime / 60;
            secondTime = secondTime / 60;
            thirdTime = thirdTime / 60;
            
            double initialDistance = firstTime * initialSpeed;
            double speed = initialSpeed + (initialSpeed * 0.1);
            double secondDistance = speed * secondTime;
            double thirdDistance = (speed * 0.95) * thirdTime;
            double totalDistance = initialDistance + secondDistance + thirdDistance;
            Console.WriteLine("{0:F2}", totalDistance);
        }
    }
}
