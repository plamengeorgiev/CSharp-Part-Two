//Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found. 

using System;

class LetterRepetition
{
    static void Main()
    {
        Console.Write("Please input a string :");
        string input = Console.ReadLine();
        char[] array = new char[65536];
        for (int i = 0; i < input.Length; i++)  //cycle for all the signs in the input string
        {
            array[(ushort)(input[i])]++;    //increases the value in the cell of the array, corresponding to the symbol
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)  //prints all the cells, that are not zero
            {
                Console.WriteLine("The letter {0} is found: {1} times", (char)i, (ushort)array[i]);
            }
        }

    }
}
