using System;

public static class Gigasecond
{
  ///expression-bodied method
  /// expression-bodied method consists of a single expression that returns a value whose type matches the method's return type,
  /// or, for methods that return void, that performs some operation.

    public static DateTime Add(DateTime moment) => moment.AddSeconds(1000000000);
}