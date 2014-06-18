//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with 
//corresponding tags [URL=…]…/URL]. Sample HTML fragment:

using System;

class Program
{
    static void Main()
    {
        string[] oldTags = { "<a href=\"", "\">", "</a>" }; //array with the old tags
        string[] newTags = { "[URL=", "]", "[/URL]" };  //array with the new tags
        string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        for (int i = 0; i < oldTags.Length; i++)    
        {
            text = text.Replace(oldTags[i], newTags[i]);    //replacing the tags one by one
        }
        Console.WriteLine(text);
    }
}
