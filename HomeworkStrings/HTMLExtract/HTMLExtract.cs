//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
using System;

class HTMLExtract
{
    static void Main(string[] args)
    {
        string text = @"<html><head><title> News </title></head><body><p><a href=""http://academy.telerik.com""> TelerikAcademy </a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        Console.WriteLine("The original text: {0}", text);
        
        int openTag = text.IndexOf('<');    //the index of the first open tag
        int closeTag = 0;
        while (openTag != -1)   //cycle itterating while all the open tags are found
        {
            closeTag = text.IndexOf('>');   //index of the closing tag
            text = text.Replace(text.Substring(openTag, closeTag - openTag + 1), string.Empty); //removes the tags from the text
            openTag = text.IndexOf('<');    //finds the index of the next opening tag
        }
        Console.WriteLine();
        Console.WriteLine("The text, after the change: {0}", text);    //prints the result on the console
    }
}
