using System;

class QuadronacciRectangle
{
    static void Main()
    {
        
        long[] firstFour = new long[4];

        for (int i = 0; i < 4; i++)
        {
            firstFour[i] = long.Parse(Console.ReadLine());
        }

        

        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        long[] quadronacci = new long[rows * cols];

        long[,] matrix = new long[rows, cols];

        for (int i = 0; i < firstFour.Length; i++)
        {
            quadronacci[i] = firstFour[i];
        }

        for (int i = 4; i < quadronacci.Length; i++)
        {
            quadronacci[i] = quadronacci[i - 1] + quadronacci[i - 2] + quadronacci[i - 3] + quadronacci[i - 4];
        }

        int count = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = quadronacci[count];
                count++;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}