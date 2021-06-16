using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  938   | 184 ms   |  42.5 MB  | 51.42           | 100
    /// </summary>
    class RangeSumOfBSTSolution
    {
        //Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        private static int _sum;
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            _sum = 0;
            _sum = root.val;
            if (_sum < L || _sum > R)
                _sum = 0;
            SumF(root.left, L, R);
            SumF(root.right, L, R);
            return _sum;
        }
        private void SumF(TreeNode node, int L, int R)
        {
            if (node == null) return;
            int tmp = node.val;
            if (tmp >= L && tmp <= R)
                _sum += tmp;
            SumF(node.left, L, R);
            SumF(node.right, L, R);
        }

    }
}
