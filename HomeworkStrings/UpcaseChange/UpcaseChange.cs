//You are given a text. 
//Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
//The tags cannot be nested.

using System;
class UpcaseChange
{
    static void Main(string[] args)
    {

        string openingTag = "<upcase>";
        string closingTag = "</upcase>";
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        int startIndex = 0;
        int endIndex = 0;
        Console.WriteLine("The text before the change: {0}", text);
        while (true)
        {
            startIndex = text.IndexOf(openingTag, startIndex + openingTag.Length);  //finds the index of the opening tag
            if (startIndex < 0)
            {
                break;  //if there is no opening tag found - stops the cycle
            }
            else
            {
                endIndex = text.IndexOf(closingTag, endIndex + closingTag.Length);  //finds the index of the closing tag
                string replacement = text.Substring(startIndex, endIndex - startIndex + closingTag.Length); //gets the substring
                string newReplacment = replacement.ToUpper();   //changes it to capital letters only
                text = text.Replace(replacement, newReplacment);    //replaces the old one with the new one
                text = text.Remove(endIndex, closingTag.Length);    //deletes the closing tab
                text = text.Remove(startIndex, openingTag.Length);  //deletes the opening tab
            }
        }

        Console.WriteLine("The text after the change: {0}", text);    //prints the result on the console
    }
}
