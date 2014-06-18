//Write a program that removes from a text file all words listed in given another text file. 
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;


class DeleteListedWords
{
    static void Main()
    {
        try
        {
            string content = String.Join(" ", File.ReadAllLines("words.txt"));  //reading the content of the file in a string
            string[] words = content.Split(' '); //creating an array of strings with all the words
            
            using (StreamReader sr = new StreamReader("file1.txt")) //opening the file for reading
            {
                string line = sr.ReadLine();    
                using (StreamWriter sw = new StreamWriter("result.txt"))    //opening the file for writing
                {
                    while (line != null)    //reading line by line
                    {
                        for (int i = 0; i < words.Length; i++)  //cycle for all the words from the array
                        {
                            string word = "\\b" + words[i] + "\\b"; //searching the words in the text
                            line = Regex.Replace(line, word, String.Empty); //and replacing them with empty string
                        }

                        sw.WriteLine(line); //writing the line

                        line = sr.ReadLine();
                    }
                }
            }
            Console.WriteLine("Done!"); //printing a message on the console
        }
        catch (DirectoryNotFoundException dnf)  //catching all the exceptions
        {
            Console.WriteLine(dnf.Message);
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine(fnf.Message);
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (PathTooLongException ptl)
        {
            Console.WriteLine(ptl.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
        catch (SecurityException se)
        {
            Console.WriteLine(se.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}