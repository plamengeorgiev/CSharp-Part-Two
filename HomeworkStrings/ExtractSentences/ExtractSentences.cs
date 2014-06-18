//Write a program that extracts from a given text all sentences containing given word.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;
class ExtractSentences
{
    static void Main(string[] args)
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        int index = 0;
        string[] strArray = text.Split('.');    //array, containing all the sentences
        for (int i = 0; i < strArray.Length; i++)
        {
            strArray[i] = strArray[i].Trim();   //trims the sentences
        }
        foreach (var sentence in strArray)
        {
            if (sentence.Contains(word))    //searches for the given substring - the word
            {
                index = 0;
                while (true)
                {
                    index = sentence.IndexOf(word, index, StringComparison.CurrentCultureIgnoreCase);   //takes the index
                    if (index < 0)
                    {
                        break;  //if there are no more substrings found - breaks the cycle
                    }
                    
                    
                    bool isFirstWord = (index - 1 < 0);     //checks if the found substring is the first word in the sentence
                    bool isLastWord = index + word.Length == sentence.Length;   //last word in the sentence
                    bool isPreviousALetter=true;
                    bool isNextALetter=true;
                    if (!isLastWord) //if it's not the last word - is the previous character a letter (small or capital)
                    {
                        isNextALetter = (ushort)sentence[index + word.Length] >= 97 && (ushort)sentence[index + word.Length] <= 122 || (ushort)sentence[index + word.Length] >= 65 && (ushort)sentence[index + word.Length] <= 90;
                    }
                    if (!isFirstWord)   //if it's not the first word - is the previous character a letter (small or capital)
                    {
                         isPreviousALetter = (ushort)sentence[index - 1] >= 97 && (ushort)sentence[index - 1] <= 122 || (ushort)sentence[index - 1] >= 65 && (ushort)sentence[index - 1] <= 90;    
                    }
                    //checks to see if the found substring is a separate word
                    if (isFirstWord && !isNextALetter ||        
                        isLastWord && !isPreviousALetter ||
                        !isPreviousALetter && !isNextALetter)
                    {
                        Console.WriteLine(sentence);    //prints the sentence on the console
                    }
                    index += word.Length;   //continues the search with updated index
                }
            }
        }
    }
}
