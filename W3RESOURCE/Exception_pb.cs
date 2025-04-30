/* Write a C# program that prompts the user to input two numbers and
 divides them. Handle an exception when the user enters non-numeric 
 values.*/
using System;
namespace ExceptionPb
{
  class Prorgam
  {
    public static void Main(string[] args)
    {
      try
      {
        Console.Write("Enter First Number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Second Number:");
        int num2 = int.Parse(Console.ReadLine());

        if (num2 != 0)
        {
          int result = num1 / num2;
          Console.WriteLine("Result: " + result);
        }
        else
        {
          Console.WriteLine("Error:can't divide by zero.");
        }

      }
      catch (FormatException)
      {
        Console.WriteLine("Error: Non-numeric value entered.");
      }
      catch (Exception ex)
      {

        Console.WriteLine("An error occurred: " + ex.Message);


      }
    }
  }
}