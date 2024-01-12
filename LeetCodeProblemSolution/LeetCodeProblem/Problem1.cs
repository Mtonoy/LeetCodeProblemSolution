﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblemSolution.LeetCodeProblem
{
    class Problem1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[] { -1, -1 };
            if (nums == null)
                return result;
            if (nums.Length < 2)
                return result;

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (map.ContainsKey(diff))
                {
                    result[0] = map[diff];
                    result[1] = i;
                    return result;
                }

                if (map.ContainsKey(nums[i]))
                    continue;
                map.Add(nums[i], i);
            }

            return result;


        }
    }
}
