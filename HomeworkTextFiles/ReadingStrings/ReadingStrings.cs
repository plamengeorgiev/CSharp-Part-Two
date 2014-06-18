//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:

using System;
using System.Collections.Generic;
using System.IO;

class ReadingStrings
{
    static void Main(string[] args)
    {
        List<string> listOfStrings = new List<string>();    //list, containing all the strings
        using (StreamReader sr = new StreamReader("file1.txt"))     //opening the file for reading
        {
            string line = sr.ReadLine();
            while (line!=null)  //reading all the lines
            {
                listOfStrings.Add(line);    //and writing them in the list
                line = sr.ReadLine();
            }
        }
        listOfStrings.Sort();   //sorting the list
        using (StreamWriter sw = new StreamWriter("result.txt"))    //opening the file for writing
        {
            for (int i = 0; i < listOfStrings.Count; i++)
            {
                sw.WriteLine(listOfStrings[i]); //writing all the strings
            }
        }
        Console.WriteLine("Done!"); //printing a message on the console
    }
}
