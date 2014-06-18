//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
//Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class GenerateVariations
{
    static int N;
    static int K;
    static int[] loops;

    static void Variations(int index)       //recursive method simulating nested loops
    {                                       
        if (index == K)                     
        {
            PrintLoops();                   //the array is printed when the last level of recursion is reached 
            return;
        }
        for (int i = 1; i <= N; i++)        
        {
            loops[index] = i;               //the elements of the array are the generated variation
            Variations(index + 1);          
        }
    }
    static void PrintLoops()                //standart printing
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
        loops=new int[K];
        Variations(0);                      //index starts from 0 and increases with the recursive calls
    }
}
