using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaandPerimeter
{
    class CircleAreaandPerimeter
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = {0}", Math.PI * Math.Pow(radius, 2)); 
            Console.WriteLine("Perimeter = {0}", 2 * Math.PI * radius);
        }
    }
}
