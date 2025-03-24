using System;

class Program
{
  public static void Main(string[] args)
  {
    int s= int.Parse(Console.ReadLine());
    while (s-- > 0)
    {

      int t = int.Parse(Console.ReadLine());
      if (t <= 1399)
      {
        Console.WriteLine("Division 4");
      }
      else if (t <= 1599)
      {
        Console.WriteLine("Division 3");
      }
      else if (t <= 1899)
      {
        Console.WriteLine("Division 2");
      }
      else if (t >= 1900)
      {
        Console.WriteLine("Division 1");
      }
    }
  }
}