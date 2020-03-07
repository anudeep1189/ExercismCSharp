using System;
using System.Diagnostics;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        int i = 0;

            string Alphabets = "abcdefghijklmnopqrstuvwxyz";
            
            input = input.ToLower();
            foreach (char alpha in Alphabets)
            {
                foreach (char inputChar in input)
                {
                   
                    if (alpha == inputChar)
                    {
                        i++;
                        break;
                    } 
                }
            }
            if(i == 26)
            {
                return true;

            }
            else
            {
                return false;
            }
    }
}
