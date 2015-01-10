//Write a program that reads from the console a positive integer number n (1 = n = 20)
//and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;
class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int row = 0;
        int col = 0;
        int maxRow = n - 1;
        int maxCol = n - 1;
        int count = 1;

        while (count <= n*n)
        {
            for (int i = col; i <= maxCol; i++)
            {
                matrix[row, i] = count;
                count++;
            }
            row++;

            for (int i = row; i <= maxRow; i++)
            {
                matrix[i, maxCol] = count;
                count++;
            }
            maxCol--;

            for (int i = maxCol; i >= col; i--)
            {
                matrix[maxRow, i] = count;
                count++;
            }
            maxRow--;

            for (int i = maxRow; i >= row; i--)
            {
                matrix[i, col] = count;
                count++;
            }
            col++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}