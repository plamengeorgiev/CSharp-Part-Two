//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;

class ReverseString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an expression to be checked: ");
        string expression = Console.ReadLine();
        int counter = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i]=='(') 
            {
                counter++;  //increasing the counter if an opening bracket is found
            }
            if (expression[i]==')')
            {
                counter--;  //decreasing the counter if a closing bracket is found
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("The expression is right");
        }
        else
        {
            Console.WriteLine("The expression is wrong!");
        }
    }
}
