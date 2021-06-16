using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  1323  | 32 ms    |  14.9 MB  | 98.89           | 100
    /// </summary>
    class Maximum69NumberSolution
    {
        public static int Maximum69Number(int num)
        {
            string snum = num.ToString();
            for (int i = 0; i < snum.Length; i++)
            {
                if (snum[i] == '6')
                    return num + 3 * (int)Math.Pow(10, snum.Length - i - 1);

            }
            return num;
        }
    }
}
