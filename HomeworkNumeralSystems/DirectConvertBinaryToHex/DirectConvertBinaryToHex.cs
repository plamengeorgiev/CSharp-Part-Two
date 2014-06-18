using System;
using System.Text;

class DirectConvertBinaryToHex
{
    static string ConvertToHex(int[] binArr)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i <binArr.Length; i += 4)
        {
            StringBuilder temp = new StringBuilder();   
            temp.Append(binArr[i]);
            temp.Append(binArr[i + 1]);
            temp.Append(binArr[i + 2]);
            temp.Append(binArr[i + 3]);
            string nibble = Convert.ToString(temp);
            switch (nibble)
            {
                case "0000":
                    {
                        sb.Append("0");
                        break;
                    }
                case "0001":
                    {
                        sb.Append("1");
                        break;
                    }
                case "0010":
                    {
                        sb.Append("2");
                        break;
                    }
                case "0011":
                    {
                        sb.Append("3");
                        break;
                    }
                case "0100":
                    {
                        sb.Append("4");
                        break;
                    }
                case "0101":
                    {
                        sb.Append("5");
                        break;
                    }
                case "0110":
                    {
                        sb.Append("6");
                        break;
                    }
                case "0111":
                    {
                        sb.Append("7");
                        break;
                    }
                case "1000":
                    {
                        sb.Append("8");
                        break;
                    }
                case "1001":
                    {
                        sb.Append("9");
                        break;
                    }
                case "1010":
                    {
                        sb.Append("A");
                        break;
                    }
                case "1011":
                    {
                        sb.Append("B");
                        break;
                    }
                case "1100":
                    {
                        sb.Append("C");
                        break;
                    }
                case "1101":
                    {
                        sb.Append("D");
                        break;
                    }
                case "1110":
                    {
                        sb.Append("E");
                        break;
                    }
                case "1111":
                    {
                        sb.Append("F");
                        break;
                    }
                default:
                    break;
            }
        }
        
        string result = Convert.ToString(sb);
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Please enter a binary number:");
        string binary = Console.ReadLine();
        int[] binArr = new int[32];     //using the array to turn the entered string in a 32-bit integer (binary representation)
        for (int i = 0; i < binary.Length; i++)
        {
            binArr[i + (32 - binary.Length)] = int.Parse(Convert.ToString(binary[i]));
        }
        Console.WriteLine("The entered number with all the bits: ");
        for (int i = 0; i < binArr.Length; i++)
        {
            Console.Write(binArr[i]);
        }
        Console.WriteLine();
        //The result is printed on the console without the leading zeros - I used the .TrimStart 
        Console.WriteLine("The entered number as a hexadecimal number: {0}", ConvertToHex(binArr).TrimStart(new Char[] { '0' } ));
        
    }
}
