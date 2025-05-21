/* Write a C# Sharp program to check two given integers, and 
return true if one of them is 30 or if their sum is 30. */

using System;
namespace Check_Equals
{
    class Program
    {
    static void Main(string[] args)
    {
      int t1 = int.Parse(Console.ReadLine());
      int t2 = int.Parse(Console.ReadLine());
          
          if (t1 + t2==30)
          {
              Console.WriteLine("True");
          }
          else
          {
              Console.WriteLine("False");
          }
        
        }
    }
}