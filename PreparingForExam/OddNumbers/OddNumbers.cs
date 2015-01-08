using System;

class OddNumbers
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        long result = long.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            result ^= int.Parse(Console.ReadLine());
        }
        Console.WriteLine(result);
    }
}

