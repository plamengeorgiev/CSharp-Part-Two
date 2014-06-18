//* Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

class SubsetOfKElements
{
    static int N;
    static int K;
    static int sum = 0;
    static int[] loops;                           //array for keeping the combination of indexes
    static int[] arr;                             //array with the elements
    static int S;
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
        Console.Write("Please enter the length of the array: ");
        N = int.Parse(Console.ReadLine());
        arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Element {0} = ",i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Please enter the number of the subset elements K: ");
        K = int.Parse(Console.ReadLine());
        Console.Write("Please enter a sum S: ");
        S = int.Parse(Console.ReadLine());
            loops = new int[K];
            Combinations(0, 1);
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
