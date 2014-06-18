//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. 
using System;

class ForbiddenWords
{
    static void Main(string[] args)
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string words = "PHP, CLR, Microsoft";
        Console.WriteLine("The original text is: {0}", text);
        char[] separators = new char[] { ' ', '.', ',' };   //array of separators
        string[] forbiddenWords = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);   //splits the forbidden words
        foreach (var word in forbiddenWords)
        {
            text = text.Replace(word, new string('*', word.Length));    //if a forbidden word is found - it is replaced with a new string
        }
        Console.WriteLine("The changed text is: {0}", text);
    }
}
