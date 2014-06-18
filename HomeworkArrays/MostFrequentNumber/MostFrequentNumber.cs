//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;

class Program
{
    static void Main(string[] args)
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
        //int[] array = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int maxCount = 0;
        int counter = 0;
        int element = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[i]==array[j])
                {
                    counter++;
                    
                }
            }
            if (counter>maxCount)
            {
                maxCount = counter;
                element = array[i];
            }
            counter = 0;
        }
        Console.WriteLine("The most frequent element is: {0} ({1} times)", element, maxCount);
    }
}