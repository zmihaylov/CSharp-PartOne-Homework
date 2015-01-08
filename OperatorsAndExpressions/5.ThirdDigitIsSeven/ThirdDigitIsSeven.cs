//Write an expression that checks for given integer if its third digit from right-to-left is 7

using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        number /= 100;

        bool thirdDigitIsSeven = (number % 10) == 7;

        Console.WriteLine("The third digit is 7 ----> " + thirdDigitIsSeven);
    }
}
