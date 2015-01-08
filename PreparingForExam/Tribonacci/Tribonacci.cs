using System;
using System.Numerics;
class Tribonacci
{
    static void Main()
    {
        BigInteger first = int.Parse(Console.ReadLine());
        BigInteger second = int.Parse(Console.ReadLine());
        BigInteger third = int.Parse(Console.ReadLine());

        int n = int.Parse(Console.ReadLine()); // if n < 3 shte grumne za da ne stane taka trqbva da se napravqt proverka
        BigInteger[] tribonacci = new BigInteger[n];

        if (n >= 1)
        {
            tribonacci[0] = first;
        }
        if (n >= 2)
        {
            tribonacci[1] = second;
        }
        if (n >= 3)
        {
            tribonacci[2] = third;
        }
        if (n>3)
        {
            for (int i = 3; i < n; i++)
            {
                tribonacci[i] += tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
            }
        }

        Console.WriteLine(tribonacci[n - 1]);
    }
}