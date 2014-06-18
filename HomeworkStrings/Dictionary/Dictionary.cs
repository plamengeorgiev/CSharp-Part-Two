//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:

using System;

class Dictionary
{
    static void Main(string[] args)
    {
        string text = ".NET – platform for applications from Microsoft\r\nCLR – managed execution environment for .NET\r\nnamespace – hierarchical organization of classes";
        string[] lineSeparators = new string[] { "\r\n" };
        string[] lines = text.Split(lineSeparators, StringSplitOptions.RemoveEmptyEntries); //split the words+definitions by line
        string[] wordSeparators = new string[] { " – " };   
        string[,] words = new string[lines.Length, 2];  //the "dictionary"
        for (int i = 0; i < lines.Length; i++)
        {
            string[] temp = lines[i].Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries); //split the lines
            words[i, 0] = temp[0];  //the word
            words[i, 1] = temp[1];  //the definition
        }
        Console.WriteLine("Please enter a word: "); 
        string word = Console.ReadLine();
        bool foundDefinition = false;
        for (int i = 0; i < words.GetLength(0); i++)    //searching for the word
        {
            if (word == words[i, 0])    //if there is such word
            {
                Console.WriteLine("The definition of the entered word is: {0}", words[i, 1]);   //the definition is printed
                foundDefinition = true;
                break;
            }
        }
        if (!foundDefinition)
        {
            Console.WriteLine("No definition was found in the dictionary!");    //if there isn't - a message is printed on the console
        }
    }
}
