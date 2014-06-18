//Write a program that reads a string from the console and 
//replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Text;

class IdenticalLettersCheck
{
    static void Main(string[] args)
    {
        Console.Write("Please input some text: ");
        string text = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        sb.Append(text[0]); //appends the firs letter from the text
        for (int i = 1; i < text.Length; i++)   //itterates through the letters from the input text
        {
            if (text[i] != sb[sb.Length - 1])   //if the current letter is different from the last in the stringBuilder...
            {
                sb.Append(text[i]); //appends the letter
            }
        }
        string result = sb.ToString();
        Console.WriteLine("The text after the change: {0}", result);    //prints the result on the console
    }
}
