using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        int i = 0;
        char[] Alphabets;
        Alphabets = new char[]{'a', 'b', 'c', 'd','e','f','g','h','i','j',
                'k','l','m','n','o','p','q','u','r','s','t','u','v','w','x','y','z'};
            
            foreach (char alpha in Alphabets)
            {
                foreach (char inputChar in input.ToLower())
                {
                    if (alpha == inputChar)
                    {
                        i++;
                        break;
                    }
                }
            }
            if(i == 27)
            {
                return true;
            }
            else
            {
                return false;
            }
    }
}
