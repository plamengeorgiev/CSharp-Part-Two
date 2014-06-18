//Write a method that reverses the digits of given decimal number. Example: 256 -> 652

using System;
using System.Text;

class DecimalNumberReversed
{
    static decimal ReverseNumber(decimal number)
    {

        string strNumber = number.ToString();
        char[] charArray = new char[strNumber.Length];  //i'm using a char array, because of the decimal separator
        for (int i = 0; i < charArray.Length; i++)
        {
            charArray[i] = strNumber[i];
        }
        Array.Reverse(charArray);   
        StringBuilder sb = new StringBuilder(); //then i'm using the stringbuilder, and i'm converting the char array to string
        for (int i = 0; i < charArray.Length; i++)
        {
            sb.Append(charArray[i].ToString());
        }
        strNumber = sb.ToString();
        return decimal.Parse(strNumber);    //finally the number is parsed as a decimal again
    }

    static void Main()
    {
        Console.Write("Please enter a decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine(ReverseNumber(number));
    }
}