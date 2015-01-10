//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 < n < 100).

using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger twoTimesNFact = 1;
        BigInteger nFact = 1;
        BigInteger plusOneNFact = 1;

        for (int i = 1; i <= 2*n ; i++)
        {
            twoTimesNFact *= i;
            if (i <= n)
            {
                nFact *= i;
            }
            if (i <= n + 1)
            {
                plusOneNFact *= i;
            }
        }

        BigInteger result = (twoTimesNFact / (plusOneNFact * nFact));
        Console.WriteLine("result = "+ result);
    }
}