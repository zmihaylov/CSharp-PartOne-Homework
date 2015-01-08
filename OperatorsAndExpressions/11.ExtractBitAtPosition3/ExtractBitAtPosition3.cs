//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
using System;

class ExtractBitAtPosition3
{
    static void Main()
    {
        Console.Write("Enter uint: ");
        uint n = uint.Parse(Console.ReadLine());
        byte bitAtPositionThree = (byte)((n >> 3) & 1);
        Console.WriteLine("bit at #3 is " + bitAtPositionThree);
    }
}