using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine()); 

        while (true)
        {
            year++; 
            if (year.ToString().Distinct().Count() == 4) 
            {
                Console.WriteLine(year);
        break;
            }
        }
    }
}
