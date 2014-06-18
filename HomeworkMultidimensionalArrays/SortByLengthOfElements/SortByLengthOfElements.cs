//You are given an array of strings. 
//Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortByLengthOfElements
{
    static void Main()
    {
        string[] strArray = new string[] { "pesho", "ivan", "haralampi", "ivo", "stefan" }; 
        int[,] info = new int[strArray.Length,2];   //contains the lengths of the elements of strArray AND their indexes
        int[] indexes = new int[strArray.Length];   //contains only the indexes
        for (int i = 0; i < strArray.Length; i++)
        {
            indexes[i] = strArray[i].Length;       //keeps the lengths of the strings
            info[i,0] = i;                      //keeps the indexes 
            info[i, 1] = strArray[i].Length;       //keeps the lengths
        }
        Array.Sort(indexes);
        string[] sorted = new string[strArray.Length];  //the array with the final result
        for (int i = 0; i < indexes.Length; i++)    //comparing the sorted lengths - from the shortest to the longest
        {
            for (int j = 0; j < sorted.Length; j++) //to the lengths that are paired with the indexes
			{
            if (indexes[i]==info[j,1])  //when a match is found
            {
                sorted[i] = strArray[info[j, 0]];   //the string is being copied in the final sorted array
            }
            }
        }
        foreach (var word in sorted)    //printing the result
        {
            Console.Write("{0} ",word);
        }
    }
}
