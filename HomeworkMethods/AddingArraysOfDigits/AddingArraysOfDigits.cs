//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
//the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

using System;

class AddingArraysOfDigits
{
    static void PrintArray(int[] array)     //method that prints an array
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    static int[] AddArraysWithSameLength(int[] firstArray, int[] secondArray)
    {
        //this method adds two arrays with samo length and returns a new array with the result
        int temp = 0;
        int[] result = new int[firstArray.Length + 1];  //the new array has one additional cell - which can be used if nesessary
        for (int i = result.Length - 1; i > 0; i--)
        {

            result[i] = ((firstArray[i - 1] + secondArray[i - 1]) + temp) % 10;
            temp = ((firstArray[i - 1] + secondArray[i - 1]) + temp) / 10;
        }
        if (temp != 0)          //temp is actually the "carry one"
        {
            result[0] = temp;   //the extra cell in the result is used only of there sum of the previous is>=10
            return result;
        }
        else
        {
            int[] newResult = new int[result.Length - 1];
            Array.Copy(result, 1, newResult, 0, newResult.Length);  //if the extra cell is useless - the result is copied in a smaller array
            return newResult;
        }
    }
    static int[] AddArrays(int[] firstArray, int[] secondArray)
    {
        if (firstArray.Length != secondArray.Length)
        {
            if (firstArray.Length > secondArray.Length)         //this creates a new array - the second array+leading zeroes
            {                                                   //so that the lengths of the two arrays are equal
                int[] newArr = new int[firstArray.Length];  
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (secondArray.Length - firstArray.Length + i < 0)
                    {
                        newArr[i] = 0;
                    }
                    else
                    {
                        newArr[i] = secondArray[i - (firstArray.Length - secondArray.Length)];
                    }
                }
                return AddArraysWithSameLength(firstArray, newArr);
            }
            else
            {
                if (secondArray.Length > firstArray.Length)     //the same - but this time with the first array
                {
                    int[] newArr = new int[secondArray.Length];
                    for (int i = 0; i < secondArray.Length; i++)
                    {
                        if (firstArray.Length - secondArray.Length + i < 0)
                        {
                            newArr[i] = 0;
                        }
                        else
                        {
                            newArr[i] = firstArray[i - (secondArray.Length - firstArray.Length)];
                        }
                    }
                    return AddArraysWithSameLength(secondArray, newArr);
                }
            }
        }
        return AddArraysWithSameLength(firstArray, secondArray);
    }
    static void Main()
    {
        int[] array1 = new int[] { 3,1, 9, 9, 9, 9, 9, 9 };
        int[] array2 = new int[] { 4,3, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
        int[] result = AddArrays(array1, array2);
        Console.WriteLine("The first number: ");
        PrintArray(array1);
        Console.WriteLine("The second number");
        PrintArray(array2);
        Console.WriteLine("The sum of the two numbers: ");
        PrintArray(result);
    }
}