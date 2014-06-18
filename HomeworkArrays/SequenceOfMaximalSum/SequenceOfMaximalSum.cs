//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}

using System;
class SequenceOfMaximalSum
{
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
        //int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int maxSum=int.MinValue;
        int sum = 0;
        int startIndex = 0;
        int endIndex = 0;
        int tempIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (sum>maxSum)
            {
                maxSum = sum;
                endIndex = i;
                startIndex = tempIndex;
            }
            if (sum<0)
            {
                sum = 0;
                tempIndex = i + 1;
            }
        }

        Console.WriteLine("The sequence of maximal sum is: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i]+" ");
        }
    }
}