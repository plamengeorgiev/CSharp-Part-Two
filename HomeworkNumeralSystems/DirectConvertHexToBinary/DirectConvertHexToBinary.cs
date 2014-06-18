//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Text;

class DirectConvertHexToBinary
{

    static string ConvertToBinary(string hexNumber)
    {
        StringBuilder sb = new StringBuilder();     //stringbuilder for the result
        string result;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])   //switch - case for all the numbers - 0 to F
            {
                case '0':
                    {
                        sb.Append("0000");
                        break;
                    }
                case '1':
                    {
                        sb.Append("0001");
                        break;
                    }
                case '2':
                    {
                        sb.Append("0010");
                        break;
                    }
                case '3':
                    {
                        sb.Append("0011");
                        break;
                    }
                case '4':
                    {
                        sb.Append("0100");
                        break;
                    }
                case '5':
                    {
                        sb.Append("0101");
                        break;
                    }
                case '6':
                    {
                        sb.Append("0110");
                        break;
                    }
                case '7':
                    {
                        sb.Append("0111");
                        break;
                    }
                case '8':
                    {
                        sb.Append("1000");
                        break;
                    }
                case '9':
                    {
                        sb.Append("1001");
                        break;
                    }
                case 'A':
                    {
                        sb.Append("1010");
                        break;
                    }
                case 'B':
                    {
                        sb.Append("1011");
                        break;
                    }
                case 'C':
                    {
                        sb.Append("1100");
                        break;
                    }
                case 'D':
                    {
                        sb.Append("1101");
                        break;
                    }
                case 'E':
                    {
                        sb.Append("1110");
                        break;
                    }
                case 'F':
                    {
                        sb.Append("1111");
                        break;
                    }
                default:
                    break;
            }

        }
        result = Convert.ToString(sb);
        return result;
    }
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number: ");
        string hex = Console.ReadLine();
        Console.Write("The binary representation of the entered number is: {0}", ConvertToBinary(hex));
        Console.WriteLine();

    }
}
