//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;
class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        string str = Console.ReadLine();
        int firstNum = int.Parse(str);

        Console.Write("Enter second number: ");
        str = Console.ReadLine();
        int secondNum = int.Parse(str);

        int gcd = 1;

        if (firstNum == 0)
        {
            Console.WriteLine("The GCD is " + secondNum);
        }
        else if (secondNum == 0)
        {
            Console.WriteLine("The GCD is " + firstNum);
        }
        else
        {
            if (firstNum < secondNum)
            {
                int temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
            }
            while (gcd != 0)
            {
                gcd = firstNum % secondNum;
                firstNum = secondNum;
                secondNum = gcd;
            }
            Console.WriteLine("GCD is " + firstNum);
        }
    }
}