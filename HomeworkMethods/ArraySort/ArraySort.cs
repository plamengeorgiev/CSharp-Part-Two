//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

using System;

class ArraySort
{
    static void PrintArray(int[] arr)   //method for printing the array
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static int MaxValue(int[] arr, int index)   
    {
        int max = int.MinValue;
        int maxIndex = -1;
        for (int i = index; i < arr.Length; i++)    //iterrates through the array and returns the index of the biggest element
        {
            if (arr[i]>max)
            {
                max = arr[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }
    static void DescendingSort(int[] arr)   
    {
        int temp = 0;
        int maxIndex = -1;
        for (int i = 0; i < arr.Length; i++)    //this swaps the values of the first element and the biggest element
        {                                       //then the value of the second and the biggest of the rest and so on...
            maxIndex = MaxValue(arr, i);
            temp = arr[i];
            arr[i] = arr[maxIndex];
            arr[maxIndex] = temp;               //for acsending sort - array.reverse :) or iterrating from the last to the first
        }                                       //but it might want a little modifiction for convinience
    }                                           //the easiest way would be a method returning the index of the smallest element
    static void Main()
    {
        int[] array = new int[] { 3, 7, -1, 2345, 0, 15, 1366 };
        Console.WriteLine("The array before the sort: ");
        PrintArray(array);
        Console.WriteLine("The array after the sort: ");
        DescendingSort(array);
        PrintArray(array);
    }
}
