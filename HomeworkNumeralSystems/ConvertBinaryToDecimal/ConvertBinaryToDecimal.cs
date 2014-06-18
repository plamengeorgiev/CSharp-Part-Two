//Write a program to convert binary numbers to their decimal representation.

using System;

class ConvertBinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a binary number:");
        string binary = Console.ReadLine();
        int[] binArr = new int[32];
        for (int i = 0; i < binary.Length; i++)
        {
            binArr[i+(32-binary.Length)] = int.Parse(Convert.ToString(binary[i]));
        }
        Console.WriteLine("The binary representation of the entered number as a 32-bit signed integer: ");
        for (int i = 0; i < binArr.Length; i++) //printing the binary representation
        {
            Console.Write(binArr[i]);
        }
        Console.WriteLine();
        int result = 0;
        for (int i = binArr.Length-1; i >=1 ; i--)  //iterrating through the elements of the array
        {
            result += binArr[i] * (int)Math.Pow(2, binArr.Length - 1 - i);  //calculating the decimal value
        }
        if (binArr[0]==1)
        {
            result = -((int.MaxValue - result)+1);
        }
        Console.Write("The entered number in decimal numeral system: ");
        Console.WriteLine(result);
    }
}
