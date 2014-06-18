//Write a program that extracts from given XML file all the text without the tags. Example:

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class ExtractText
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("File1.xml")) //opens the file for reading
        {
            int prev = ' ';
            List<string> listOfWords = new List<string>();  //list for all the words
            StringBuilder temp = new StringBuilder();

            for (int current; (current = reader.Read()) != -1; )    //reading all the symbols
            {
                if (prev == '>' && current != '<')  //if the symbols are after the end of a tag, but not a beginning of another
                {
                    while (current != '<' && current != -1) //while the beginning of another tag is reached
                    {
                        if (current != ' ' && current != '\n' && current != '\r' && current != '\t') //if the current symbol  is not space, new line, carriage return, or tab
                        {
                            temp.Append((char)current); //appends the symbol to the stringbuilder
                        }
                        current = reader.Read();
                    }

                    if (temp.Length > 0)
                    {
                        listOfWords.Add(temp.ToString());   //adds the word to the list
                        temp.Clear();
                    }
                }
                prev = current;
            }

            foreach (string word in listOfWords) Console.WriteLine(word);   //prints all the words to the console
        }
    }
}
