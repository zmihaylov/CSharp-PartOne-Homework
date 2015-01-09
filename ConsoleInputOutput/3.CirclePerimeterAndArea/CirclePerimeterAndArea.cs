//Write a program that reads the radius r of a circle and prints its perimeter 
//and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius = ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        double perimeter = Math.PI * 2 * radius;

        Console.WriteLine("S = {0:F2}",area);
        Console.WriteLine("P = {0:F2}",perimeter);
    }
}