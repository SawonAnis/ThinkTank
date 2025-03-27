using System;

class Skibidus
{
  public static void Main(string[] args)
  {
    int t = int.Parse(Console.ReadLine());

    while (t-- > 0)
    {
      string W = Console.ReadLine();
      string P = W.Substring(0, W.Length - 2) + "i";
      Console.WriteLine(P);
    }
  }
}