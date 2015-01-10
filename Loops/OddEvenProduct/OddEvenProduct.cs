//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
class OddEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] splittedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[splittedInput.Length];

        for (int i = 0; i < splittedInput.Length; i++)
        {
            numbers[i] = int.Parse(splittedInput[i]);
        }

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 != 0)
            {
                evenProduct *= numbers[i];
            }
            else
            {
                oddProduct *= numbers[i];
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Product = " + evenProduct);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Even_Product = " + evenProduct);
            Console.WriteLine("Odd_Product = " + oddProduct);
        }
    }
}
