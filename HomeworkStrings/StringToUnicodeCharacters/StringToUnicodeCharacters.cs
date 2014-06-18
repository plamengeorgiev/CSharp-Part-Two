//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
using System;

class StringToUnicodeCharacters
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("\\u{0:x4}",(ushort)word[i]); //using format strings :)
            }
            Console.WriteLine();
        }
    }
