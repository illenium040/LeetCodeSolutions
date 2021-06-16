using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  1295  | 84 ms    |  25.8 MB  | 98.49           | 85.63
    /// </summary>
    class FindNumbersWithEvenNumberOfDigitsSolution
    {
        public static int FindNumbers(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].ToString().Length % 2 == 0)
                    res++;
            }
            return res;

        }
    }
}
