/*Write a C# Sharp program to get the absolute difference between n
 and 51. If n is broader than 51 return triple the absolute difference. */

using System;
namespace Diff
{
  class Program
  {
    public static void Main(string[] args)
    {
      const int x = 51;
      int a = int.Parse(Console.ReadLine());
      int b = x - a;
        int r = (a-x) * 3;
      if (a>x)
      {

        Console.WriteLine(r);
      }
      else
      {
        Console.WriteLine(b);
      }
    }
  }
}