using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
      //evenly divisible by 100
      //if it is divisible by 100 it should also be divisible by 400
      //Except this, all other years evenly divisible by 4 are leap years.

      if(year%4 == 0)
      {
        if(year%100 == 0)
            {
                if(year%400 == 0)
                {     
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
      }
      else
      {
          return false;
      }
   
    }
}