using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._35_70
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  278   | 40 ms    |  14.6 MB  | 64.66           | 100
    /// </summary>
    class FirstBadVersionSolution
    {
        /* The isBadVersion API is defined in the parent class VersionControl.*/
        private static bool IsBadVersion(int version) { return true; }
        public static int FirstBadVersion(int n)
        {
            int l = 1, r = n;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (IsBadVersion(m)) r = m;
                else l = m + 1;
            }
            return l;
        }
    }
}
