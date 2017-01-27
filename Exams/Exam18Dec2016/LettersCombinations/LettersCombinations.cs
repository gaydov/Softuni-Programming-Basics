using System;

namespace LettersCombinations
{
    public class LettersCombinations
    {
        public static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skipped = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char firstLetter = start; firstLetter <= end; firstLetter++)
            {
                if (firstLetter == skipped)
                {
                    continue;
                }

                for (char secondLetter = start; secondLetter <= end; secondLetter++)
                {
                    if (secondLetter == skipped)
                    {
                        continue;
                    }

                    for (char thirdLetter = start; thirdLetter <= end; thirdLetter++)
                    {
                        if (thirdLetter == skipped)
                        {
                            continue;
                        }

                        Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
