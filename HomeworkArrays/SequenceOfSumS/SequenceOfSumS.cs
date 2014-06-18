//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
using System;

class SequenceOfSumS
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
        Console.WriteLine("Please enter sum S: ");
        int S = int.Parse(Console.ReadLine());
        //int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };
        int sum = 0;
        int startIndex = 0;
        int endIndex = 0;
        bool foundSum = false;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                sum += array[j];
                if (sum==S)
                {
                    startIndex = i;
                    endIndex = j;
                    foundSum = true;
                    break;
                }
            }
            sum = 0;
        }
        if (foundSum)
        {
            Console.WriteLine("The sum S={0} :", S);
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(array[i]+ " ");
            }
        }
        else
        {
            Console.WriteLine("The sum S={0} could not be found!", S);
        }
        Console.WriteLine();
    }
}