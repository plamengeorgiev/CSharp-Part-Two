//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 
//with a maximal sum of its elements. The first line in the input file contains the size of matrix N. 
//Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. 

using System;
using System.IO;

class ReadlingAMatrix
{
    static void Main(string[] args)
    {
        char[] separators = new char[] {' '};   //char array, containing the separators for the splitting
        int maxSum = int.MinValue;  //variable for the final result
        using (StreamReader sr = new StreamReader("matrix.txt"))    //opening the input file for reading
        {
            int n = int.Parse(sr.ReadLine());   //reading the first line - the size of the matrix
            int[,] matrix = new int[n,n];       //initiating the matrix
            for (int i = 0; i < n; i++)
            {
                string[] line = sr.ReadLine().Split(separators);    //reading line by line and splitting 
                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);  //parsing the string array, and filling the matrix
                }
            }
            
            for (int i = 0; i < matrix.GetLength(0)-1; i++) //itterrating the matrix
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i,j]+matrix[i+1,j]+matrix[i,j+1]+matrix[i+1,j+1]>maxSum) //finding the maximal sum
                    {
                        maxSum = (matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1]);
                    }
                }
            }

        }
        using (StreamWriter sw = new StreamWriter("result.txt"))    
        {
            sw.Write(maxSum);   //writing the result in a different file
        }
        Console.WriteLine("Done!");     //printing a message on the console
    }
}
