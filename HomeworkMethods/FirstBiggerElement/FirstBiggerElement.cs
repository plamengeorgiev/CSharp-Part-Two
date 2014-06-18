//Write a method that returns the index of the first element in array that is bigger than its neighbors,
//or -1, if there’s no such element.Use the method from the previous exercise.

using System;

class FirstBiggerElement
{
    static int IsBigger(int[] array, int index)
    {
        if (index >= 1 && index < array.Length - 1)
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return index;
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
    static int FirstBiggerThanTheNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (IsBigger(array,i)==i)   //i'm calling the previous method with each of the elements of the array
            {
                return i;           //first one, bigger than the neighbours breaks it and its index is returned
            }
        }
        return -1;  //else -1 is returned
    }

    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7,87623, 8, 9, 10, 11, 14, 153, 234};
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(FirstBiggerThanTheNeighbours(array));
        
    }
}
