//Extend the program to support also subtraction and multiplication of polynomials.

using System;

class SubstractAndMultiplyPolynomials
{
    static void PrintPolynomials(int[] arr) //this one is the same
    {

        if (arr[arr.Length - 1] != 0)
        {
            Console.Write("{0}x^{1}", arr[arr.Length - 1], arr.Length - 1);
        }
        for (int i = arr.Length - 2; i > 0; i--)
        {
            if (arr[i] > 0)
            {
                Console.Write("+{0}x^{1}", arr[i], i);
            }
            if (arr[i] < 0)
            {
                Console.Write("{0}x^{1}", arr[i], i);
            }
        }
        if (arr[0] > 0)
        {
            Console.Write("+" + arr[0]);
        }
        if (arr[0] < 0)
        {
            Console.Write(arr[0]);
        }
        Console.WriteLine();
    }

    static int[] AddPolynomials(int[] pol1, int[] pol2)     //this is the same
    {
        int[] result = new int[0];
        if (pol1.Length >= pol2.Length)
        {
            result = new int[pol1.Length];
            for (int i = 0; i < pol2.Length; i++)
            {
                result[i] = pol1[i] + pol2[i];
            }
            for (int i = pol2.Length; i < pol1.Length; i++)
            {
                result[i] = pol1[i];
            }
        }
        if (pol2.Length > pol1.Length)
        {
            result = new int[pol2.Length];
            for (int i = 0; i < pol1.Length; i++)
            {
                result[i] = pol2[i] + pol1[i];
            }
            for (int i = pol1.Length; i < pol2.Length; i++)
            {
                result[i] = pol2[i];
            }
        }
        return result;
    }
    static int[] SubstractPolynomials(int[] pol1, int[] pol2)   //this is almost the same
    {
        int[] result = new int[0];
        if (pol1.Length >= pol2.Length)
        {
            result = new int[pol1.Length];
            for (int i = 0; i < pol2.Length; i++)
            {
                result[i] = pol1[i] - pol2[i];  //but the second polynomial is being extracted from the first
            }
            for (int i = pol2.Length; i < pol1.Length; i++)
            {
                result[i] = pol1[i];
            }
        }
        if (pol2.Length > pol1.Length)
        {
            result = new int[pol2.Length];
            for (int i = 0; i < pol1.Length; i++)
            {
                result[i] = pol1[i] - pol2[i];
            }
            for (int i = pol1.Length; i < pol2.Length; i++)
            {
                result[i] = -pol2[i];       //if the second one is longer - its values are copied in the result with "-"
            }
        }
        return result;
    }
    static int[] MultiplyPolynomials(int[] pol1, int[] pol2)
    {
        int[] result = new int[pol1.Length + pol2.Length - 1];  //the result of the multiplications is much longer
        for (int i = 0; i < pol1.Length; i++)
        {
            for (int j = 0; j < pol2.Length; j++)   //nested loops for the multiplication itself
            {
                result[i + j] += pol2[j] * pol1[i];
            }
        }
        return result;
    }
    static void Main()
    {
        int[] firstPol = new int[] { 3, 7, 12,18,-3,-1};
        int[] secondPol = new int[] { -2, 0, 8, 4 };
        Console.Write("The first polynomial: ");
        PrintPolynomials(firstPol);
        Console.Write("The second polynomial: ");
        PrintPolynomials(secondPol);
        Console.WriteLine("polynomial1+polynomial2: ");
        PrintPolynomials(AddPolynomials(firstPol, secondPol));
        Console.WriteLine("polynomial1-polynomial2:");
        PrintPolynomials(SubstractPolynomials(firstPol,secondPol));
        Console.WriteLine("polynomial2-polynomial1:");
        PrintPolynomials(SubstractPolynomials(secondPol, firstPol));
        Console.WriteLine("polynomial1*polynomial2:");
        PrintPolynomials(MultiplyPolynomials(firstPol, secondPol));
    }
}