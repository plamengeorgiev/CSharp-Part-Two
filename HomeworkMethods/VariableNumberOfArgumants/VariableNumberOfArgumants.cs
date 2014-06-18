//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.

using System;

class VariableNumberOfArgumants     //i'm using params for the variable number of arguments
{
    static int MinValue(params int[] elements)
    {
        int min = int.MaxValue;
        foreach (var element in elements)       //itterates and returns the smallest element
        {
            if (element < min)
            {
                min = element;
            }
        }
        return min;
    }
    static int MaxValue(params int[] elements)    
    {
        int max = int.MinValue;
        foreach (var element in elements)       //itterates and returns the biggest element
        {
            if (element > max)
            {
                max = element;
            }
        }
        return max;
    }
    static decimal Average(params int[] elements)
    {
        decimal sum = 0;
        for (int i = 0; i < elements.Length; i++)       //calculates the sum of all elements
        {
            sum += elements[i];
        }
        return sum / elements.Length;   //and returns the average
    }
    static decimal Sum(params int[] elements)
    {
        decimal sum = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            sum += elements[i];     //calculates the sum of all elements
        }
        return sum;     //and returns it
    }
    static long Product(params int[] elements)
    {
        long product = 1;
        for (int i = 0; i < elements.Length; i++)   //itterates and returns the product af all the elements
        {
            product *= elements[i];     
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine("The minimal value in the array is: {0}",MinValue(3, 6, 4, -12423, -23));
        Console.WriteLine("The maximal value in the array is: {0}",MaxValue(3, 6, 4, -12423, -23));
        Console.WriteLine("The average value of the array is: {0}",Average(3, 6, 4, -12423, -23));
        Console.WriteLine("The sum of all the members of the array is: {0}",Sum(3, 6, 4, -12423, -23));
        Console.WriteLine("The product of all the members of the array is: {0}",Product(3, 6, 4, -12423, -23));
    }
}
