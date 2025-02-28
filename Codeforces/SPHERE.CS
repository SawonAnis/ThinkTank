using System;
class Program
{
  public static void Main(string[] args)
  {
    double pi = 3.14159;
    int R = Convert.ToInt32(Console.ReadLine());

    double vol = (4.0 / 3) * pi * Math.Pow(R,3);

    Console.WriteLine($"VOLUME = {vol.ToString("F3")}");
  }
 }