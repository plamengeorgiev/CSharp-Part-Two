using System;
using System.Text;

class TheThreeTasks
{
    static void ReverseNumber()
    {
        Console.Write("Please enter a non-negative decimal number: ");  //the method from the 07 problem
        decimal number = decimal.Parse(Console.ReadLine());
        if (ValidateDecimalNumber(number))  //i've put the validation in the method - it could also be in the switch-case cycle
        {
            string strNumber = number.ToString();
            char[] charArray = new char[strNumber.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = strNumber[i];
            }
            Array.Reverse(charArray);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < charArray.Length; i++)
            {
                sb.Append(charArray[i].ToString());
            }
            strNumber = sb.ToString();
            number=decimal.Parse(strNumber);
            Console.Write("The reversed decimal number is: {0}", number);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Wrong Input! The decimal number should be non-negative!");
        }
        
    }
    static bool ValidateDecimalNumber(decimal number)
    {
        bool result = number >= 0;
        return result;
    }
    static void AverageOfSequence()     //this one is pretty standart
    {
        Console.Write("Please enter the number of integers N= ");
        int n = int.Parse(Console.ReadLine());
        if (ValidateSequence(n))
        {
            decimal result = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Number {0} = ", i + 1);
                result += int.Parse(Console.ReadLine());
            }
            result /= n;
            Console.WriteLine("The average of the entered sequence is: {0:F2}", result);
        }
        else
        {
            Console.WriteLine("Wrong input! The sequence should not be empty!");
        }
        
    }
    static bool ValidateSequence(int n)
    {
        bool result = n > 0;
        return result;
    }
    static void LinearEquation()        //this one is pretty stanart
    {
        Console.Write("Please enter coefficient a = ");
        decimal a = int.Parse(Console.ReadLine());
        Console.Write("Please enter coefficient b = ");
        decimal b = int.Parse(Console.ReadLine());
        if (ValidateCoefficient(a))
        {
            decimal result = -b / a;
            Console.WriteLine("x={0:F2}", result);    
        }
        else
        {
            Console.WriteLine("Wrong input! The coefficient a shoud not be equal to 0!");
        }
        
    }
    static bool ValidateCoefficient(decimal a)
    {
        bool result = a != 0;
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Please choose a task from the menu below and enter your choice: ");
        Console.WriteLine("Task 1: Reverse the digits of a decimal number");
        Console.WriteLine("Task 2: Calculate the average of a sequence of integers");
        Console.WriteLine("Task 3: Solve a linear equation: a*x + b = 0 ");
        Console.Write("Please enter the number of the task, that you want to solve: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice) //standart switch case for the choice of the user
        {
            case 1:
                {
                    Console.WriteLine("Your choice is: Task 1 - Reversing the digits of a decimal number");
                    ReverseNumber();
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Your choice is: Task 2 - Calculating the average of a sequence of integers");
                    AverageOfSequence();
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Your choice is: Task 3 - Solving the linear eqution a*x+b=0");
                    LinearEquation();
                    break;
                }
            default:
                {
                    Console.WriteLine("Wrong input! You should enter a number between 1 and 3");
                }
                break;
        }
    }
}