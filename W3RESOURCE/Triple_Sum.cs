/* Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.

Sample Input:
1, 2
3, 2
2, 2
Expected Output:
3
5
12 */

using System;

class Program
{
  public static void Main(string[] args)
  {


    {

      Console.Write("Enter the first number: ");
      int num1 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the second number: ");
      int num2 = Convert.ToInt32(Console.ReadLine());


      int result = ComputeSum(num1, num2);


      Console.WriteLine("Result: " + result);
    }

    static int ComputeSum(int a, int b)
    {
      if (a == b)
      {
        return 3 * (a + b);
      }
      else
      {
        return a + b;
      }
    }
  }
}
