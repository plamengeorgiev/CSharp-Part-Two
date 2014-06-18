//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;

class Palindromes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input some words: ");
        string text = Console.ReadLine();
        string[] arrayOfStrings = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries); //split the text
        for (int i = 0; i < arrayOfStrings.Length; i++)
        {
            text = arrayOfStrings[i];
            bool isPalindrom = false;
            for (int j = 0; j < text.Length / 2; j++)
            {
                if (text.Substring(j, 1) == text.Substring(text.Length - 1 - j, 1)) //check for symetry letter by letter
                {
                    isPalindrom = true;
                }
                else
                {
                    isPalindrom = false;
                    break;
                }
            }
            if (isPalindrom == true && text.Length > 1) //if the word is longer than one word and is symmetrical..
                Console.WriteLine(text); //prints the word on the console
        }
    }
}
