using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblemSolution.LeetCodeProblem
{
    class Problem1704
    {
        public bool HalvesAreAlike(string s)
        {
            var counter1 = 0;
            var counter2 = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var lowerCaseCharacter = char.ToLower(s[i]);

                if (lowerCaseCharacter == 'a'
                    || lowerCaseCharacter == 'e'
                    || lowerCaseCharacter == 'i'
                    || lowerCaseCharacter == 'o'
                    || lowerCaseCharacter == 'u')
                {
                    if (i < s.Length / 2)
                        counter1++;
                    else
                        counter2++;
                }
            }

            return counter1 == counter2;
        }
    }
}
