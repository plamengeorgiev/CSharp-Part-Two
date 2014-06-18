//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

class LastDigitAsWord
{
    static string LastDigit(int number)
    {
        int lastDigit = Math.Abs(number % 10);  //i'm using the absolute value - that way the program works with negative numbers
        switch (lastDigit)
        {
            case 1:
                {
                    return "one";
                }
            case 2:
                {
                    return "two";
                }
            case 3:
                {
                    return "three";
                }
            case 4:
                {
                    return "four";
                }
            case 5:
                {
                    return "five";
                }
            case 6:
                {
                    return "six";
                }
            case 7:
                {
                    return "seven";
                }
            case 8:
                {
                    return "eight";
                }
            case 9:
                {
                    return "nine";
                }
            case 0:
                {
                    return "zero";
                }
            default:
                {
                    return "Wrong input";
                }
        }
    }
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigit(number));
    }
}
