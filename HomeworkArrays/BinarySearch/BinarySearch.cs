//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm 
//(find it in Wikipedia).

using System;

class BinarySearch
{
    static int BinarySearchMethod(int[] arr, int key, int min, int max)
    {
        if (max < min)
        {
            return -1;
        }
        else
	    {
            int mid = (min+max)/2;
            if (arr[mid]>key)
            {
                return BinarySearchMethod(arr, key, min, mid-1);
            }
            else if (arr[mid]<key)
	        {
		        return BinarySearchMethod(arr, key, mid+1, max);
	        }
            else
	        {
                return mid;
	        }
	    }
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
        Console.WriteLine("Please enter the value of the element, that you want to search for: ");
        int key = int.Parse(Console.ReadLine());
        //int[] array = new int[] { 3, 15, 1223, -4, 7899, 3, 245, 0, 89, -345, 9, -322, -3, 556 };
        Array.Sort(array);
        Console.WriteLine("The sorted array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.WriteLine();
        int result = BinarySearchMethod(array, key, 0, array.Length - 1);
        if (result==-1)
        {
            Console.WriteLine("The given element could not be found in the array!");
        }
        else
        {
            Console.WriteLine("The index of the given element is {0}", result);
        }
    }
}