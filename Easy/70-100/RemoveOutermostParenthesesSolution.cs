using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  1021  | 88 ms    |  21.6 MB  | 57.87           | 100
    /// </summary>
    class RemoveOutermostParenthesesSolution
    {
        public static string RemoveOuterParentheses(string S)
        {
            int opened = 0;
            int closed = 0;
            int dex = 0;
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                    opened += 1; //3 + 2
                else closed += 1; //3 + 2
                if (opened == closed)
                {
                    res.Append(S.Substring(dex + 1, opened + closed - 2));
                    dex = i + 1;
                    opened = closed = 0;
                }
            }
            return res.ToString();
        }
    }
}
