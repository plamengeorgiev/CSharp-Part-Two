//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main(string[] args)
    {
        List<string> listOfLines = new List<string>();
        int lineCount = 0;
        using (StreamReader sr = new StreamReader("file1.txt"))
        {
            string line = sr.ReadLine();
            while (line!=null)
            {
                if (lineCount%2==0)
                {
                    listOfLines.Add(line);
                }
                line = sr.ReadLine();
                lineCount++;
            }
        }
        using (StreamWriter sw = new StreamWriter("file1.txt"))
        {
            for (int i = 0; i < listOfLines.Count; i++)
            {
                sw.WriteLine(listOfLines[i]);
            }
        }
        Console.WriteLine("Done!");
    }
}