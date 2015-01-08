//Write a Boolean expression that checks for given integer if it can be divided (without remainder)
//by 7 and 5 at the same time.
using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        bool divide = ((number % 7)) == 0 && ((number % 5) == 0);
        Console.WriteLine("Is {0} divisible by 5 and 7 at the same time ---> {1}",number,divide);
    }
}
