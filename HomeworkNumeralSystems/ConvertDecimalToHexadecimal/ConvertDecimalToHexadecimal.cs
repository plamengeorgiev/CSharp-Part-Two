//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Text;

class ConvertDecimalToHexadecimal
{
    static string ConvertToHexadecimal(int number)
    {
        int remainder = 0;
        StringBuilder sb = new StringBuilder();
        if (number==0)
        {
            return "0";
        }
        while (number>0)
        {
            
            remainder = number % 16;
            number /= 16;
            if (remainder<10)
            {
                sb.Append(remainder);   //stringbuilder for the result
            }
            else
            {
                switch (remainder)
                {
                    case 10: 
                        {
                            sb.Append("A");
                            break;
                        }
                    case 11:
                        {
                            sb.Append("B");
                            break;
                        }
                    case 12:
                        {
                            sb.Append("C");
                            break;
                        }
                    case 13:
                        {
                            sb.Append("D");
                            break;
                        }
                    case 14:
                        {
                            sb.Append("E");
                            break;
                        }
                    case 15:
                        {
                            sb.Append("F");
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        string finalResult = Convert.ToString(sb);  
        StringBuilder result = new StringBuilder(); //temp variable for reversing the result
        for (int i = finalResult.Length-1; i >=0 ; i--) //iterrating through the string 
        {
            result.Append(finalResult[i]);  //and writing the values in another stringbuilder
        }
        finalResult= Convert.ToString(result);  //the reversed stringbuilder is kept in finalResult
        return finalResult;
            
    }
    static void Main(string[] args)
    {
        Console.Write("Please enter a number in decimal numeral system: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(ConvertToHexadecimal(number));
    }
}
