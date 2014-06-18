//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
using System;

class PrintMatrixB
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void FillMatrix(int[,] matrix)
    {
        int counter = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 1)     //if the column number is odd
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    matrix[j, i] = counter;
                    counter++;
                }
            }
            else               //if the column number is even
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = counter;
                    counter++;
                }
            }
        }
    }
    static void Main()
    {
        Console.Write("Please enter the size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        FillMatrix(matrix);
        PrintMatrix(matrix);

    }
}
