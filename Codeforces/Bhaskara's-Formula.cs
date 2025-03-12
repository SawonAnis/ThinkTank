using System;

class Program
{
  public static void Main(string[] args)
  {
    string[] input = Console.ReadLine().Split();
    double A = double.Parse(input[0]);
    double B = double.Parse(input[1]);
    double C = double.Parse(input[2]);

    double delta = (B * B) - (4 * A * C);

 if (A == 0 || delta < 0)
    {
      Console.WriteLine("Impossivel calcular");
    }
        else
    {

      double R1 = (-B + Math.Sqrt(delta)) / (2 * A);
      double R2 = (-B - Math.Sqrt(delta)) / (2 * A);

   
      Console.WriteLine($"R1 = {R1:F5}");
      Console.WriteLine($"R2 = {R2:F5}");
    }
  } }