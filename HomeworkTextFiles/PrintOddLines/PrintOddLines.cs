//Write a program that reads a text file and prints on the console its odd lines

using System;
using System.IO;

class PrintOddLines
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader("../../PrintOddLines.cs"))
        {
            string line = sr.ReadLine();    //reading the first line
            int lineCount =1;   //counter for the check 
            while (line!=null)
            {
                if (lineCount % 2 != 0) //check if the line is odd
                {
                    Console.WriteLine(line);    //if it is odd - the line is printed on the console
                }
                line = sr.ReadLine();   //reading the next line
                lineCount++;    //and increasing the lineCounter
            }
        }
    }
}
