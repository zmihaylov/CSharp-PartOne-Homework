//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        byte bitAtPositionP = (byte)((n >> p) & 1);
        Console.WriteLine("bit at #{0} is {1}",p,bitAtPositionP);
    }
}