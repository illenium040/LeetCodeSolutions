using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  804   | 100 ms   |  22.5 MB  | 21.74           | 100
    /// </summary>
    class UniqueMorseCodeWordsSolution
    {
        static private Dictionary<int, string> _morseCode = new Dictionary<int, string>(26) {
            { 97, ".-" },
            { 98, "-..." },
            { 99, "-.-." },
            { 100, "-.." },
            { 101,  "." },
            { 102, "..-." },
            { 103, "--." },
            { 104, "...." },
            { 105, ".." },
            { 106, ".---" },
            { 107, "-.-" },
            { 108, ".-.." },
            { 109, "--" },
            { 110, "-." },
            { 111, "---" },
            { 112, ".--." },
            { 113, "--.-" },
            { 114, ".-." },
            { 115, "..." },
            { 116, "-" },
            { 117, "..-" },
            { 118, "...-" },
            { 119, ".--" },
            { 120, "-..-" },
            { 121, "-.--" },
            { 122, "--.."} };
        public static int UniqueMorseRepresentations(string[] words)
        {
            Hashtable table = new Hashtable();
            StringBuilder tmp = new StringBuilder();
            foreach (var word in words)
            {
                tmp.Clear();
                foreach (var c in word)
                    tmp.Append(_morseCode[c]);
                table[tmp.ToString()] = 0;
            }

            return table.Count;
        }
    }
}
