//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum3x3
{
    private static void EnterMatrix(int[,] matrix)  //standart input method
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("Please enter element[{0},{1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static void PrintMatrixFromIndex(int startI, int startJ, int[,] matrix, int rep1, int rep2) //printing a given  submatrix from a given indexes
    {
        for (int i = startI; i < rep1+startI; i++)
        {
            for (int j = startJ; j < rep2+startJ; j++)
            {
                Console.Write("{0,3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Please enter number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter number M: ");
        int m = int.Parse(Console.ReadLine());
        if (n < 3 || m < 3)
        {
            Console.WriteLine("The entered matrix is smaller than 3x3!");
            Environment.Exit(0);
        }
        int[,] matrix = new int[n, m];
        EnterMatrix(matrix);
        Console.WriteLine("The matrix you've entered: ");
        PrintMatrixFromIndex(0, 0, matrix,n,m);
        int wantedI = 0;
        int wantedJ = 0;
        int maxSum = int.MinValue;
        int tempSum = 0;
        for (int i = 0; i <= matrix.GetLength(0)-3; i++)    //iterates through the whole matrix
        {
            for (int j = 0; j <= matrix.GetLength(1)-3; j++)
            {
                tempSum=(matrix[i,j]+matrix[i+1,j]+matrix[i+2,j]    //searches for the maximal sum 3x3 elements
                        +matrix[i,j+1]+matrix[i+1,j+1]+matrix[i+2,j+1]
                        +matrix[i,j+2]+matrix[i+1,j+2]+matrix[i+2,j+2]);
                if (tempSum>maxSum)
                {
                    maxSum = tempSum;
                    wantedI = i;
                    wantedJ = j;
                    tempSum = int.MinValue;
                }
            }
        }
        Console.WriteLine("The 3x3 square with maximal sum: ");
        PrintMatrixFromIndex(wantedI, wantedJ, matrix,3,3);     //prints the result
    }
}
