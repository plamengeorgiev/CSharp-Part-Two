//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;

class NumberOfWorkdays
{
    static void Main(string[] args)
    {
        List<DateTime> holidayList = new List<DateTime>();  //list with all the holidays
        holidayList.Add(new DateTime(2013, 03, 03));
        holidayList.Add(new DateTime(2013, 03, 08));
        holidayList.Add(new DateTime(2013, 05, 01));
        holidayList.Add(new DateTime(2013, 05, 24));
        holidayList.Add(new DateTime(2013, 09, 15));
        holidayList.Add(new DateTime(2013, 12, 25));
        Console.Write("Please enter a final date in the format YYYY-MM-DD: ");
        DateTime finalDate = DateTime.Parse(Console.ReadLine());    //the user enters a final date
        DateTime startDate = DateTime.Today;
        Console.WriteLine("Today is: {0:D}", DateTime.Today);
        Console.WriteLine("The entered date is: {0:D}", finalDate);
        if (finalDate<startDate)
        {
            Workdays(finalDate, startDate, holidayList);    //if the entered date is before today
                                                            //the same method, but the parameters are switched
        }
        else
        {
            Workdays(startDate, finalDate, holidayList);    //the normal case - the entered date is after today
        }
    }
    static void Workdays(DateTime startDate, DateTime finalDate, List<DateTime> holidayList)
    {
        int workdays = 0;   //variable to count all the workdays
        int totalDays = (finalDate - startDate).Days;   //calculating all the days between the dates
        DateTime tempDate = new DateTime();
        for (int i = 0; i <=totalDays; i++) //cycle for all the days
        {
            tempDate = startDate.AddDays(i);
            if (tempDate.DayOfWeek!=DayOfWeek.Saturday&&tempDate.DayOfWeek!=DayOfWeek.Sunday)
            {
                workdays++; //increases the counter if the day is a weekday - not saturday or sunday
            }
            for (int j = 0; j < holidayList.Count; j++)
            {
                int comparison = tempDate.CompareTo(holidayList[j]);
                if ((comparison == 0) && (tempDate.DayOfWeek != DayOfWeek.Sunday && tempDate.DayOfWeek != DayOfWeek.Saturday))
                {
                    workdays--; //decreases the counter if the date in the holiday list is a weekday - not saturday or sunday
                }
            }
        }
        Console.WriteLine("Work days between the two dates: {0}", workdays);
    }
}
