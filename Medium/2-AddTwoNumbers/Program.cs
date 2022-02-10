using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace _2_AddTwoNumbers
{
    internal class Program
    {

        /*
         *https://leetcode.com/problems/add-two-numbers/
         *You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

            You may assume the two numbers do not contain any leading zero, except the number 0 itself.
            Example 1:


            Input: l1 = [2,4,3], l2 = [5,6,4]
            Output: [7,0,8]
            Explanation: 342 + 465 = 807.
            Example 2:

            Input: l1 = [0], l2 = [0]
            Output: [0]
            Example 3:

            Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
            Output: [8,9,9,9,0,0,0,1]
 

            Constraints:

            The number of nodes in each linked list is in the range [1, 100].
            0 <= Node.val <= 9
            It is guaranteed that the list represents a number that does not have leading zeros.
         * */


        static void Main(string[] args)
        {
            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("2 - Add Two Numbers");
            WriteLine("---------------------------------------");

            var ln1 = new ListNode { val = 2, next = new ListNode { val = 4, next = new ListNode { val = 3 } } };
            var ln2 = new ListNode { val = 5, next = new ListNode { val = 6, next = new ListNode { val = 4 } } };
            var result = Solution.AddTwoNumbers_BestSolution(ln1, ln2);

            WriteLine("result : " + result);
            Console.ReadKey();


        }
    }


    internal static class Solution
    {


        public static ListNode AddTwoNumbers_Solution_Linq(ListNode l1, ListNode l2)
        {
            var accumulator = new List<int>();
            var bonus = 0;
            while ((l1 != null || l2 != null) || bonus != 0)
            {
                var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + bonus;
                l1 = l1?.next;
                l2 = l2?.next;
                accumulator.Add(sum % 10);
                bonus = sum / 10;
            }

            accumulator.Reverse();
            return accumulator.Aggregate<int, ListNode>(null, (current, next) => new ListNode(next, current));
        }



        public static ListNode AddTwoNumbers_Solution_Single(ListNode l1, ListNode l2)
        {
            int left = 0;
            var node1 = l1;
            var node2 = l2;
            var final = new ListNode(0);
            var newlist = final;

            while (node1 != null || node2 != null || left == 1)
            {

                int num1 = 0;
                int num2 = 0;
                int currentvalue = 0;

                //Calculation
                if (node1 != null)
                {
                    num1 = node1.val;
                    node1 = node1.next;
                }
                if (node2 != null)
                {
                    num2 = node2.val;
                    node2 = node2.next;
                }
                int sum = num1 + num2 + left;
                left = sum / 10;
                newlist.next = new ListNode(sum % 10);
                newlist = newlist.next;
                //
            }

            return final.next;
        }




        /*
         * A idéia é obter cada nó de entrada ao mesmo tempo, adicioná-los e criar um nó para ele,
         * quando a soma é >10 então sabemos que carregamos um para a próxima soma, e o nó atual deve ser Sum - 10 = dando 0, ou 1, etc
         * como 13-10 = 3 você carrega um e deixa o 3 como atual, o mesmo para 10-10, ainda carrega um e o nó atual é 0
         * */
        public static ListNode AddTwoNumbers_BestSolution(ListNode l1, ListNode l2)
        {
            ListNode previousResultingNode = null;
            ListNode resultingSumStartingNode = null;
            int carry = 0;

            while (l1 != null | l2 != null | carry == 1)
            {
                if (l1 == null) l1 = new() { val = 0 };
                if (l2 == null) l2 = new() { val = 0 };

                int sum = (l1.val + l2.val) + carry;

                if (sum > 9)
                {
                    // sum -= 10;
                    sum %= 10;
                    carry = 1;
                }
                else
                    carry = 0;


                ListNode resultingNode = new() { val = sum };

                if (previousResultingNode != null)
                    previousResultingNode.next = resultingNode;
                else
                    resultingSumStartingNode = resultingNode;

                previousResultingNode = resultingNode;
                l1 = l1.next;
                l2 = l2.next;
            }
            return resultingSumStartingNode;
        }



    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
