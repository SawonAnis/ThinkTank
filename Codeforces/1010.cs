using System;

class Program
{
  public static void Main(string[] args)
  {
    string[] input = Console.ReadLine().Split();
    int X = int.Parse(input[0]);
    int Y = int.Parse(input[1]);
    double Z = double.Parse(input[2]);

    string[] input2 = Console.ReadLine().Split();
    int A = int.Parse(input2[0]);
    int B = int.Parse(input2[1]);
    double C = double.Parse(input2[2]);

    double sum = (Y * Z) + (B * C);

    Console.WriteLine($"VALOR A PAGAR: R$ {sum.ToString("F2")}");
    

  }
}