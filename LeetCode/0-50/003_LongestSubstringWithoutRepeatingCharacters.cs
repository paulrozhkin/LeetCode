using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._0_50
{
    public class _003_LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1)
            {
                return s.Length;
            }

            var n = s.Count();
            var result = 0;

            var map = new Dictionary<char, int>(); // current index of character

            // try to extend the range [i, j]
            for (int j = 0, i = 0; j < n; j++)
            {
                if (map.TryGetValue(s[j], out var charIndex))
                {
                    i = Math.Max(charIndex, i);
                }

                result = Math.Max(result, j - i + 1);
                map[s[j]] = j + 1;
            }

            return result;
        }
    }
}