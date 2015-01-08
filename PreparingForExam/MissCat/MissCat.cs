using System;

class MissCat
{
    static void Main()
    {
        //int judges = int.Parse(Console.ReadLine());
        //int cat1 = 0;
        //int cat2 = 0;
        //int cat3 = 0;
        //int cat4 = 0;
        //int cat5 = 0;
        //int cat6 = 0;
        //int cat7 = 0;
        //int cat8 = 0;
        //int cat9 = 0;
        //int cat10 = 0;

        //for (int i = 0; i < judges; i++)
        //{
        //    int currentMark = int.Parse(Console.ReadLine());

        //    switch (currentMark)
        //    {
        //        case 1: cat1++; break;
        //        case 2: cat2++; break;
        //        case 3: cat3++; break;
        //        case 4: cat4++; break;
        //        case 5: cat5++; break;
        //        case 6: cat6++; break;
        //        case 7: cat7++; break;
        //        case 8: cat8++; break;
        //        case 9: cat9++; break;
        //        case 10: cat10++; break;
        //    }
        //}

        //int max = 0;
        //int maxCat = 0;

        //if (cat1 > max)
        //{
        //    max = cat1;
        //    maxCat = 1;
        //}

        //if (cat2 > max)
        //{
        //    max = cat2;
        //    maxCat = 2;
        //}

        //if (cat3 > max)
        //{
        //    max = cat3;
        //    maxCat = 3;
        //}

        //if (cat4 > max)
        //{
        //    max = cat4;
        //    maxCat = 4;
        //}
        //if (cat5 > max)
        //{
        //    max = cat5;
        //    maxCat = 5;
        //}

        //if (cat6 > max)
        //{
        //    max = cat6;
        //    maxCat = 6;
        //}

        //if (cat7 > max)
        //{
        //    max = cat7;
        //    maxCat = 7;
        //}

        //if (cat8 > max)
        //{
        //    max = cat8;
        //    maxCat = 8;
        //}

        //if (cat9 > max)
        //{
        //    max = cat9;
        //    maxCat = 9;
        //}

        //if (cat10 > max)
        //{
        //    max = cat10;
        //    maxCat = 10;
        //}
        //Console.WriteLine(maxCat);


        int judge = int.Parse(Console.ReadLine());
        int[] cats = new int[11];

        for (int i = 0; i < judge; i++)
        {
            int points = int.Parse(Console.ReadLine());
            cats[points]++;
        }

        int max = 0;
        int maxCat = 0;
        for (int i = 1; i <= 10; i++)
        {
            if (cats[i] > max )
            {
                max = cats[i];
                maxCat = i;
            }
        }

        Console.WriteLine(maxCat);
    }
}