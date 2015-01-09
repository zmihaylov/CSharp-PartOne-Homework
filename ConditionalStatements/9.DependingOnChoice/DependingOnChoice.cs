//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
class DependingOnChoice
{
    static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();
        int intNum;
        double doubleNum;

        bool isItInt = int.TryParse(input, out intNum);
        bool isItDouble = double.TryParse(input, out doubleNum);

        int choice = 0;
        if (isItInt)
        {
            choice = 1;
        }
        else if (isItDouble)
        {
            choice = 2;
        }
        else
        {
            choice = 3;
        }

        switch (choice)
        {
            case 1: 
                intNum += 1;
                Console.WriteLine("Integer number = " + intNum);
                break;
            case 2:
                doubleNum += 1;
                Console.WriteLine("Double number = "+ doubleNum);
                break;
            case 3:
                input += "*";
                Console.WriteLine(input);
                break;
        }

    }
}