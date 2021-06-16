using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Hard._0_35
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  65    | 84 ms    |  23.7 MB  | 51              | 100
    /// </summary>
    class ValidNumberSolution
    {
        public static bool IsNumber(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            int i = 0;
            int j = s.Length - 1;
            while (i < s.Length - 1 && s[i] == ' ')
                i++;
            if (s.Length <= i) return false;
            while (j > i && s[j] == ' ')
                j--;

            if (i == j) return s[i] >= '0' && s[i] <= '9';

            char tmp = s[i];
            if ((tmp >= '0' && tmp <= '9') || tmp == '-' || tmp == '+')
                return MainCheck(s, ++i, j);
            else if (tmp == '.')
            {
                if (i + 1 < j)
                {
                    _isdot = true;
                    return MainCheck(s, ++i, j);
                }
                else if (i + 1 == j) return s[i + 1] >= '0' && s[i + 1] <= '9';
                else return false;
            }
            else return false;
        }

        private static bool _isdot = false;
        private static bool _isexp = false;

        private static bool MainCheck(string s, int i, int j)
        {
            for (; i <= j; i++)
            {
                char c = s[i];
                if (c >= '0' && c <= '9') continue;
                switch (c)
                {
                    case ' ': return false;
                    case '+': return false;
                    case '-': return false;
                    case '.':
                        {
                            if (_isdot) return false;
                            if (((s[i - 1] < '0' || s[i - 1] > '9') && s[i - 1] != '+' && s[i - 1] != '-'))
                                return false;
                            else if ((s[i - 1] < '0' || s[i - 1] > '9') && i == j) return false;

                            _isdot = true;
                            break;
                        }
                    case 'e':
                        {
                            if (_isexp || ((s[i - 1] < '0' || s[i - 1] > '9')))
                            {
                                if (s[i - 1] == '.')
                                {
                                    if (i - 2 < 0) return false;
                                    if (s[i - 2] < '0' || s[i - 2] > '9') return false;
                                }
                                else return false;
                            }
                            _isexp = true;
                            _isdot = true;
                            if (i + 1 < j)
                            {
                                if (s[i + 1] == '-' || s[i + 1] == '+') i++;
                            }
                            else if (i + 1 == j) return s[i + 1] >= '0' && s[i + 1] <= '9';
                            else return false;

                            break;
                        }
                    default:
                        return false;
                }
            }
            return true;
        }
    }
}
