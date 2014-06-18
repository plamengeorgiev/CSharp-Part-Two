//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class ShortBinaryRepresentation     //this task is the same as the first one - only int32 is changed to int16
{
    static int[] ConvertToBinary(int number)
    {
        int[] decimalArr = new int[16];
        bool isNegative = false;
        if (number < 0)
        {
            number = (short.MaxValue + number) + 1;
            isNegative = true;

        }
        for (int i = 0; i < decimalArr.Length - 1; i++)
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
        Console.WriteLine("Please enter a decimal number in the range [-32768 , 32767] ");
        int number = int.Parse(Console.ReadLine());
        int[] decimalArr = (ConvertToBinary(number));
        Console.WriteLine("The binary representation of the entered number is: ");
        for (int i = 0; i < decimalArr.Length; i++)
        {
            Console.Write(decimalArr[i]);
        }
        Console.WriteLine();
    }
}
