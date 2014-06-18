//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class IsLeapYear
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a year: ");
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Year {0} is leap!", year);
        }
        else
        {
            Console.WriteLine("Year {0} is not leap!", year);
        }
    }
}
