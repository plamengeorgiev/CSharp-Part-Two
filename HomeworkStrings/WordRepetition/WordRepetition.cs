//Write a program that reads a string from the console and lists all different words in the string along with information 
//how many times each word is found.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Please input some text: ");
        string text = Console.ReadLine().ToLower();
        string[] firstWords = text.Split(new Char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);  //splits the text
        string[] words = new string[firstWords.Length]; //array for the words
        int[] repetitions = new int[firstWords.Length]; //array for the repetitions
        for (int i = 0; i < firstWords.Length; i++) //cycle itterating through the splittet words from the text
        {
            for (int j = 0; j < words.Length; j++)  //inner cycle, itterrating through the array with the words
            {
                if (words[j] != null)   //if the value of the position is not null
                {
                    if (words[j] == firstWords[i])  //checks for match
                    {
                        repetitions[j]++;   //and increases the repetitions - same postion, but in the other array
                        break;
                    }
                }
                else  //if the value is null
                {
                    words[j] = firstWords[i];   //the word from the splitted text is written
                    repetitions[j]++;           //and the repetitions are increased by 1
                    break;
                }
            }
        }
        for (int i = 0; i < words.Length; i++)  //printing the result
        {
            if (words[i]!=null)
            {
                
                Console.WriteLine("word: {0}    repetitions: {1}", words[i], repetitions[i]);
            
            }
            }
    }
}
