using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblemSolution.LeetCodeProblem
{
    class Problem14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int i = 0;
            StringBuilder str = new StringBuilder ();
            string shortest = strs.OrderBy(s => s.Length).First();

            foreach (char c in shortest)
            {
                if (strs.Any(s => s[i] != c)) break;
                str.Append(c);
                i++;
            }

            return str.ToString();
        }
    }
}
