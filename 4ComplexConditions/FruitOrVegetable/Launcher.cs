using System;

namespace FruitOrVegetable
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            string product = Console.ReadLine();

            // creating 2 boolean variables to check if the product is fruit or vegetable:
            bool isFruit = false;
            bool isVegetable = false;

            switch (product)
            {
                case "banana":
                    isFruit = true;
                    break;
                case "apple":
                    isFruit = true;
                    break;
                case "kiwi":
                    isFruit = true;
                    break;
                case "lemon":
                    isFruit = true;
                    break;
                case "grapes":
                    isFruit = true;
                    break;
                case "cherry":
                    isFruit = true;
                    break;
                case "tomato":
                    isVegetable = true;
                    break;
                case "cucumber":
                    isVegetable = true;
                    break;
                case "pepper":
                    isVegetable = true;
                    break;
                case "carrot":
                    isVegetable = true;
                    break;
            }

            if (isFruit)
            {
                Console.WriteLine("fruit");
            }
            else if (isVegetable)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
