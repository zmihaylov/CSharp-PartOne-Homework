//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int n = int.Parse(Console.ReadLine());
        string binary = "";

        if (n == 0)
        {
            binary = "0";
        }
        while (n != 0)
        {
            binary = n % 2 + binary;
            n /= 2;
        }
        Console.WriteLine(binary);
    }
}