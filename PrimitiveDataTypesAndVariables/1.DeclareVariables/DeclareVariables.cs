//Declare five variables choosing for each of them the most appropriate of the types
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class DeclareFiveVariables
{
    static void Main()
    {
        ushort numberOne = 52130;
        sbyte numberTwo = -115;
        int numberThree = 4825932;
        byte numberFour = 97;
        short numberFive = -10000;

        Console.WriteLine("{0} {1} {2} {3} {4}", numberOne, numberTwo, numberThree, numberFour, numberFive);
    }
}

