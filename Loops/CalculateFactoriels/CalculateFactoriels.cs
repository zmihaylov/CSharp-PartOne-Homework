//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
class CalculateFactoriels
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        if (1 < k && k < n && n < 100)
        {
            decimal nFact = 1;
            decimal kFact = 1;

            for (int i = 1; i <= n; i++)
            {
                nFact *= i;

                if (i <= k)
                {
                    kFact *= i;
                }
            }

            decimal result = nFact / kFact;
            Console.WriteLine("Result = " + result);
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}