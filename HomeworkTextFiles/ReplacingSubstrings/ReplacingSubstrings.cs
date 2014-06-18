//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplacingSubstrings
{
    static void Main(string[] args)
    {
        using (StreamReader sr = new StreamReader("file1.txt")) //opening the file for reading
        {
            using (StreamWriter sw = new StreamWriter("result.txt"))    //opening the file for writing
            {
                string line = sr.ReadLine();
                while (line!=null)  //reading line by line
                {
                    sw.WriteLine(line.Replace("start", "finish"));  //replacing the strings and writing the line
                    line= sr.ReadLine();
                }
            }
        }
        Console.WriteLine("Done!"); //printing a message on the console
    }
}
