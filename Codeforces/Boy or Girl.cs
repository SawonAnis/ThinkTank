using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Sources;


namespace BoyorGirl
{
    class Program
    {
        public static void Main(string[] args)
        {

            string username=Console.ReadLine(); 
            HashSet<char> set = new HashSet<char>();

            for (int i = 0;i<username.Length;++i)
                set.Add(username[i]);   
                
if(set.Count%2==0)
                Console.WriteLine("CHAT WITH HER!");
          
            else
            

                Console.WriteLine("IGNORE HIM!");
            
        }
    }



}




