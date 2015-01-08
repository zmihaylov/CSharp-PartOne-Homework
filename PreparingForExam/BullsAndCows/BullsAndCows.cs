using System;
using System.Collections.Generic;

class BullsAndCows
{
    static void Main()
    {
        string secretNum = Console.ReadLine();
        int targetBulls = int.Parse(Console.ReadLine());
        int targetCows = int.Parse(Console.ReadLine());
        const char usedSecretNum = '*';
        const char usedGuessNum = '@';

        List<int> results = new List<int>();

        for (int num = 1000; num <= 9999; num++) //!!!!
        {
            int countFoundBulls = 0;
            int countFoundCows = 0;

            char[] guessDigits = num.ToString().ToCharArray();

            char[] secretNumDigits = secretNum.ToCharArray();

            if (guessDigits[0] >= '1' && guessDigits[1] >= '1' &&
                guessDigits[2] >= '1' && guessDigits[3] >= '1')
            {
                for (int i = 0; i < guessDigits.Length; i++)
                {
                    if (guessDigits[i] == secretNumDigits[i])
                    {
                        countFoundBulls++;
                        guessDigits[i] = usedGuessNum;
                        secretNumDigits[i] = usedSecretNum;
                    }
                }

                for (int secretIndex = 0; secretIndex < secretNumDigits.Length; secretIndex++)
                {
                    for (int guessIndex = 0; guessIndex < guessDigits.Length; guessIndex++)
                    {
                        if (secretNumDigits[secretIndex] == guessDigits[guessIndex])
                        {
                            countFoundCows++;
                            guessDigits[guessIndex] = usedGuessNum;
                            secretNumDigits[secretIndex] = usedSecretNum;
                        }
                    }
                }
                if (countFoundCows == targetCows && countFoundBulls == targetBulls)
                {
                    results.Add(num);
                }
            }
        }
        if (results.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = 0; i < results.Count; i++)
            {
                Console.Write(results[i] + " ");
            }
        }
        Console.WriteLine();
    }
}