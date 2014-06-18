//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.


using System;
using System.IO;

class InsertLineNumbers
{
    static void Main(string[] args)
    {
        using (StreamReader sr = new StreamReader("sourceFile.txt"))    //opening the source file for reading
        {
            using (StreamWriter sw = new StreamWriter("resultFile.txt"))    //opening the result file for writing
            {
                int lineNumber = 1;
                string line = sr.ReadLine();    //reading a line
                while (line != null)
                {

                    sw.Write("{0} {1}", lineNumber, line);  //writing the line number + space + the line
                    sw.WriteLine();

                    line = sr.ReadLine(); //reading the next line
                    lineNumber++;   //increasing the line number
                }
            }
        }
        Console.WriteLine("Done!"); //printing a message on the console
    }
}
