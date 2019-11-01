using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        int strSize = input.Length;
        string strOuput;
        char[] inputArr = input.ToCharArray();
        char[] revArr = new char[strSize];

        for(int i = 0, j = strSize - 1;i < strSize;i++,j--)
        {
            revArr[i] = inputArr[j];
        }
        strOuput = new string(revArr);

        return strOuput;

    }
}