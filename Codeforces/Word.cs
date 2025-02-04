using System;


namespace Word
{
    class Program
    {
        public static void Main(string[] args){

                string s = Console.ReadLine();

      
        int uppercaseCount = s.Count(char.IsUpper);
        int lowercaseCount = s.Length - uppercaseCount; 

     string result;
if (uppercaseCount > lowercaseCount)
{
    result = s.ToUpper();
}
else
{
    result = s.ToLower();
}

     
        Console.WriteLine(result);

        }


    }
}




