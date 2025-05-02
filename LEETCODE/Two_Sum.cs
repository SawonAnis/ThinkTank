using System;


class TwoSum
{

  static int[] Twosum(int[] nums, int target)
  {
    int n = nums.Length;

    for (int i = 0; i < n; i++)
    {
      for (int j = i + 1; j < n; j++)
      {
        if (nums[i] + nums[j] == target)
        {
          return new int[] { i, j };
        }
      }
    }
    return new int[0];
}
 public static void Main(string[] args)
 {
   int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = Twosum(nums, target);
        Console.WriteLine("[" + result[0] + ", " + result[1] + "]");
 }
 

}