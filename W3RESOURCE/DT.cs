/*  Write a C# Sharp program to display the Day properties
 (year, month, day, hour, minute, second, millisecond etc.)
 */

using System;

namespace DTEx
{
  public class DT
  {
    public static void Main(string[] args)
    {
      System.DateTime moment = new System.DateTime(2025, 07, 29, 8, 44, 5, 100);
     
        Console.WriteLine("year = " + moment.Year);

    
        Console.WriteLine("month = " + moment.Month);

    
        Console.WriteLine("day = " + moment.Day);

    
        Console.WriteLine("hour = " + moment.Hour);

        Console.WriteLine("minute = " + moment.Minute);

     
        Console.WriteLine("second = " + moment.Second);

        Console.WriteLine("millisecond = " + moment.Millisecond);
    }
  }
}