using System;

class DistanceSample
{
  public static void Main(string[] args)
  {
    long n = long.Parse(Console.ReadLine());

    long result = (n % 2 == 0) ? (n / 2) : -((n + 1) / 2);
Console.WriteLine(result);
  }
}