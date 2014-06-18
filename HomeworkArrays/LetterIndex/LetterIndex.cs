//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class LetterIndex
{
    static void Main()
    {
        char[] charArr = new char[26];
        for (int i = 0; i < 26; i++)    //this cycle fills th array with the letters A-Z (capital letters)
        {
            charArr[i] = (char)(i+65);
        }
        Console.Write("Please enter a word: ");
        string word = Console.ReadLine();
        foreach (var letter in word)
	    {
		    for (int i = 0; i < charArr.Length; i++)
			{
                if (charArr[i] == letter || charArr[i] + 32 == letter) //"A"+32 = "a" - this checks the small letters too
                {
                    Console.WriteLine(i);
                    break;
                }
			} 
	    }
    }
}
