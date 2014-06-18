//Write a program that compares two text files line by line and prints the number of lines that are the same 
//and the number of lines that are different. Assume the files have equal number of lines.


using System;
using System.IO;

class CompareLineByLine
{
    static void Main()
    {
        int sameLinesCount=0;
        int diffLinesCount =0;
        using (StreamReader sr1 = new StreamReader ("file1.txt"))   //opens the first file for reading
        {
            using (StreamReader sr2 = new StreamReader("file2.txt"))    //opens the second file for reading
            {
                string line1 = sr1.ReadLine();
                string line2 = sr2.ReadLine();
                while (line1!=null)
                {
                    if (line1==line2)   //compares line by line
                    {
                        sameLinesCount++;   //counts the same lines
                    }
                    else
                    {
                        diffLinesCount++;   //counts the different lines
                    }
                    line1 = sr1.ReadLine();
                    line2 = sr2.ReadLine();
                }
            }
        }
        Console.WriteLine("The number of lines, that are the same is: {0}", sameLinesCount);    //prints the result
        Console.WriteLine("The number of lines, that are different is: {0}", diffLinesCount);   //prints the result
    }
}
