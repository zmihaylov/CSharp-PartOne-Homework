//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number = ");
        string binary = Console.ReadLine();
        int decimalNumber = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            decimalNumber += int.Parse(binary[i].ToString()) * (int)Math.Pow(2, binary.Length - 1 - i); 
        }
        Console.WriteLine("Decimal number = " + decimalNumber);
    }
}
