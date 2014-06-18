using System;
using System.Text.RegularExpressions;
using System.IO;


class DeleteWordsWithPrefix
{
    static void Main()
    {
        string line;
        using (StreamReader sr = new StreamReader("file1.txt")) //opens the file for reading
        {
            using (StreamWriter sw = new StreamWriter("result.txt"))    //opens the file for writing
            {
                line = sr.ReadLine();
                while (line != null)    //read line by line
                {
                    line = line.ToLower();  //converts to lower
                    line = Regex.Replace(line, @"\btest\w*(\s|\S)\b", String.Empty);  //replaces the searched words with empty strings
                    sw.WriteLine(line); //writes the lines in the "result" file
                    line = sr.ReadLine();   //reads the next line
                }
            }
        }
        Console.WriteLine("Done!"); //prints a message on the console
    }
}