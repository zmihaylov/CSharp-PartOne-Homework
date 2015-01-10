//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;
class PrintDeckCards
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            char card = 'A';
            switch (i)
            {
                case 11: card = 'J'; ; break;
                case 12: card = 'Q'; break;
                case 13: card = 'K'; break;
                case 14: card = 'A'; break;
                default: break;
            }
            if (i < 11)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (j)
                    {
                        case 0: Console.Write("{0} of spades, ", i); break;
                        case 1: Console.Write("{0} of hearts, ", i); break;
                        case 2: Console.Write("{0} of clubs, ", i); break;
                        case 3: Console.Write("{0} of diamonds", i); break;
                    }
                }
            }
            else
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (j)
                    {
                        case 0: Console.Write("{0} of spades, ", card); break;
                        case 1: Console.Write("{0} of hearts, ", card); break;
                        case 2: Console.Write("{0} of clubs, ", card); break;
                        case 3: Console.Write("{0} of diamonds", card); break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}