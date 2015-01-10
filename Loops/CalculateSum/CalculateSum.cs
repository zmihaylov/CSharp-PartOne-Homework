//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;
class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1;
        decimal power = 1;
        decimal factoriel = 1;

        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            power *= x;
            sum += factoriel / power;
        }
        Console.WriteLine("Sum = {0:F5}",sum);
    }
}
