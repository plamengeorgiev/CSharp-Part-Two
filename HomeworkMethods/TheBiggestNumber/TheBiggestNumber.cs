//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;
class TheBiggestNumber
{
    static int GetMax(int num1, int num2)
    {
        if (num1 >= num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Please enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Pleasen enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Pleasen enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("The biggest number is: {0}", GetMax(num1, GetMax(num2,num3)));
    }
}
