//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. Example:
using System;

class LongestSequenceInMatrix
{   //if you want to test the different methods - use the matrix below - change the elements you want and see what happens :)
    //static string[,] matrix = new string[12, 8]{{"ha","hi","ho","hi","ha","hi","ho","hi"},
    //                                            {"fo","ha","hi","xx","hi","mo","ho","hi"},
    //                                            {"xx","fo","he","he","mo","hi","he","ho"},
    //                                            {"hi","ho","fo","mo","ha","he","hi","hi"},
    //                                            {"xx","ho","mo","fo","ha","hi","ho","hi"},
    //                                            {"xx","mo","he","hi","fo","hi","ho","hi"},
    //                                            {"mo","hi","ho","hi","ha","fo","ho","fo"},
    //                                            {"xx","ha","hi","xx","hi","hi","he","hi"},
    //                                            {"xx","ho","he","hi","hu","fo","ha","fo"},
    //                                            {"xx","ho","he","hi","fo","he","hi","hi"},
    //                                            {"xx","ho","he","he","ha","hi","ho","hi"},
    //                                            {"xx","ho","fo","hi","ha","hi","ho","hi"}};
    static int maxLength = 1;   //counter for the longest sequence
    static string element = "";     //string to keep the element of the sequence
    private static void EnterMatrix(string[,] matrix)   //pretty standart...
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("Please enter element[{0},{1}]: ", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }
    }
    private static void PrintMatrixFromIndex(int startI, int startJ, string[,] matrix)  //prints a matrix from a given index
    {
        for (int i = startI; i < matrix.GetLength(0); i++)
        {
            for (int j = startJ; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    private static void CheckHorizontalLines(string[,] matrix)      //checks all horizontal lines
    {
        int tempLength = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1])
                {
                    tempLength++;
                }
                if (matrix[i, j] != matrix[i, j + 1] || j + 1 == matrix.GetLength(1) - 1)
                {
                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        element = matrix[i, j];
                    }
                    tempLength = 1;
                }
            }
            tempLength = 1;
        }
    }
    private static void CheckVerticalLines(string[,] matrix)        //all the vertical lines
    {
        int tempLength = 1;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                if (matrix[i, j] == matrix[i + 1, j])
                {
                    tempLength++;
                }
                if ((matrix[i, j] != matrix[i + 1, j]) || (i + 1 == matrix.GetLength(0) - 1))
                {
                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        element = matrix[i, j];
                    }
                    tempLength = 1;
                }
            }
            tempLength = 1;
        }
    }
    private static void CheckDiagonalsUp(string[,] matrix)      //checks the diagonals over the main diagonal + the main diagonal
    {
        int tempLength = 1;
        for (int i = 0; i < matrix.GetLength(1) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - 1; j++)
            {
                if ((i+j<matrix.GetLength(1)-1)&&(matrix[j, i + j] == matrix[j + 1, i + j + 1]))
                {
                    tempLength++;
                }
                if ((i+j<matrix.GetLength(1)-1)&&(matrix[j, i + j] != matrix[j + 1, i + j + 1] || j + 1 == matrix.GetLength(0)-1||i+j+1==matrix.GetLength(1)-1))
                {
                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        element = matrix[j, i+j];
                    }
                    tempLength = 1;
                }
            }
            tempLength = 1;
        }
    }
    private static void CheckDiagonalsDown(string[,] matrix)    //checks the diagonals under the main diagonal 
    {
        int tempLength = 1;
        for (int i = 1; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if ((i+j < matrix.GetLength(0) - 1) && (matrix[i+j, j] == matrix[i + j + 1, j + 1]))
                {
                    tempLength++;
                }
                if ((i+j < matrix.GetLength(0) - 1) && (matrix[i + j, j] != matrix[i + j + 1, j + 1] || i + j + 1 == matrix.GetLength(0) - 1 || j + 1 == matrix.GetLength(1) - 1))
                {
                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        element = matrix[i+j, j];
                    }
                    tempLength = 1;
                }
            }
            tempLength = 1;
        }
    }
    private static void CheckReverseDiagonalsUp(string[,] matrix) //the reversed diagonals -under the main reversed diagonal
    {
        int tempLength = 1;
        for (int i = matrix.GetLength(1) - 2; i >0; i--)
        {
            for (int j = 0; j <matrix.GetLength(0)-1; j++)
            {
                if ((i-j-1 >= 0) && (matrix[j, i-j] == matrix[j + 1, i-j-1]))
                {
                    tempLength++;
                }
                if ((i - j - 1 >= 0) && (matrix[j, i - j] != matrix[j + 1, i - j - 1] || j + 1 == matrix.GetLength(1) - 1 || i - j - 1 == 0))
                {
                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        element = matrix[j, i - j];
                    }
                    tempLength = 1;
                }
            }
            tempLength = 1;
        }
    }
    private static void CheckReverseDiagonalsDown(string[,] matrix)   //the reversed diagonals - over the main reversed diagonal
    {
        int tempLength = 1;
        int constant = matrix.GetLength(1) - 1;   //I'm using this one for convinience and readability 
        for (int i = 1; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = matrix.GetLength(1) - 1; j > 0; j--)
            {
                if ((constant + i - j < matrix.GetLength(0) - 1) && (matrix[constant + i - j, j] == matrix[constant + i - j + 1, j - 1]))
                {
                    tempLength++;
                }
                if ((constant + i - j < matrix.GetLength(0) - 1) && (matrix[constant + i - j, j] != matrix[constant + i - j + 1, j - 1] || constant + i - j + 1 == matrix.GetLength(0) - 1 || j - 1 == 0))
                {
                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        element = matrix[constant + i - j, j];
                    }
                    tempLength = 1;
                }
            }
            tempLength = 1;
        }
    }
    static void Main()
    {

        Console.WriteLine("Please enter number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number M: ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        EnterMatrix(matrix);
        Console.WriteLine("The matrix you've entered: ");
        PrintMatrixFromIndex(0, 0, matrix);
        CheckHorizontalLines(matrix);
        CheckVerticalLines(matrix);
        CheckDiagonalsUp(matrix);
        CheckDiagonalsDown(matrix);
        CheckReverseDiagonalsUp(matrix);
        CheckReverseDiagonalsDown(matrix);
        if (maxLength == 1)
        {
            Console.WriteLine("There are no sequences in the matrix!");
        }
        else
        {
            Console.Write("The longest sequence in the matrix is: ");
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }

    }
}
