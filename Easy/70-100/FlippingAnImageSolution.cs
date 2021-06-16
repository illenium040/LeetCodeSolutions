using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  832   | 252 ms   |  32.7 MB  | 34.1            | 31.34
    /// </summary>
    class FlippingAnImageSolution
    {
        public static int[][] FlipAndInvertImage(int[][] A)
        {
            int len1 = A.Count();
            for (int i = 0; i < len1; i++)
            {
                var arr = A[i];
                int start = 0;
                int end = arr.Length - 1;
                while (end >= start)
                {
                    int tmp = 1 - arr[start];
                    arr[start] = 1 - arr[end];
                    arr[end] = tmp;
                    start++;
                    end--;
                }
            }
            return A;
        }
    }
}
