using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsOfEquaSums
{
    class GroupsOfEquaSums
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            if (n1 == (n2 + n3 + n4))
            {
                Console.WriteLine($"Yes\n{n1}");
            }
            else if (n2 == (n1 + n3 + n4))
            {
                Console.WriteLine($"Yes\n{n2}");
            }
            else if (n3 == (n1 + n2 + n4))
            {
                Console.WriteLine($"Yes\n{n3}");
            }
            else if (n4 == (n1 + n2 + n3))
            {
                Console.WriteLine($"Yes\n{n4}");
            }
            else if (n1 + n2 == n3 + n4)
            {
                Console.WriteLine($"Yes\n{n1 + n2}");
            }
            else if (n1 + n3 == n2 + n4)
            {
                Console.WriteLine($"Yes\n{n1 + n3}");
            }
            else if (n1 + n4 == n2 + n3)
            {
                Console.WriteLine($"Yes\n{n1 + n4}");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
