//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        while (a.CompareTo(b) == 1)
        {
            Console.WriteLine("{0} is greater",a);
            break;
        }
        while (a.CompareTo(b) == -1)
        {
            Console.WriteLine("{0} is greater",b);
            break;
        }
        while (a.CompareTo(b) == 0)
        {
            Console.WriteLine("{0} == {1}",a,b);
            break;
        }
    }
}
