using System;

class UpDownGame
{
    static void Main()
    {
        Console.WriteLine("Up-Down Game");
        Console.WriteLine("Try to guess the number (from 1 to 100)");

        Random generatedNumber = new Random();

        int endGameNumber = generatedNumber.Next(1, 101);
        int min = 1;
        int max = 100;
        while (true)
        {
            Console.Write("Enter your number between {0} and {1}: ", min,max);

            string readNumberString = Console.ReadLine();

            int userNumber;

            bool parsedNumber = int.TryParse(readNumberString, out userNumber);

            if (parsedNumber)
            {
                if (userNumber == endGameNumber)
                {
                    Console.WriteLine("Congratulations. You won!");
                    break;
                }
                else if (userNumber > endGameNumber)
                {
                    if (userNumber > max)
                    {
                        continue;
                    }
                    max = userNumber - 1;
                    Console.WriteLine("DOWN!!!");
                }
                else if (userNumber < endGameNumber)
                {
                    if (userNumber < min)
                    {
                        continue;
                    }
                    min = userNumber + 1;
                    Console.WriteLine("UP!!!");
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
                continue;
            }
        }
    }
}