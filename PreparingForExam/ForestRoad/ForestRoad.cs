using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //int dotsRight = n - 1;
        //int dotsLeft = 0;

        //for (int i = 0; i < 2*n -1; i++)
        //{
        //    Console.Write(new string('.',dotsLeft));
        //    Console.Write("*");
        //    Console.WriteLine(new string('.',dotsRight));
        //    if (i < n - 1)
        //    {
        //        dotsLeft++;
        //        dotsRight--;
        //    }
        //    else
        //    {
        //        dotsLeft--;
        //        dotsRight++; ;
        //    }
        //}

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <=n ; j++)
            {
                if (i == j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }


        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= 4; j++)
            {
                if (i == j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}