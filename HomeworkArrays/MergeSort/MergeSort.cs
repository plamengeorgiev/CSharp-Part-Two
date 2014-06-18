//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

using System;

class MergeSort
{
    static int[] MergeSortMethod(int[] array)            //recursive version of the merge sort
    {
        if (array.Length == 1)
        {
            return array;
        }
        //first the array is divided in two
        int mid = array.Length / 2;
        int[] leftSide = new int[mid];                  //the left array is filled with elements
        for (int i = 0; i < mid; i++)
        {
            leftSide[i] = array[i];
        }
        int[] rightSide = new int[array.Length - mid];  //the right array is filled with elements
        for (int i = 0; i < array.Length - mid; i++)
        {
            rightSide[i] = array[i+mid];
        }
        leftSide = MergeSortMethod(leftSide);       //recursive calls of the method
        rightSide = MergeSortMethod(rightSide);

        int leftPointer = 0;
        int rightPointer = 0;
        int[] sortedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)      //this part merges the parts back together in order
        {
            if (rightPointer == rightSide.Length || ((leftPointer < leftSide.Length) && (leftSide[leftPointer] <= rightSide[rightPointer])))
            {
                sortedArray[i] = leftSide[leftPointer];
                leftPointer++;
            }
            else if (leftPointer == leftSide.Length || ((rightPointer < rightSide.Length) && (rightSide[rightPointer] <= leftSide[leftPointer])))
            {
                sortedArray[i] = rightSide[rightPointer];
                rightPointer++;
            }
        }
        return sortedArray;
    }

    static void Main()
    {
        Console.WriteLine("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        //int[] array = new int[] { 4, 78, 3, 254, -34, 0, 98, 1334, 934 };
        array = MergeSortMethod(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");    
        }
        Console.WriteLine();
    }
}