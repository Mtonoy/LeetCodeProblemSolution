using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblemSolution.LeetCodeProblem
{
    class Problem11
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0, right = height.Length - 1;

            while (left < right)
            {
                int h = Math.Min(height[left], height[right]);
                int width = right - left;
                maxArea = Math.Max(maxArea, h * width);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
    }
}
