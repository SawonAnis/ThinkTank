using System;

class Program
{
    static void Main()
    {
      Console.WriteLine("");

  string situation = Console.ReadLine();

        if (situation.Contains("0000000") || situation.Contains("1111111"))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

