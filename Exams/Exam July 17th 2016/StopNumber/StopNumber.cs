using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNumber
{
    class StopNumber
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            for (int i = M; M >= N; M--)
            {
                if ((M % 2 == 0 && M % 3 == 0) && M != S) // if the number is valid and is different from S we print it
                {
                    Console.Write("{0} ", M);
                }

                // if the number is valid and is equal to S we give M value of 0 
                // which will terminate the loop because -1 is less than N:

                else if ((M % 2 == 0 && M % 3 == 0) && M == S) 
                {
                    M = 0;
                }
            }
            Console.WriteLine();
        }
    }
}
