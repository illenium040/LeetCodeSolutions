using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Medium._0_35
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  3     | 80 ms    |  22.9 MB  | 90.17           | 100
    /// </summary>
    class LongestSubstringWithoutRepeatingCharactersSolution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int l = -1, max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int j = i - 1;

                while (l < j && s[j] != s[i]) j--;
                l = j;
                max = Math.Max(max, i - l);
            }
            return max;
        }
    }
}
