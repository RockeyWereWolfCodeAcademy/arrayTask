using System;
using System.Reflection;

namespace arrayTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a size of your initial array: ");
            int numsSize = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[numsSize];
            for (int n = 0; n < nums.Length; n++)
            {
                Console.WriteLine("\nEnter "+(n + 1) +"th element of array: ");
                nums[n]  = Convert.ToInt32(Console.ReadLine());
            }
            int[] reversedNums = new int[nums.Length];
            int i = 0;
            int j = 0 + reversedNums.Length - 1;
            while (j >= 0)
            {
                reversedNums[i] = nums[j];
                i++;
                j--;
            }
            Console.WriteLine("Your initial array: ");
            for (int n = 0; n < nums.Length; n++)
            {
                Console.WriteLine((n + 1) + "th element: " + nums[n]);
            }
            Console.WriteLine("\nReversed initial array: ");
            for (int n = 0; n < reversedNums.Length; n++)
            {
                Console.WriteLine((n + 1) + "th element: " + reversedNums[n]);
            }
        }
    }
}