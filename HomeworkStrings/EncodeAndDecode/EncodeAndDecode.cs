//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
//operation over the first letter of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeAndDecode
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the text, that you want to encode: ");
        string text = Console.ReadLine();
        Console.Write("Please enter a cipher: ");
        string cipher = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        //the two cycles start from 1, to escape the "divide by zero" exception during the encoding/decoding
        for (int i = 1; i < text.Length+1; i++) //itterating through the text
        {
            sb.Append((char)((ushort)text[i - 1] ^ (ushort)cipher.Length % i)); //encoding using xor
        }
        text = sb.ToString(); //writing the new value to the old variable
        sb.Clear();
        Console.WriteLine("The encoded text: {0}", text);
        for (int i = 1; i < text.Length+1; i++)
        {
            sb.Append((char)((ushort)text[i - 1] ^ (ushort)cipher.Length % i)); //decoding using xor 
        }
        text = sb.ToString(); ////writing the new value to the old variable
        Console.WriteLine("The decoded text: {0}", text);
    }
}
