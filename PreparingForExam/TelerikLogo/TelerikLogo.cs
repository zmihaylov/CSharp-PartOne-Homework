using System;

class TelerikLogo
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());

        int width = (x + x) + ((x / 2) + 1) + ((x / 2) + 1) - 3;
        int hornsLength = x / 2;
        int middleDots = width - 2 * (x / 2 + 1);

        Console.Write(new string('.',hornsLength));
        Console.Write("*");
        Console.Write(new string('.',middleDots));
        Console.Write("*");
        Console.WriteLine(new string('.', hornsLength));

        middleDots -= 2;

        int firstHornDots = x / 2 - 1;
        int dotsAfterHorn = 0;
        for (int i = 1; i < x - 1; i++)
        {

            if (i <= x / 2)
            {
                Console.Write(new string('.',firstHornDots));
                Console.Write("*");
                Console.Write(new string('.',dotsAfterHorn));
                
            }
            else
            {
                Console.Write(new string('.', hornsLength));
            }


            Console.Write(new string('.',i));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', i));

            if (i <= x / 2)
            {
                Console.Write(new string('.', dotsAfterHorn));
                Console.Write("*");
                Console.Write(new string('.', firstHornDots));
                dotsAfterHorn++;
                firstHornDots--;
            }
            else
            {
                Console.Write(new string('.', hornsLength));
            }
            middleDots -= 2;
            Console.WriteLine();
        }

        Console.Write(new string('.',width/2));
        Console.Write("*");
        Console.WriteLine(new string('.', width / 2));


        int outDots = x - 2;
        middleDots = 1;

        for (int i = 0; i < x - 1; i++)
        {
            Console.Write(new string('.', hornsLength));
            Console.Write(new string('.', outDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', outDots));
            Console.WriteLine(new string('.', hornsLength));

            middleDots += 2;
            outDots--;
        }

        outDots = 1;
        middleDots -= 4;
        for (int i = 0; i < x - 2; i++)
        {

            Console.Write(new string('.', hornsLength));
            Console.Write(new string('.', outDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', outDots));
            Console.WriteLine(new string('.', hornsLength));

            outDots++;
            middleDots -= 2;
        }

        Console.Write(new string('.', width / 2));
        Console.Write("*");
        Console.WriteLine(new string('.', width / 2));
    }
}
