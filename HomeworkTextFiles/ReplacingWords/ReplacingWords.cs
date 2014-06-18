//Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplacingWords
{
    static void Main(string[] args)
    {
        using (StreamReader sr = new StreamReader("file1.txt")) //opening the file for reading
        {
            using (StreamWriter sw = new StreamWriter("result.txt"))    //opening the file for writing
            {
                string line = sr.ReadLine();
                while (line != null)  //reading line by line
                {
                    sw.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));  //replacing the words and writing the line
                    line = sr.ReadLine();
                }
            }
        }
        Console.WriteLine("Done!"); //printing a message on the console
    }
}
