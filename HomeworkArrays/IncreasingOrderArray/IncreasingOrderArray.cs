//* Write a program that reads an array of integers and removes from it a minimal number of elements in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
//	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

using System;
using System.Collections.Generic;

class IncreasingOrderArray
{
    static int[] array;
    static int removedElements = int.MaxValue;
    static List<int> result = new List<int>();

    static void GenerateArrays(int index, int[] subArrays, int start)       //recursive method for generating combinations
    {
        if (index == -1)
            CheckIncreasingArray(subArrays);
        else
        {
            for (int i = start; i < array.Length; i++)
            {
                subArrays[index] = i;
                GenerateArrays(index - 1, subArrays, i + 1);
            }
        }
    }
    static void CheckIncreasingArray(int[] subArray)            //this method checks for increasing sequence
    {
        int[] copySubArr = (int[])subArray.Clone();
        Array.Reverse(copySubArr);
        for (int i = 1; i < copySubArr.Length; i++)
        {
            if (array[copySubArr[i]] < array[copySubArr[i - 1]]) return;
        }
        if (removedElements > array.Length - copySubArr.Length)
        {
            if (result.Count > 0) result.Clear();

            removedElements = array.Length - copySubArr.Length;     //counter for removed elements

            foreach (int item in copySubArr) result.Add(array[item]);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        array = new int[length];
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int[] myArray;
        for (int i = 1; i <= array.Length; i++)
        {
            myArray = new int[i];
            GenerateArrays(myArray.Length - 1, myArray, 0);
        }
        foreach (int i in result) Console.Write(i + " ");
        Console.WriteLine();
        Console.WriteLine("{0} elements were removed from the array", removedElements);
    }
}
