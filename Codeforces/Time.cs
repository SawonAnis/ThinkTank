using System;

class Program
{
  public static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());

    int hours = N / 3600;
    int minutes = (N % 3600) / 60;
    int seconds = N % 60;

    Console.WriteLine($"{hours}:{minutes}:{seconds}");
  }
}