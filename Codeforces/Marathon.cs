using System;
using System.Runtime.InteropServices;
class Program
{

  public static void Main(string[] args)
  {
    int t = int.Parse(Console.ReadLine());

    while (t-- > 0)
    {
      string[] input = Console.ReadLine().Split();
      int a = int.Parse(input[0]);
      int b = int.Parse(input[1]);
      int c = int.Parse(input[2]);
      int d = int.Parse(input[3]);

      int count = 0;

      if (b > a) count++;
      if (c > a) count++;
      if (d > a) count++;

      Console.WriteLine(count);

    }
}

}