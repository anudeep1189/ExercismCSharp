using System;

public static class Leap
{
  //evenly divisible by 100
  //if it is divisible by 100 it should also be divisible by 400
  //Except this, all other years evenly divisible by 4 are leap years.
  
  //Using expression-bodied method.
    public static bool IsLeapYear(int year) => ((year % 4 == 0 ) && (year % 100 != 0 || year % 400 == 0));
  
}