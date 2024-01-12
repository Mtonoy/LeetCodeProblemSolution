using LeetCodeProblemSolution.LeetCodeProblem;
using System;

namespace LeetCodeProblemSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1

            int[] nums = { 2, 7, 11, 15};
            int target = 9;

            Problem1 problem1 = new Problem1();
            int[] output =  problem1.TwoSum(nums, target);

            Console.WriteLine(String.Join(", ", output));
            Console.ReadLine();
            #endregion

        }
    }
}
