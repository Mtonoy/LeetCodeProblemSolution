using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblemSolution.LeetCodeProblem
{
    class Problem16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int n = nums.Length;
            int res = 0, temp = int.MaxValue;
            Array.Sort(nums);
            for (int i = 0; i < n; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int low = i + 1, high = n - 1;
                while (low < high)
                {
                    int sum = nums[i] + nums[low] + nums[high];
                    int diff = Math.Abs(target - sum);
                    if (sum == target)
                    {
                        diff = 0;
                        res = sum;
                        low++;
                        high--;
                    }
                    else if (sum < target)
                    {
                        if (temp > diff)
                        {
                            res = sum;
                            temp = diff;
                        }
                        low++;
                    }
                    else
                    {
                        if (temp > diff)
                        {
                            res = sum;
                            temp = diff;
                        }
                        high--;
                    }

                }
            }
            return res;
        }
    }
}
