/*  Write a C# program that prompts the user to input a numeric
 integer and throws an exception if the 
number is less than 0 or greater than 1000.
 */

using System;
namespace ExcepPrac
{
  class Program
  {

    static void NumRange(int n)
    {
      if (n < 0 || n > 1000)
      {
        throw new NumberOutofRangeexception("Number is out of range.Please enter a number between 0 to 1000");

      }
    }
    class NumberOutofRangeexception : Exception
    {
      public NumberOutofRangeexception(string message) : base(message) { }
    }
    public static void Main(string[] args)
    {
      try
      {
        int n = Convert.ToInt32(Console.ReadLine());
        NumRange(n);
        Console.WriteLine("Valid input: " + n);
      }
      catch (NumberOutofRangeexception ex)
      {
        Console.WriteLine("Error: " + ex.Message);
      }
      catch (FormatException)
      {

        Console.WriteLine("Error: Invalid input. Please enter a numeric integer.");
      }
      catch (Exception ex)
      {

        Console.WriteLine("An error occurred: " + ex.Message);
      }
    }
  }
}

