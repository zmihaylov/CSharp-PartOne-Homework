using System;
class ApplesAndOranges
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        int oddSum = 0;
        int evenSum = 0;

        while (number != 0)
        {
            int digit = (int)number % 10;

            if (digit % 2 == 0)
            {
                evenSum += digit;
            }
            else
            {
                oddSum += digit;
            }
            number /= 10;
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("both " + oddSum);
        }
        else if (oddSum > evenSum)
        {
            Console.WriteLine("oranges " + oddSum);
        }
        else
        {
            Console.WriteLine("apples " + evenSum);
        }
    }
}