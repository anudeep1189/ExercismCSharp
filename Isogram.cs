using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string strWord = word.ToLower();//all should be equal         
        char[] ch = strWord.ToCharArray().Where(c => Char.IsLetter(c)).ToArray(); // get only letter in char array
        var disLetter = ch.Distinct(); // get distinct letter in the char array

        return (disLetter.Count() == ch.Count());

    }
}
