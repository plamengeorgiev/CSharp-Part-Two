//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
using System;

class PrintMatrixC
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
        for (int i = matrix.GetLength(0)-1; i >= 0; i--)    //this fills the cells below the main diagonal + the main diagonal
        {
            for (int j = 0; j <matrix.GetLength(1)-i ; j++)
            {
                matrix[i+j,j] = counter;
                counter++;
            }
        }
        for (int i = 1; i < matrix.GetLength(0); i++)    //this fills the cells over the main diagonal
        {
            for (int j = 0; j < matrix.GetLength(1) - i; j++)
            {
                matrix[j, i + j] = counter;
                counter++;
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
