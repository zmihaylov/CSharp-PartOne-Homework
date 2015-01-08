//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValues
{
    static void Main()
    {
        int? one = null;
        double? two = null;

        Console.WriteLine("Integer value is: {0}",one);
        Console.WriteLine("Double value is: {0}",two);

        one += 10;
        two += 10.5;

        Console.WriteLine("\nAdded some number: ");
        Console.WriteLine("Integer value is: {0}", one);
        Console.WriteLine("Double value is: {0}", two);

        one = one.GetValueOrDefault() + 10;
        two = two.GetValueOrDefault() + 10.50;

        Console.WriteLine("\nAdded some number, with the method GetValueOrDefault(): ");
        Console.WriteLine("Integer value is: {0}", one);
        Console.WriteLine("Double value is: {0}", two);
    }
}