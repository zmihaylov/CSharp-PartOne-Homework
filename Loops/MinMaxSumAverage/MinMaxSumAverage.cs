//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;
class MinMaxSumAverage
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        double avg = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int newNum = int.Parse(Console.ReadLine());

            if (newNum > max)
            {
                max = newNum;
            }
            if (newNum < min)
            {
                min = newNum;
            }
            sum += newNum;
        }

        avg = (double)sum / n;

        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("avg = {0:F2}", avg);
    }
}
