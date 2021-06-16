using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  1108  | 88 ms    |  20.7 MB  | 28.48           | 100
    /// </summary>
    class DefangingAnIPAddressSolution
    {
        //-_-
        public static string DefangIPaddr(string address) => address.Replace(".", "[.]");
    }
}
