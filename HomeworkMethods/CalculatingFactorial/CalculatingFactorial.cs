using System;
class CalculatingFactorial
{
    static int[] AddArraysWithSameLength(int[] firstArray, int[] secondArray)   //these are the same methods
    {
        int temp = 0;
        int[] result = new int[firstArray.Length + 1];
        for (int i = result.Length - 1; i > 0; i--)
        {

            result[i] = ((firstArray[i - 1] + secondArray[i - 1]) + temp) % 10;
            temp = ((firstArray[i - 1] + secondArray[i - 1]) + temp) / 10;
        }
        if (temp != 0)
        {
            result[0] = temp;
            return result;
        }
        else
        {
            int[] newResult = new int[result.Length - 1];
            Array.Copy(result, 1, newResult, 0, newResult.Length);
            return newResult;
        }


    }
    static int[] AddArrays(int[] firstArray, int[] secondArray)     //these are the same methods
    {
        if (firstArray.Length != secondArray.Length)
        {
            if (firstArray.Length > secondArray.Length)
            {
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
                if (secondArray.Length > firstArray.Length)
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
    static void PrintArray(int[] arr)   //these are the same methods
    {

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
    }
    static int[] multiplyOneToNine(int[] numAsArr, int num)     
    {
        int[] result = new int[numAsArr.Length + 1];
        int temp = 0;
        for (int i = numAsArr.Length - 1; i >= 0; i--)
        {
            result[i + 1] = (numAsArr[i] * num + temp) % 10;
            temp = ((numAsArr[i] * num) + temp) / 10;       
        }
        if (temp != 0)      //the same logic as the adding of the arrays
        {
            result[0] = temp;
            return result;
        }
        else
        {
            int[] newResult = new int[result.Length - 1];
            Array.Copy(result, 1, newResult, 0, newResult.Length);
            return newResult;
        }
    }
    static int[] multiplyTenToNinetyNine(int[] numAsArr, int num)
    {
        int[] sumArray1 = multiplyOneToNine(numAsArr, num % 10);
        int[] sumArray2 = multiplyOneToNine(numAsArr, num / 10);
        int[] newSumArray2 = new int[sumArray2.Length + 1];
        Array.Copy(sumArray2, newSumArray2, sumArray2.Length);
        int[] result = AddArrays(sumArray1, newSumArray2);
        return result;
    }
    static void Main()
    {
        int[] result = new int[] { 1 };

        Console.Write("1! = 1");
        Console.WriteLine();
        for (int i = 2; i <= 99; i++)
        {
            if (i < 10)
            {
                result = multiplyOneToNine(result, i);
                Console.Write("{0}! = ", i);
                PrintArray(result);
                Console.WriteLine();
            }
            else
            {
                result = multiplyTenToNinetyNine(result, i);
                Console.Write("{0}! = ", i);
                PrintArray(result);
                Console.WriteLine();
            }
        }
        Console.Write("100! = ");   //i'm cheating a little with this - otherwise i could make a method with three arrays
        int[] resultNew = new int[result.Length + 2];       //and the program would work with numbers 1 to 999
        Array.Copy(result, resultNew, result.Length);
        PrintArray(resultNew);
    }
}
