/*  Write a C# program to implement a method that takes 
an integer as input and throws an exception if the number is
 negative. Handle the exception in the calling code
 */

using System;
using System.Linq.Expressions;
namespace ExcepPrac
{
  class Program
  {

    static void ValidNum(int num)
    {
      if (num < 0)
      {
        throw new NegativeException("Negative number is not allowed");
      }
    
   }
    class NegativeException : Exception
    {
    public NegativeException(string message):base(message){}
   }
 
    public static void Main(string[] args)
    {
      try
      {
        Console.Write("Input an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        ValidNum(num);

        Console.WriteLine("Valid input: " + num);
      }
catch (NegativeException ex) {
    
      Console.WriteLine("Error: " + ex.Message);
    } catch (FormatException) {
   
      Console.WriteLine("Error: Invalid input. Please enter an integer.");
    } catch (Exception ex) {
     
      Console.WriteLine("An error occurred: " + ex.Message);
    }
    }
  }
}
