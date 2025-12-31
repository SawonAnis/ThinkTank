using System;
namespace Single_Number
{
class Program
  {
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter array elements:");
        string input = Console.ReadLine();

      int[] nums= Array.ConvertAll(input.Split(' '), int.Parse);
         int result = 0;
        foreach (int num in nums)
        {
            result = result ^ num;
        }

        Console.WriteLine("Single Number: " + result);
    }
  }
}