using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace BinaryTreeLeftSideView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("xxx. Binary Tree Left Side View");
            WriteLine("---------------------------------------");

            TreeNode tree = new(1);

            tree.right = new TreeNode(2);
            tree.right.right = new TreeNode(4);
            tree.right.right.right = new TreeNode(6);
            tree.right.right.right.right = new TreeNode(10);


            tree.left = new TreeNode(3);
            tree.left.left = new TreeNode(6);
            tree.left.left.left = new TreeNode(12);
            tree.left.left.left.left = new TreeNode(24);

            var result = Solution.LeftSideView(tree);
            result.ToList().ForEach((c) => Write(c.ToString() + " "));
            Console.ReadKey();
        }
    }



    public static class Solution
    {
        public static IList<int> LeftSideView(TreeNode root)
        {
            List<int> res = new();
            if (root == null) return res;

            Queue<TreeNode> q = new();
            q.Enqueue(root);


            while (q.Count > 0)
            {

                var levelSize = q.Count;

                for (var i = 0; i < levelSize; i++)
                {
                    var node = q.Dequeue();

                    if (i == 0) res.Add(node.val);                  

                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }


            }
            return res;


            //while (q.Count > 0)
            //{
            //    int l = q.Count;
            //    for (int i = 0; i < l; i++)
            //    {
            //        TreeNode n = q.Dequeue();
            //        //              add the last element od level to result
            //        if (i == l - 1) res.Add(n.val);
            //        //              adding nodes to q
            //        if (n.left != null) q.Enqueue(n.left);
            //        if (n.right != null) q.Enqueue(n.right);
            //    }
            //}
            //return res;
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
