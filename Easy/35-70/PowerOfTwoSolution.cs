using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._35_70
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  231   | 40 ms    |  13.1 MB  | 81.95           | 100
    /// </summary>
    class PowerOfTwoSolution
    {
        public static bool IsPowerOfTwo(int n)
        {
            var s = Math.Round(Math.Log(n, 2), 14);
            int comp = s.CompareTo((int)s);
            if (comp == 0)
                return true;
            return false;
        }
    }
}
