using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace _199_BinaryTreeRightSideView
{

    // 199. Binary Tree Right Side View
    /*https://leetcode.com/problems/binary-tree-right-side-view/
     * Given the root of a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.
    

        Example 1:
        Input: root = [1,2,3,null,5,null,4]
        Output: [1,3,4]


        Example 2:
        Input: root = [1,null,3]
        Output: [1,3]
        Example 3:

        Input: root = []
        Output: []
 

        Constraints:

        The number of nodes in the tree is in the range [0, 100].
        -100 <= Node.val <= 100
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("199. Binary Tree Right Side View");
            WriteLine("---------------------------------------");


            //Example 1:
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
            };

            // Example 2:
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
