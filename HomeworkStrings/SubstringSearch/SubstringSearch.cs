//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

using System;

class SubstringSearch
{
    static void Main(string[] args)
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in"; //the substring, that we are searching for
        int helpIndex = 0;
        int counter = 0;    //number of repetitions
        while(true)
        {
            //this part searches the substring in the string from a given index and returns the index of the first found substring
            helpIndex=text.IndexOf(word, helpIndex+word.Length, StringComparison.InvariantCultureIgnoreCase);
            if (helpIndex<0)
            {
                break;  //if the returned index is negative - there are no more substrings
            }
            else
            {
                counter++;  //if the returned index is positive - increase the repetitions
            }
        } 
        Console.WriteLine("The result is: {0}",counter);    //the result is printed on the console
    }
}
