//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.

using System;

class RepetitionsInArray
{
    static int CountRepetitions(int[] array, int element)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==element)
            {
                counter++;  //counter for the repetitions
            }
        }
        return counter;
    }
    static void Main()
    {
        //the main method can be modified and "for"-cycle can be used to call the method 
        //with each of the elements in the array as a parameter
        
        int[] array = new int[] { 13, 15, 2, 5, 6, 6, 6, 7, 8, 9, 9, 9, 9, 13, 15, 16, 233, 14, 166, 420 };
        Console.Write("Please enter the number, that you want to search for: ");
        int element = int.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} appears {1} times in the given array", element, CountRepetitions(array,element));
    }
}
