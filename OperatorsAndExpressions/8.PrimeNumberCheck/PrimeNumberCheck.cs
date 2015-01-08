using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        bool prime = false;

        if (n > 1 && n < 101)
        {
            if (n == 2 || n == 3 || n == 5 || n == 7)
            {
                prime = true;
            }
            else if (n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0)
            {
                prime = true;
            }
        }
        Console.WriteLine("Prime? --> " + prime);
    }
}