//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
using System;
using System.Text;
class ConvertBaseSToBaseD
{
    static int ConvertFromSToDecimal(string number, int s)
    {
        int result = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            switch (number[i])
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
                        result += int.Parse(Convert.ToString(number[i])) * (int)Math.Pow(16, number.Length - 1 - i);
                        break;
                    }
                case 'A':
                    {
                        result += 10 * (int)Math.Pow(16, number.Length - 1 - i);
                        break;
                    }
                case 'B':
                    {
                        result += 11 * (int)Math.Pow(16, number.Length - 1 - i);
                        break;
                    }
                case 'C':
                    {
                        result += 12 * (int)Math.Pow(16, number.Length - 1 - i);
                        break;
                    }
                case 'D':
                    {
                        result += 13 * (int)Math.Pow(16, number.Length - 1 - i);
                        break;
                    }
                case 'E':
                    {
                        result += 14 * (int)Math.Pow(16, number.Length - 1 - i);
                        break;
                    }
                case 'F':
                    {
                        result += 15 * (int)Math.Pow(16, number.Length - 1 - i);
                        break;
                    }
                default:
                    break;
            }

        }
        return result;
    }   //modified version of task 04
    static string ConvertFromDecimalToD(int number, int d)
    {
        int remainder = 0;
        StringBuilder sb = new StringBuilder();
        if (number == 0)
        {
            return "0";
        }
        while (number > 0)
        {

            remainder = number % d;
            number /= d;
            if (remainder < 10)
            {
                sb.Append(remainder);
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
        StringBuilder result = new StringBuilder();
        for (int i = finalResult.Length - 1; i >= 0; i--)
        {
            result.Append(finalResult[i]);
        }
        finalResult = Convert.ToString(result);
        return finalResult;

    }   //modified version of task 03
    static void Main()
    {
        Console.Write("Please enter base S ( 2<=S<=16): ");
        int S = int.Parse(Console.ReadLine());
        Console.Write("Please enter base D ( 2<=D<=16): ");
        int D = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number in S-based numeral system: ");
        string inputNum = Console.ReadLine();
        //I'm using  the returned int value from ConvertFromSToDecimal as a parameter for the other method
        Console.WriteLine(ConvertFromDecimalToD(ConvertFromSToDecimal(inputNum, S), D));
    }
}
