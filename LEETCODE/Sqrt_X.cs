using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a non-negative number: ");
        int x = int.Parse(Console.ReadLine());

        int result = MySqrt(x);

        Console.WriteLine("Square root (rounded down): " + result);
    }

    static int MySqrt(int x)
    {
        if (x < 2)
            return x;

        int left = 1, right = x / 2;
        int ans = 0;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            long square = (long)mid * mid;

            if (square == x)
                return mid;
            else if (square < x)
            {
                ans = mid;
                left = mid + 1;
            }
            else
                right = mid - 1;
        }

        return ans;
    }
}
