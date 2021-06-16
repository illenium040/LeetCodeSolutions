using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  1281  | 40 ms    |  14.6 MB  | 66.87           | 100
    /// </summary>
    class SubtractTheProductAndSumOfDigitsOfIntegerSolution
    {
        public static int SubtractProductAndSum(int n)
        {
            int devider = 10;
            int prod = n % devider;
            int sum = n % devider;
            int sub = 0;
            devider *= 10;
            while (devider / 10 <= n)
            {
                sub = n % devider;
                sub /= devider / 10;
                devider *= 10;
                prod *= sub;
                sum += sub;
            }
            return prod - sum;
        }
    }
}
