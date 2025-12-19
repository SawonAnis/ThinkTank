using System;

namespace ElephantEx
{
  class Program
  {
    public static void Main(string[] args)
    {
      int x = int.Parse(Console.ReadLine());
      int steps=(x+4)/5;
      Console.WriteLine(steps);
    }
  }
}