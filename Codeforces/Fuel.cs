using System;

class Program
{
  public static void Main(string[] args)
  {
    int time =Convert.ToInt32(Console.ReadLine());
      int speed =Convert.ToInt32(Console.ReadLine());

    int distance = time * speed;

    double fuelNeed = distance / 12.0;

    Console.WriteLine(fuelNeed.ToString("F3"));
  }
}