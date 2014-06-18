//Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//percentage and in scientific notation. Format the output aligned right in 15 symbols.

using System;

class DifferentPrint
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Printed as a decimal number: {0,15:D}", number);
        Console.WriteLine("Printed as a hexadecimal number: {0,15:X}", number);
        Console.WriteLine("Printed as a percentage: {0,15:P}", number);
        Console.WriteLine("Printed as a scientific notation: {0:E}", number);
    }
}
