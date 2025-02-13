using System;
using System.Net.NetworkInformation;


class Program
{
  public static void Main(string[] args)
  {
    double R = double.Parse(Console.ReadLine());

    const double pi = 3.14159;
    double A = pi * (R * R);
    Console.WriteLine($"A={A:F4}");
  }
}