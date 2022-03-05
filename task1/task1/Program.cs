using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 23,22, 3, 50, 4, 30, 45 };
            int min = nums.Length;
            for (int i = 1; i < nums.Length-1; i++)
            {
                if (min>nums[i])
                {
                    min = nums[i];
                    Console.WriteLine(min);
                }
            }
            Console.WriteLine("minimum ededdir");
            
        }
    }
}
