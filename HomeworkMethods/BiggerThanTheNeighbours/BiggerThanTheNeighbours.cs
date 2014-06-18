//Write a method that checks if the element at given position in given array of integers 
//is bigger than its two neighbors (when such exist).

using System;

class BiggerThanTheNeighbours
{
    static int IsBigger(int[] array, int index)
    {
        if (index >= 1 && index < array.Length - 1) //this grants that the element has two neighbours
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1]) //if the element is bigger than the neighbours
            {
                return index;   //its index is returned
            }
            else
            {
                return -1; //the element is not bigger than its neighbours
            }
        }
        else
        {
            return -2;   //only one neighbour//no neighbours//wrong input//
        }
    }

    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 14, 153, 6462, 2334, 5, 342, 3454, 67 };
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Please enter the index of the element, that you want to check: ");
        int index = int.Parse(Console.ReadLine());
        if (IsBigger(array, index) == -2)   //first is the check for wrong input, so that the program won't blow with index out of range exception
        {
            Console.WriteLine("Wrong Input!!!");
        }
        else if (IsBigger(array, index) == index)
        {
            Console.WriteLine("{1}>{0} && {1}>{2} : True", array[index - 1], array[index], array[index + 1]);
        }
        else if (IsBigger(array, index) == -1)
        {
            Console.WriteLine("{1}>{0} && {1}>{2} : False", array[index - 1], array[index], array[index + 1]);    
        }
        
    }
}
