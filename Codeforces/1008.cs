//SALARY WITH BONUS

using System;



class Program
{
    static void Main()
    {
    string s = Console.ReadLine();


  double C = double.Parse(Console.ReadLine());

    double D = double.Parse(Console.ReadLine());

    double total = (D * 0.15) + C;



        Console.WriteLine($"TOTAL = R$ {total:F2}");

        }
    }

