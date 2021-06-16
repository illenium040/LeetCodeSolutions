using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  771   | 72 ms    |  23.2 MB  | 81.78           | 100
    /// </summary>
    class JewelsAndStonesSolution
    {
        public static int NumJewelsInStones(string J, string S)
        {
            int res = 0;
            foreach (var j in J)
                foreach (var s in S)
                    if (j == s) res++;
            return res;
        }
    }
}
