//Write a program for extracting all email addresses from given text. 
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class ExtractEmailAddresses
{
    static void Main(string[] args)
    {
        string input = @"Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        string[] part = input.Split(' ');   //splits the words

        for (int i = 0; i < part.Length; i++)
        {
            if (Regex.IsMatch(part[i], @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))  //matches the words
            {
                Console.WriteLine("{0} is a valid email", part[i]); //if an email address is found - prints it on the console
            }
        }
    }
}
