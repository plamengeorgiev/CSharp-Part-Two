//Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained 
//in another file test.txt. The result should be written in the file result.txt and the words should be sorted by 
//the number of their occurrences in descending order. Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;


class words     //class words for the words, that we'll search for
{
    public string Text { set; get; }    //field for the word
    public int Count { set; get; }      //field for the number of repetitions
}


class WordRepetition
{
    static void Main()
    {
        try
        {
            List<words> listOfWords = new List<words>();    //list with objects of class word
            using (StreamReader readerWord = new StreamReader("words.txt")) //opens the file with the words for reading
            {
                string line = readerWord.ReadLine();
                while (line != null)    //reading line by line
                {
                    words word = new words();   //creating an object word
                    word.Count = 0;     //the field count is zero
                    word.Text = line;   //the field "text" is taken from the file
                    listOfWords.Add(word);  //adds the object to the list
                    line = readerWord.ReadLine();
                }
            }
            using (StreamReader readerInput = new StreamReader("test.txt")) //opens the file for reading
            {
                string line = readerInput.ReadLine();
                while (line != null)    //reading line by line
                {
                    for (int i = 0; i < listOfWords.Count; i++) //for all the words in the list
                    {
                        int count = Regex.Matches(line, "\\b" + listOfWords[i].Text + "\\b").Count; //checks the line for matches
                        listOfWords[i].Count += count;  //and adds the matches to the field "Count"
                    }
                    line = readerInput.ReadLine();
                }
            }
            List<words> ordered = listOfWords.OrderByDescending(a => a.Count).ToList(); //sorts the list by the number of repetitions
            using (StreamWriter sw = new StreamWriter("result.txt"))    //opens the "result" file
            {
                foreach (var word in ordered)
                {
                    sw.WriteLine(word.Text);    //writes all the words (word.text)
                }
            }
            Console.WriteLine("Done!"); //printing a message on the console
        }
        catch (DirectoryNotFoundException dnf)  //exception handling
        {
            Console.WriteLine(dnf.Message);
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine(fnf.Message);
        }
        catch (IOException io)
        {
            Console.WriteLine(io.Message);
        }

        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
    }
}