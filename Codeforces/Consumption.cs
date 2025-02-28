using System;
class Program
{
  public static void Main(string[] args)
  {
    int X = int.Parse(Console.ReadLine());
    double Y = double.Parse(Console.ReadLine());

    double Z = X / Y;

    Console.WriteLine("{0:F3} km/l",Z);
  }
}