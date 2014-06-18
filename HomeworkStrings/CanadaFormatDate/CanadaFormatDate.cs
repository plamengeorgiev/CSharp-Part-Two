//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class CanadaFormatDate
{
    static void Main(string[] args)
    {
        string format = "dd.MM.yyyy";   //variable for the format
        string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
        foreach (var extracted in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))    //regex for searching dates
        {
            string result = Convert.ToString(extracted);    //converting to string
            DateTime date = DateTime.ParseExact(result, format, CultureInfo.InvariantCulture); //parsing the date
            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));  //printing the date in Canada format
        }
    }
}
