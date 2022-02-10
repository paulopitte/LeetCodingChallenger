using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace _199_BinaryTreeRightSideView
{

    // 199. Binary Tree Right Side View

    internal class Program
    {
        static void Main(string[] args)
        {

            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("199. Binary Tree Right Side View");
            WriteLine("---------------------------------------");


            TreeNode tree = new(1);
            tree.right = new TreeNode(2)
            {
                val = 3,
                right = new TreeNode(4)
                {
                    right = new TreeNode(55)
                }
            };

            tree.left = new TreeNode(2)
            {
                right = new TreeNode(5)
                {
                    left = new TreeNode(21)
                    {
                        left = new TreeNode(75)
                    }
                }
            };


            // tree.left = new();
            // tree.right = new(3);




            var result = Solution.RightSideView(tree);
            result.ToList().ForEach((c) => Write(c.ToString() + " "));
            Console.ReadKey();
        }

    }



    public static class Solution
    {
        public static IList<int> RightSideView(TreeNode root)
        {
            List<int> res = new();
            if (root == null) return res;

            Queue<TreeNode> q = new();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                int l = q.Count;
                for (int i = 0; i < l; i++)
                {
                    TreeNode n = q.Dequeue();
                    //              add the last element od level to result
                    if (i == l - 1) res.Add(n.val);
                    //              adding nodes to q
                    if (n.left != null) q.Enqueue(n.left);
                    if (n.right != null) q.Enqueue(n.right);
                }
            }
            return res;
        }
    }

    /// <summary>
    ///   * Definition for a binary tree node.
    /// </summary>
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
}
