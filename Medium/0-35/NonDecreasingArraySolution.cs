using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Medium._0_35
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  665   | 132 ms   |  29.8 MB  | 7.77            | 100
    /// </summary>
    class NonDecreasingArraySolution
    {
        public static bool CheckPossibility(int[] nums)
        {
            int count = 0;
            int len = nums.Length;
            if (len < 3) return true;

            for (int i = len - 1; i >= 1; i--)
            {
                int sub = nums[i] - nums[i - 1];
                if (sub < 0)
                {
                    nums[i - 1] += sub;
                    if (i - 2 >= 0 && nums[i - 2] >= nums[i - 1])
                    {
                        nums[i - 1] -= sub;
                        nums[i] -= sub;
                        count++;
                        if (i + 1 <= len - 1 && nums[i + 1] < nums[i])
                            return false;
                    }
                    else count++;
                    if (count > 1) return false;
                }
            }
            if (count > 1) return false;
            return true;
        }
    }
}
