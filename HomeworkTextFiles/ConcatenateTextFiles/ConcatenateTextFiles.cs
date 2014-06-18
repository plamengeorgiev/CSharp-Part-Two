//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main(string[] args)
    {
        string content1;
        using (StreamReader sr = new StreamReader("file1.txt")) //reading the content of the first file
        {
            content1 = sr.ReadToEnd();
        }
        string content2;
        using (StreamReader sr = new StreamReader("file2.txt")) //reading the content of the second file
        {
            content2 = sr.ReadToEnd();
        }
        using (StreamWriter sw = new StreamWriter("file3.txt")) //writing in the third file
        {
            sw.Write(content1);
            sw.WriteLine();
            sw.Write(content2);
        }
        Console.WriteLine("Done!"); //printing a message on the console
    }
}
