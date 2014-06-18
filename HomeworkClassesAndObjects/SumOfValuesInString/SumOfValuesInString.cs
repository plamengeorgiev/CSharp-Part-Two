//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461

using System;

class SumOfValuesInString
{
    static void Main()
    {
        Console.WriteLine("Please enter a sequence of positive integers, divided by spaces: ");
        string sequence = Console.ReadLine();
        Console.WriteLine(SumOfStrings(sequence));
    }

    static int SumOfStrings(string sequence)
    {
        int sum = 0;
        char[] charSeparators = new char[] { ' ' }; //char array , containing the separators
        string[] splittedArray = sequence.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries); //string array with the splittet values
        foreach (string number in splittedArray)
        {
            sum += int.Parse(number);   //calculating the sum
        }
        return sum;
    }
}
