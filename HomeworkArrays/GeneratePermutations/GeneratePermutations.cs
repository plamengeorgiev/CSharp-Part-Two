//* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
//	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

using System;

class GeneratePermutations
{
    static int N;
    static int[] loops;

    static void Permutations(int index)         //this method actully generates all the variations
    {
        if (index == N)
        {
            PrintLoops();
            return;
        }
        for (int i = 1; i <= N; i++)
        {
            loops[index] = i;
            Permutations(index + 1);
        }
    }
    static void PrintLoops()                    //this method has an extra check for equal elements
    {
        bool isPermutation = true;
        for (int i = 0; i < N; i++)
        {
            for (int j = i+1; j < N; j++)
            {
                if (loops[i] == loops[j])       //if there are equal elements - the array is not a solution
                {
                    isPermutation = false;
                }
            }
        }
        if (isPermutation)                      //if the variation is a permutation - the array is printed
        {
            for (int i = 0; i < N; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
        }
    }
    static void Main()
    {
        Console.Write("Please enter number N: ");
        N = int.Parse(Console.ReadLine());
        loops = new int[N];
        Permutations(0);
    }
}