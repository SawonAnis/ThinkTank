using System;

class Program
{
  public static void Main(string[] args)
  {
    int t = int.Parse(Console.ReadLine());


    while (t-- > 0)
    {
      int n = int.Parse(Console.ReadLine());
      string s = Console.ReadLine();
 HashSet<char> solvedProblems = new HashSet<char>(); 
            int balloons = 0;

            foreach (char c in s)
            {
                if (solvedProblems.Add(c))
                {
                    balloons += 2; 
                }
                else
                {
                    balloons += 1; 
                }
            }
            
            Console.WriteLine(balloons);

    }
  }
}