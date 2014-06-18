//Write a program that reads two arrays from the console and compares them element by element.

using System;

class ComparingArrays
{
    static void Main()
    {
        Console.Write("Please enter the length of the first array: ");
        int length1 = int.Parse(Console.ReadLine());
        int[] array1 = new int[length1];
        Console.Write("Please enter the length of the second array: ");
        int length2 = int.Parse(Console.ReadLine());
        int[] array2 = new int[length2];
        if (length1==0&&length2==0)                  //checks if the arrays are empty
        {
            Console.WriteLine("The arrays are empty!");
        }
        else if (length1!=length2)                  //checks if the arrays have different length
        {
            Console.WriteLine("The arrays are not equal!");
        }
        else
        {
            Console.WriteLine("Please enter the elements of the first array.");
            for (int i = 0; i < length1; i++)
            {
                Console.Write("Element {0} = ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter the elements of the second array.");
            for (int i = 0; i < length2; i++)
            {
                Console.Write("Element {0} = ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }
            bool isEqual = true;
            for (int i = 0; i < length1; i++)       //comparing the arrays element by element
            {
                if (array1[i]!=array2[i])
                {
                    isEqual = false;
                    break;
                }
            }
            if(isEqual)
            {
                Console.WriteLine("The arrays are equal!");
            }
            else
            {
                Console.WriteLine("The arrays are not equal!");
            }
        }
    }
}
