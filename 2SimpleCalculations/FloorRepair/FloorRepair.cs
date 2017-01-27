using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorRepair
{
    class FloorRepair
    {
        static void Main(string[] args)
        {
            int playgroundSide = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLength = int.Parse(Console.ReadLine());
            int area = (playgroundSide * playgroundSide) - (benchWidth * benchLength); // calculatiing the area that needs to be covered
            double tiles = area / (tileWidth * tileLength); // calculating how many tiles we need
            double time = tiles * 0.2; // calculatiing the time needed 
            Console.WriteLine("{0}\n{1}", tiles, time); 
        }
    }
}
