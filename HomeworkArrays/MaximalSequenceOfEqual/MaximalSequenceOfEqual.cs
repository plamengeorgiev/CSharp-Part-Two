//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

class MaximalSequenceOfEqual
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        if (length==0)
        {
            Console.WriteLine("The array is empty!");
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i   );
            array[i] = int.Parse(Console.ReadLine());
        }
        int maxLength = 0;
        int counter = 1;
        int element = 0;
        for (int i = 0; i < length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
            }
            if ((array[i]!=array[i+1])||(i+1==array.Length-1))  //checks if the end of the array is reached
            {
                if (counter>maxLength)
                {
                    maxLength = counter;
                    element = array[i];
                }
                counter = 1;
            }
        }
        Console.WriteLine("The maximal sequence of equals: ");
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(element+" ");
        }
        Console.WriteLine();
    }
}
