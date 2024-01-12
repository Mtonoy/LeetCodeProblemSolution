using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblemSolution.LeetCodeProblem
{
    class Problem8
    {
        public int MyAtoi(string s)
        {
            List<char> str = new List<char>();
            s = s.TrimStart(' ');
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    str.Add(s[i]);
                    continue;
                }
                if (i == 0 && s[0] == '-')
                    continue;
                if (i == 0 && s[0] == '+')
                    continue;
                break;
            }
            if (str.Count == 0)
                return 0;
            bool cor = int.TryParse(String.Join("", str), out int result);
            if (cor && s[0] == '-')
                return -result;
            if (cor)
                return result;
            if (!cor && s[0] == '-')
                return int.MinValue;
            else
                return int.MaxValue;
        }
    }
}
