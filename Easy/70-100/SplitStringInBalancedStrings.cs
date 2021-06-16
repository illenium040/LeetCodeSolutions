using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  1221  | 72 ms    |  22 MB    | 78.49           | 100
    /// </summary>
    class SplitStringInBalancedStrings
    {
        public static int BalancedStringSplit(string s)
        {
            int r = 0;
            int l = 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R') r++;
                if (s[i] == 'L') l++;
                if (r == l)
                {
                    count++;
                    r = l = 0;
                }
            }
            return count;
        }
    }
}
