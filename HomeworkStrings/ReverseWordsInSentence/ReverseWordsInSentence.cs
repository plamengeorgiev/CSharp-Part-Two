//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
﻿
using System;
using System.Text;

class ReverseWordsInSentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        Console.Write("The original text: {0}", text);
        Console.WriteLine();
        char[] separators = new char[] { ' ',',', '.', ';', '!'};  //char array with separators
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries); //array with the words
        string[] reversedWords = new string[words.Length];  //array for words in the reversed sentence
        Array.Copy(words, reversedWords, words.Length);
        Array.Reverse(reversedWords);
        int index = 0;
        StringBuilder sb = new StringBuilder(); //stringbuilder for the result
        for (int i = 0; i < words.Length; i++)
        {
            index = text.IndexOf(words[i]) + words[i].Length;   //index for checking the separators after the words
            if (index<0)
            {
                break;
            }
            sb.Append(reversedWords[i]);    //appending the words from the second array - the reversed one
            sb.Append(text[index]);         //appending the separators
        }
        text = sb.ToString();
        Console.Write("The reversed text: {0}", text);
        Console.WriteLine();

    }
}