//Write a program to convert decimal numbers to their binary representation.

using System;

class ConvertDecimalToBinary
{
    static int[] ConvertToBinary(int number)
    {
        int[] decimalArr = new int[32];
        bool isNegative = false;
        if (number < 0)
        {
            number = (int.MaxValue + number) + 1;   //2147483648+number - this way I don't have to use "long"
            isNegative = true;

        } 
        for (int i = 0; i < decimalArr.Length-1; i++)
        {
            decimalArr[i] = number % 2;     //takes the remainder of the division
            number /= 2;                 
        }
        Array.Reverse(decimalArr);      //reverses the array with all the remainders
        if (isNegative)
        {
            decimalArr[0] = 1;          //if the entered number was negative - the leftmost bit is set to "1" 
        }
        return decimalArr;
    }
    static void Main()
    {
        Console.WriteLine("Please enter a decimal number in the range [ -2 147 483 648 , 2 147 483 647] ");
        int number = int.Parse(Console.ReadLine());       
        int[] decimalArr = (ConvertToBinary(number));
        Console.WriteLine("The binary representation of the entered number is: ");
        for (int i = 0; i < 32; i++)
        {
            Console.Write(decimalArr[i]);
        }
        Console.WriteLine();
    }
}
