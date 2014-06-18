﻿//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
using System;

class PrintMatrixA
{
    static void PrintMatrix(int[,] matrix)      //standart printing
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
    static void FillMatrix(int[,] matrix)       //standart input method
    {
        int counter = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[j, i] = counter;
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
