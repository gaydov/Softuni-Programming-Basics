using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = -1;  // give the price a negative value and if the value does not change during the code 
                                // the input data is incorrect and it will print "error"
            double result = 0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    price = 2.5;
                }
                else if (fruit == "apple")
                {
                    price = 1.2;
                }
                else if (fruit == "orange")
                {
                    price = 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.7;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.5;
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.7;
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                }
                else if (fruit == "orange")
                {
                    price = 0.9;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.6;
                }
                else if (fruit == "kiwi")
                {
                    price = 3;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.6;
                }
                else if (fruit == "grapes")
                {
                    price = 4.2;
                }
            }

            result = price * quantity;

            if (price != -1)
            {
                Console.WriteLine("{0:f2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
