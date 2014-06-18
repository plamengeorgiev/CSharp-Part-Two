//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class SieveOfEratosthenes
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10000000];      //this array holds the numbers 1...10000000
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }
        int[] sieve = new int[10000000];       //this is the "sieve" - it holds only zeroes and ones
        for (int i = 2; i < numbers.Length; i++)
        {
            if (sieve[i] == 0)                 // 0 - means the number numbers[i] is prime
            {
                Console.WriteLine(numbers[i]);
                for (int j = i; j < numbers.Length; j += i)   //iterates through the "sieve"
                {
                    sieve[j] = 1;              //marks the positions of the "sieve" - the non-prime numbers

                }
            }

        }
    }
}