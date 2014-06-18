//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
using System;
using System.Globalization;

class CalculateDaysBetween
{
    static void Main(string[] args)
    {
        string format = "dd.MM.yyyy";   //variable for the date format

        Console.WriteLine("Enter the first date in format - dd.MM.yyyy");
        string date1 = Console.ReadLine();
        DateTime dateOne = DateTime.ParseExact(date1, format, CultureInfo.InvariantCulture);    //parsing the first date
        Console.WriteLine("Enter the second date in format - dd.MM.yyyy");
        string date2 = Console.ReadLine();          //parsing the second date
        DateTime dateTwo = DateTime.ParseExact(date2, format, CultureInfo.InvariantCulture);
        Console.WriteLine("Distance: {0} days", (dateTwo - dateOne).TotalDays); //calculating the days

    }
}
