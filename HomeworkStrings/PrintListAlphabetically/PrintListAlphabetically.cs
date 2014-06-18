//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class PrintListAlphabetically
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter some words, separated by space: ");
        string text = Console.ReadLine();
        char[] separators = new char[] { ' ' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries); //splits the text
        Array.Sort(words);  //sorts the array with the words
        foreach (var word in words)
        {
            Console.WriteLine("{0} ", word);    //prints the result on the console
        }
    }
}
