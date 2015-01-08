//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());

        double area = height * width;
        double perimeter = 2 * height + 2 * width;

        Console.WriteLine("Perimeter = " + perimeter);
        Console.WriteLine("Area = " + area);
    }
}
