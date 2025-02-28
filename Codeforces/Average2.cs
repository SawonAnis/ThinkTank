using System;

class Program
{
  public static void Main(string[] args)
  {
     string[] input = Console.ReadLine().Split();
        int X = int.Parse(input[0]); 
        int Y = int.Parse(input[1]); 
    double Total;
    if (X == 1)
    {
      Total = 4 * Y;
      Console.WriteLine($"Total: R$ {Total:F2}");
    }
   else if (X == 2)
    {
      Total = 4.50 * Y;
      Console.WriteLine($"Total: R$ {Total:F2}");
    }
   else if (X == 3)
    {
      Total = 5 * Y;
      Console.WriteLine($"Total: R$ {Total:F2}");
    }
   else if (X == 4)
    {
      Total = 2 * Y;
      Console.WriteLine($"Total: R$ {Total:F2}");
    }
 else if (X == 5)
    {
      Total = 1.50 * Y;
      Console.WriteLine($"Total: R$ {Total:F2}");
}

  }
}