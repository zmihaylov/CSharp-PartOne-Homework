//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

class ComapreFloats
{
    static void Main()
    {
        Console.Write("Enter first floating point number: ");
        double one = double.Parse(Console.ReadLine());

        Console.Write("Enter second floating point number: ");
        double two = double.Parse(Console.ReadLine());

        bool equal = Math.Abs(one - two) < 0.000001;

        Console.WriteLine("{0} == {1} ---> {2}",one,two,equal);
    }
}