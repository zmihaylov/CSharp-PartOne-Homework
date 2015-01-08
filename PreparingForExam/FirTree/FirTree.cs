using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int stars = 3;
        int dots = n - 2;

        string firstLine = new string('.', dots) + "*" + new string('.', dots);
        Console.WriteLine(firstLine);

        dots--;
        for (int i = 1; i < n - 1; i++)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('.', dots));

            dots--;
            stars += 2;
        }
        Console.WriteLine(firstLine);
        
    }
}

