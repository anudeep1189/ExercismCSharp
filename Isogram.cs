using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string strWord = word.ToLower();//all should be equal
        char[] charWord = strWord.ToCharArray(); 
        Array.Sort(charWord); // sort to lessen the number of iteration
        for (int i = 0; i < charWord.Length - 1; i++)
        {
            //just need to compare the next one
            if (charWord[i] == charWord[i + 1] && char.IsLetter(charWord[i]))
            {
                return false;
            }
        }
        return true;
    }
}