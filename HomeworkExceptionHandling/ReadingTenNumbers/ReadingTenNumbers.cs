using System;

class ReadingTenNumbers
{
    static int ReadNumber(int start, int end)
    {
        string strNumber = Console.ReadLine();  //reading the input in a string variable
        int number = 0;
        try
        {
            number = int.Parse(strNumber);  //parsing in the try-block
            if (number < start || number > end)     //condition to check if the number is in the interval [1,100]
            {
                throw new ArgumentNotInTheIntervalException();  //throwing a new exception
            }
            return number;  //if everything is correct - the number is returned

        }
        catch (ArgumentNotInTheIntervalException)   //catch the thrown exception
        {
            Console.WriteLine("The entered number is not in the specified interval");
        }
        catch (FormatException) //standart
        {
            Console.WriteLine("Your input was not an integer number");
        }
        catch (OverflowException)   //standart
        {
            Console.WriteLine("The entered number was too big to fit in an integer variable");
        }
        return 0;   //if an exception is caugth - the method returns "0"
        
    }
    static void Main()
    {
        int[] array = new int[10];  //array for the entered numbers
        for (int i = 0; i < array.Length; i++)  //for cycle to call the method 10 times
        {
            while (array[i]==0) //while cycle to ask the user for another value if the method has thrown an exception
            {
                Console.Write("Enter number {0} = ", i+1);
                array[i] = ReadNumber(1, 100);    
            }
        }
        foreach (var item in array) //foreach cycle to print the entered numbers on the console
        {
            Console.Write("{0}, ",item);
        }
        Console.WriteLine();
    }
    class ArgumentNotInTheIntervalException : ArgumentOutOfRangeException   //exception for numbers outside of the interval [1, 100]
    {
    }
}
