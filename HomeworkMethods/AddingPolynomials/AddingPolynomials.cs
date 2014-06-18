//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5  -> 5|0|1

using System;

class AddingPolynomials
{
    static void PrintPolynomial(int[] arr)  //modified prnting, minding the signs of the elements
    {

        if (arr[arr.Length - 1] != 0)   //if the first coefficient is !=0, it's printed without a sign or with a "-" if it's <0
        {
            Console.Write("{0}x^{1}", arr[arr.Length - 1], arr.Length - 1);
        }
        for (int i = arr.Length - 2; i > 0; i--)
        {
            if (arr[i] > 0)
            {
                Console.Write("+{0}x^{1}", arr[i], i);  //the next ones are printed with "+"
            }
            if (arr[i] < 0)
            {
                Console.Write("{0}x^{1}", arr[i], i);   //or with the "-" of the coefficient
            }
        }
        if (arr[0] > 0)
        {
            Console.Write("+" + arr[0]);    //and again with "+"
        }
        if (arr[0] < 0)
        {
            Console.Write(arr[0]);          //or with the "-" of the coefficient
        }
        Console.WriteLine();
    }

    static int[] AddPolynoms(int[] pol1, int[] pol2)
    {
        int[] result = new int[0];
        if (pol1.Length >= pol2.Length)
        {
            result = new int[pol1.Length];  //the result has the same length as the longest polynomial
            for (int i = 0; i < pol2.Length; i++)   //the cycle ends when the end of the shortest array is reached
            {
                result[i] = pol1[i] + pol2[i];
            }
            for (int i = pol2.Length; i < pol1.Length; i++) //then the values of the longer one are copied in the result array
            {
                result[i] = pol1[i];
            }
        }
        if (pol2.Length > pol1.Length)
        {
            result = new int[pol2.Length];  //the result has the same length as the longest polynomial
            for (int i = 0; i < pol1.Length; i++)   //the cycle ends when the end of the shortest array is reached
            {
                result[i] = pol2[i] + pol1[i];
            }
            for (int i = pol1.Length; i < pol2.Length; i++) //then the values of the longer one are copied in the result array
            {
                result[i] = pol2[i];
            }
        }
        return result;
    }
    static void Main()
    {
        int[] firstPol = new int[] { 3, 7, -12, 4, -4, 0, 13, -6 };
        int[] secondPol = new int[] { -2, 0, 8, -4 };
        Console.Write("The first polynom: ");
        PrintPolynomial(firstPol);
        Console.Write("The second polynom: ");
        PrintPolynomial(secondPol);
        Console.Write("Polynom1+polynom2: ");
        PrintPolynomial(AddPolynoms(firstPol, secondPol));
    }
}
