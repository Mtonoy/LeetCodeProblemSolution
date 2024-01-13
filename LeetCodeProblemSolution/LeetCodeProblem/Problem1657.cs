using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblemSolution.LeetCodeProblem
{
    class Problem1657
    {
        public bool CloseStrings(string word1, string word2)
        {

            if (word1.Length != word2.Length)
            {
                return false;
            }

            int[] alphabets = new int[26]; // a-z alphabets Array
            int[] alphabets1 = new int[26];

            foreach (char c in word1)
            {
                alphabets[c - 'a']++;
            }

            foreach (char c in word2)
            {
                alphabets1[c - 'a']++;
            }

            for (int i = 0; i < 26; i++)
            {
                if ((alphabets[i] == 0 && alphabets1[i] > 0) || (alphabets[i] > 0 && alphabets1[i] == 0))
                {
                    return false;
                }
            }

            Array.Sort(alphabets);
            Array.Sort(alphabets1);

            for (int i = 0; i < 26; i++)
            {
                if (alphabets[i] != alphabets1[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
