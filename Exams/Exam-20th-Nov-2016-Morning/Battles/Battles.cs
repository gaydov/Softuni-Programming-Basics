using System;

namespace Battles
{
    public class Battles
    {
        public static void Main()
        {
            int player1Poks = int.Parse(Console.ReadLine());
            int player2Poks = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());

            int p1LastUsedPok = 0;
            int p2LastUsedPok = 0;
            int battlesCounter = 0;

            for (int battle = 1; battle <= maxBattles; battle++)
            {
                for (int p1Pok = 1; p1Pok <= player1Poks; p1Pok++)
                {
                    for (int p2Pok = 1; p2Pok <= player2Poks; p2Pok++)
                    {
                        Console.Write("({0} <-> {1}) ", p1Pok, p2Pok);
                        p1LastUsedPok = p1Pok;
                        p2LastUsedPok = p2Pok;
                        battlesCounter++;

                        // if the players have used the last of their pokemons(e.g. player1 has 3 pokemons and in the last battle he used number 3 and player2 has 2 pokemons and in the last battle he used number 2) 
                        // OR the battles are equal to the maximum battles then we exit the main method:
                        if ((p1LastUsedPok == player1Poks && p2LastUsedPok == player2Poks) || battlesCounter == maxBattles)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}
