//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.

using System;
using System.Numerics;
class Combinations
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        int prod = n - k;

        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger prodFact = 1;

        for (int i = 1; i <= n; i++)
        {
            nFact *= i;

            if (i <= k)
            {
                kFact *= i;
            }
            if (i <= prod)
            {
                prodFact *= i;
            }
        }
        decimal result = (decimal)(nFact / (kFact * prodFact));
        Console.WriteLine("Result = {0}", result);
    }
}