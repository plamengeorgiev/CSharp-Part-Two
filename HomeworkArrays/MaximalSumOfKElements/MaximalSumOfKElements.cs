//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

using System;
class MaximalSumOfKElements
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the array N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of elements K: ");
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);                 
        Array.Reverse(array);
        Console.WriteLine("The {0} elements with maximal sum are: ", K);
        for (int i = 0; i < K; i++)         //prints the first K elements from the sorted and reversed array    
        {                                   //the other option is to print the last k elements from the sorted array - without reversing
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}
