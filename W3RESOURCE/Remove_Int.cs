/* Write a C# Sharp program to create a list from a given list of integers, removing all values ending in 7. */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Int
{
  class Program
  {
    public static void Main(string[] args)
    {
    

      List<int> numbers = new List<int> { 10,22,35,47,53,67};


List<int> result=numbers.Where(n=>n%10!=7).ToList();

    foreach (int number in result)
      {
        Console.WriteLine(number);
      }
    
    }
  }
}