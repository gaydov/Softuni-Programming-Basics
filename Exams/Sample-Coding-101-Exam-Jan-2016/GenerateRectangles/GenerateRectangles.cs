using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangles
{
    class GenerateRectangles
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int area = 0;
            bool doesATriangleExist = false; // we define this bool variable and if this remain false the output will be "No"

            for (int L = -n; L <= n; L++)
            {
                for (int T = -n; T <= n; T++)
                {
                    for (int R = L; R <= n; R++)
                    {
                        for (int B = T; B <= n; B++)
                        {
                            area = (R - L) * (B - T);

                            // checking if the conditions are met and printing the result:
                            if (area >= m &&
                                (-n <= L && L < R && R <= n) &&
                                (-n <= T && T < B && B <= n))
                            {
                                Console.WriteLine($"({L}, {T}) ({R}, {B}) -> {area}");
                                doesATriangleExist = true;
                            }
                        }
                    }
                }
            }

            if (doesATriangleExist == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
