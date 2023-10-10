using System;
using System.Reflection;

namespace arrayTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a size of your initial array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];
            for (int n = 0; n < nums.Length; n++)
            {
                Console.WriteLine("\nEnter element №" + (n + 1) + " of array: ");
                nums[n] = Convert.ToInt32(Console.ReadLine());
            }
            int[] reversedNums = new int[nums.Length];
            int lastIndex = 0 + nums.Length - 1;
            for (int i = 0; i < nums.Length; i++)
            {
                reversedNums[lastIndex - i] = nums[i];
            }
            Console.WriteLine("\nYour initial array: ");
            for (int n = 0; n < nums.Length; n++)
            {
                Console.WriteLine("Element №" + (n + 1) + ": " + nums[n]);
            }
            Console.WriteLine("\nReversed initial array: ");
            for (int n = 0; n < reversedNums.Length; n++)
            {
                Console.WriteLine("Element №" + (n + 1) + ": " + reversedNums[n]);
            }
        }
    }
}
