//* We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
//	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;

class SubsetSumS
{
    static int N;
    static int K;
    static int sum = 0;
    static int[] loops;                         //array for keeping the combination of indexes
    static int[] arr = new int[] { 34,2,3,4};   //array with the elements
    static int S = 42;                          
    static bool solution = false;               

    static void Combinations(int index, int startNumber)    //same as the variations, plus extra parameter
    {
        if (index == K)
        {
            CheckSum();
            return;
        }
        for (int i = startNumber; i <= N; i++)              //each level of recursion has one less iteration
        {
            loops[index] = i;
            Combinations(index + 1, i + 1);
        }
    }
    static void CheckSum()      //this method calculates the sum of the elements with the generated indexes
    {
        for (int i = 0; i < K; i++)
        {
            sum += arr[loops[i] - 1];   
            if (sum == S)
            {
                solution = true;
                break;
            }
        }
        sum = 0;
    }
    static void Main()
    {
        N = arr.Length;
        for (int i = 0; i < N; i++)
        {
            K = i;
            loops = new int[K];
            Combinations(0, 1);
        }
        if (solution)
        {
            Console.WriteLine("Yes!");
        }
        else
        {
            Console.WriteLine("There is no such subset!");
        }
    }
}