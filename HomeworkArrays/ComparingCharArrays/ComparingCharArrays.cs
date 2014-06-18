//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class ComparingCharArrays
{
    static void Main()
    {
        Console.Write("Please enter the length of the first array: ");
        int length1 = int.Parse(Console.ReadLine());
        char[] array1 = new char[length1];
        Console.Write("Please enter the length of the second array: ");
        int length2 = int.Parse(Console.ReadLine());
        char[] array2 = new char[length2];
        if (length1 == 0 && length2 == 0)
        {
            Console.WriteLine("The arrays are empty!");
        }
        else
        {
            Console.WriteLine("Please enter the elements of the first array.");
            for (int i = 0; i < length1; i++)
            {
                Console.Write("Element {0} = ", i);
                array1[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter the elements of the second array.");
            for (int i = 0; i < length2; i++)
            {
                Console.Write("Element {0} = ", i);
                array2[i] = char.Parse(Console.ReadLine());
            }
            int shortLength = Math.Min(length1, length2);
            for (int i = 0; i < shortLength; i++)
            {
                if (array1[i] < array2[i])
                {
                    Console.WriteLine("The first array is before the second array");
                    break;
                }
                else if (array1[i] > array2[i])
                {
                    Console.WriteLine("The second array is before the first array");
                    break;
                }
                else
                {
                    if (array1.Length == array2.Length)
                    {
                        Console.WriteLine("The arrays are equal");
                        break;
                    }
                    if (array1.Length < array2.Length)
                    {
                        Console.WriteLine("The first array is before the second array");
                        break;
                    }
                    if (array1.Length > array2.Length)
                    {
                        Console.WriteLine("The second array is before the first array");
                        break;
                    }
                }
            }
        }
    }
}
