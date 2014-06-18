//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method 
//Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class LargestNumberSmallerThanK
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the length of the array N: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];     //the entered array - it has n elements in it
        int[] arr2 = new int[n + 1];    //a second array with n+1 elements - it contains the key K
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0} = ", i);
            arr[i] = int.Parse(Console.ReadLine());
            arr2[i] = arr[i];
        }
        Console.Write("Please enter a number K: ");
        int k = int.Parse(Console.ReadLine());
        arr2[n]=k;
        Array.Sort(arr);
        Array.Sort(arr2);
        int index = Array.BinarySearch(arr, k);
        if (index>=0)       //if thearray contains an element=k - the program prints it on the console
        {
            Console.Write("The largest number <= k is: {0}", arr[index]);
        }
        else    //if not - we use the binary searck method on the second array - it returns the index of the key K
        {
            index = Array.BinarySearch(arr2, k);
            if (index>=1)
            {
                Console.Write("The largest number <= k is: {0}",arr2[index- 1]);  //we print the number just before K
            }
            else
            {
                Console.Write("No such number!!!"); //if all the numbers are bigger than K - the program prints "no such number" message
            }
        }
        Console.WriteLine();
    }
}
