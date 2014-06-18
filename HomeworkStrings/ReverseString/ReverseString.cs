//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" -> "elpmas".

using System;
using System.Text;

class ReverseString
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a word: ");
        string word = Console.ReadLine();
        char[] wordArr = word.ToCharArray();    //array with the letters of the word
        Array.Reverse(wordArr);                 //the array is reversed
        StringBuilder sb = new StringBuilder(); //stringbuilder for the new word
        for (int i = 0; i < wordArr.Length; i++)
			{
			 sb.Append(wordArr[i]);
			}
        word = sb.ToString();   //writing the new string in the old variable
        Console.WriteLine("The reversed word is: {0}", word);
    }
}
