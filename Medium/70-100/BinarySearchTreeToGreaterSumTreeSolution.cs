using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Medium._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  1038  | 96 ms    |  22 MB    | 38.35           | 100
    /// </summary>
    class BinarySearchTreeToGreaterSumTreeSolution
    {
        //Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        private static int _rsum = 0;
        public TreeNode BstToGst(TreeNode root)
        {
            SetValue(root, 0);
            _rsum = 0;
            return root;
        }
        private void SetValue(TreeNode node, int p)
        {
            if (node == null) return;
            Sum(node.right);
            node.val += _rsum + p;
            _rsum = 0;
            SetValue(node.right, p);
            if (node.left != null)
                SetValue(node.left, node.val);


        }
        private void Sum(TreeNode node)
        {
            if (node == null) return;
            _rsum += node.val;
            Sum(node.right);
            Sum(node.left);
        }
    }
}
