using System;


public static class Pangram
{
    public static bool IsPangram(string input)
    {
        bool[] isAlphabetarr = new bool[26];//default all value will be false
        input = input.ToLower();

        for (int i = 0; i < input.Length; i++)
        {
            //value of a = 97 and z = 122
            if ('a' <= input[i] && 'z' >= input[i])
            {
                isAlphabetarr[input[i] - 'a'] = true;   //array number represent alpabets a-z = 0 - 25 respectively
            }
        }

        for (int j = 0; j <= 25; j++)    //check if any value in the array is false
        {
            if (isAlphabetarr[j] == false)
            {
                return false;
            }
        }

        return true; // if all are present
    }
}
