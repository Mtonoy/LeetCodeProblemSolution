using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblemSolution.LeetCodeProblem
{
    class Problem15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> res = new List<IList<int>>();


            for (int i = 0; i < nums.Length; i++)
            {
                int a = nums[i];
                if (i > 0 && a == nums[i - 1])
                {
                    continue;
                }

                int l = i + 1, r = nums.Length - 1;

                while (l < r)
                {
                    int sum = a + nums[l] + nums[r];

                    if (sum > 0)
                    {
                        r--;
                    }
                    else if (sum < 0)
                    {
                        l++;
                    }
                    else
                    {
                        res.Add(new List<int> { a, nums[l], nums[r] });
                        l++;
                        while (nums[l] == nums[l - 1] && l < r)
                        {
                            l++;
                        }

                    }

                }

            }
            return res;
        }
    }
}
