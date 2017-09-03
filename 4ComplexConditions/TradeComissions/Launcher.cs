using System;

namespace TradeComissions
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = -1; // we give the commission a negative value and if the value does not change during the code 
            double result = 0;      // we will print that the input data is invalid

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.08;
                }
                else if (sales > 10000)
                {
                    commission = 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.1;
                }
                else if (sales > 10000)
                {
                    commission = 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.12;
                }
                else if (sales > 10000)
                {
                    commission = 0.145;
                }
            }

            result = sales * commission;
            if (commission != -1)
            {
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
