using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblemSolution.LeetCodeProblem
{
    class Problem9
    {
        public bool IsPalindrome(int x)
        {
            return string.Concat(x.ToString().Reverse()) == x.ToString();
        }
    }
}
