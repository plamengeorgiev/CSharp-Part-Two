//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSort             //this is the recursive version of the quick sort
{
    static int Partition(string[] stringArray, int left, int right)
    {
        string x = stringArray[right];
        int i = left - 1;
        string temp = "";
        for (int j = left; j < right; j++)
        {
            if (string.Compare(stringArray[j], x) < 0)
            {
                i = i + 1;
                temp = stringArray[i];
                stringArray[i] = stringArray[j];
                stringArray[j] = temp;
            }
        }
        temp = stringArray[i + 1];
        stringArray[i + 1] = stringArray[right];
        stringArray[right] = temp;

        return i + 1;
    }

    static public void QuickSortMethod(string[] array, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(array, left, right);
            if (pivot > 1)
            {
                QuickSortMethod(array, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
               QuickSortMethod(array, pivot + 1, right);
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        string[] array = new string[length];
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = Console.ReadLine();
        }
        QuickSortMethod(array, 0, array.Length - 1);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
