//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class GenerateCombinations
{
    static int N;
    static int K;
    static int[] loops;

    static void Combinations(int index, int startNumber)    //same as the variations, plus extra parameter
    {
        if (index == K)
        {
            PrintLoops();
            return;
        }
        for (int i = startNumber; i <= N; i++)              //each level of recursion has one less iteration
        {
            loops[index] = i;
            Combinations(index + 1, i+1);
        }
    }
    static void PrintLoops()                                
    {
        for (int i = 0; i < K; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Please enter number N: ");
        N = int.Parse(Console.ReadLine());
        Console.Write("Please enter number K: ");
        K = int.Parse(Console.ReadLine());
        loops = new int[K];
        Combinations(0, 1);
    }
}
