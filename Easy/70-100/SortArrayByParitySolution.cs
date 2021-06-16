using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  905   | 268 ms   |  32 MB    | 18.65           | 100
    /// </summary>
    class SortArrayByParitySolution
    {
        public static int[] SortArrayByParity(int[] A)
        {
            int[] even = new int[A.Length];
            for (int i = 0, j = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0) even[i - j] = A[i];
                else
                {
                    even[A.Length - 1 - j] = A[i];
                    j++;
                }

            }
            return even;
        }
    }
}
