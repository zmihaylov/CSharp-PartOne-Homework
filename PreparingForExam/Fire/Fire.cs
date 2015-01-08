using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outDots = (n / 2) - 1;
        int inDots = 0;
        int count = (n/2 + n/4);

        for (int i = 0; i < count; i++)
        {
            Console.Write(new string('.',outDots));
            Console.Write("#");
            Console.Write(new string('.', inDots));
            Console.Write("#");
            Console.WriteLine(new string('.', outDots));

            if (i < (n / 2) - 1 )
            {
                outDots--;
                inDots+=2;
            }
            else if (i == (n /2) - 1)
            {
                continue;
            }
            else
            {
                outDots++;
                inDots-=2;
            }
        }
        Console.WriteLine(new string('-',n));

        outDots = 0;
        int slash = n / 2;

        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string('.',outDots));
            Console.Write(new string('\\',slash));
            Console.Write(new string('/', slash));
            Console.WriteLine(new string('.', outDots));

            outDots++;
            slash--;
        }
    }
}