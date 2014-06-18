//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
//Use try-catch-finally.

using System;

class CalculateSquareRoot
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");  
        string strNumber = Console.ReadLine();  //string for the input
        int number = 0;
        try
        {
            number = int.Parse(strNumber);  //parsing the string
            Console.WriteLine("Parsed successfully");
            if (number<0)
            {
                throw new NegativeNumberException();    //throwing a new exception
            }
            Console.WriteLine("The square root of the entered number is: {0}", Math.Sqrt(number)); //if everything is correct - the square root of the number is printed on the console
        }
        catch (NegativeNumberException) //catching the thrown exception
        {
            Console.WriteLine("You've entered a negative number");
        }
        catch (FormatException) //standart
        {
            Console.WriteLine("Your input was not an integer number");
        }
        catch (OverflowException)   //standart
        {
            Console.WriteLine("The entered number was too big to fit in an integer variable");
        }
        finally
        {
            Console.WriteLine("Goodbye");   //this code will always be executed
        }
    }
    class NegativeNumberException : FormatException //creating a new exception for the negative numbers
    {
    }
}
