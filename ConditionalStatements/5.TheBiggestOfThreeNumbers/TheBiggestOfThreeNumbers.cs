//Write a program that finds the biggest of three numbers.

using System;
class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Biggest: " + a);
            }
            else
            {
                Console.WriteLine("Biggest: " + c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("Biggest: " + b);
            }
            else
            {
                Console.WriteLine("Biggest: " + c);
            }
        }
    }
}
