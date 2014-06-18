//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int endIndex = 0;
        int maxLength = 0;
        int counter = 1;
        for (int i = 0; i < length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                counter++;
            }
            if ((array[i] >= array[i + 1]) || (i + 1 == array.Length - 1))  //checks if the end of the array is reached
            {
                if (counter > maxLength)
                {
                    endIndex = i;
                    maxLength = counter;
                    counter = 1;
                }
            }
        }
        int startIndex = endIndex - maxLength + 1;  //calculating the start index
        for (int i = startIndex; i <= endIndex; i++)    //printing the sequence
        {
            Console.Write("{0} ", array[i]);
        }
    }
}
