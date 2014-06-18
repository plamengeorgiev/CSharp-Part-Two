//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class Program
{
    static int ConvertToDecimal(string hexNumber)
    {
        int result = 0;
        for (int i = hexNumber.Length-1; i >=0 ; i--)
        {
            switch (hexNumber[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    {
                        result += int.Parse(Convert.ToString(hexNumber[i])) * (int)Math.Pow(16, hexNumber.Length - 1 - i);
                        break;
                    }
                case 'A':
                    {
                        result += 10 * (int)Math.Pow(16, hexNumber.Length - 1 - i);
                        break;
                    }
                case 'B':
                    {
                        result += 11 * (int)Math.Pow(16, hexNumber.Length - 1 - i);
                        break;
                    }
                case 'C':
                    {
                        result += 12 * (int)Math.Pow(16, hexNumber.Length - 1 - i);
                        break;
                    }
                case 'D':
                    {
                        result += 13 * (int)Math.Pow(16, hexNumber.Length - 1 - i);
                        break;
                    }
                case 'E':
                    {
                        result += 14 * (int)Math.Pow(16, hexNumber.Length - 1 - i);
                        break;
                    }
                case 'F':
                    {
                        result += 15 * (int)Math.Pow(16, hexNumber.Length - 1 - i);
                        break;
                    }
                default:
                    break;
            }
            
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Please enter a number in hexadecimal numeral system: ");
        string hexNumber = Console.ReadLine();
        Console.WriteLine(ConvertToDecimal(hexNumber));
    }
}
