using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblemSolution.LeetCodeProblem
{
    class Problem1347
    {
        public int MinSteps(string s, string t)
        {
            int count = 0;
            var alphabets = new int[26]; // A-Z alphabets Array

            for (int i = 0; i < s.Length; i++)
            {
                //Update frequency of characters in both string
                alphabets[s[i] - 'a']++;
                alphabets[t[i] - 'a']--;
            }

            for (int j = 0; j < alphabets.Length; j++)
            {
                if (alphabets[j] > 0)
                {
                    count += alphabets[j];
                }
            }
            return count;
        }
    }
}
