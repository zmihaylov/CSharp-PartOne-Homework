//Write a program to print the numbers 
//1, 101 and 1001, each at a separate line.
//Name the program correctly.

using System;

class PrintNumbers
{
    static void Main()
    {
        for (int i = 1; i <= 9 ; i+=4)
        {
            Console.WriteLine(Convert.ToString(i,2));
        }
    }
}