//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.

using System;
class StringOfTwentyCharacters
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a string of maximum 20 characters: ");
        string input = Console.ReadLine();
        if (input.Length>20)
        {
            input = input.Substring(0, 20); //takes only the first 20 characters
            Console.WriteLine("The string you've entered was longer than 20 characters!");
        }
        input = input.PadRight(20, '*');    //creates a new string with length of exactly 20 characters, filled with * after the input
        Console.WriteLine("The new string is: {0}", input);
    }
}
