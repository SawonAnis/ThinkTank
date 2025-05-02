using System;

class Solution  
{
    static bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;

        int reversed = 0, original = x;
        
        while (x > 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        return original == reversed;
    }

    static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine(IsPalindrome(x));
    }
}
