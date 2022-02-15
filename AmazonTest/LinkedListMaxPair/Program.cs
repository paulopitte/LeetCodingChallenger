using static AmazonTest.Solution;
using static System.Console;
namespace AmazonTest
{

    /* Amazon online assessment Linked List max pair
     * Give a linked list, which has even number of nodes, please return the maximum sum of PAIR
        A pair means the node[i] and node[n-i], which n is linked list length.
        example: [1,2,3,4,9,11]
        1st pair sum: 1 + 11 = 12
        2nd pair sum: 2 + 9 = 11
        3rd pair sum: 3 + 4 = 7
        Therefore, return 12

        Please note that, you can only solve it with space complexity O(1)
    */



    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("Count strength of password | amazon" + "[  1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,13] Esperado => 14 ");
            WriteLine("---------------------------------------");

            var nodes = ToListNode(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,13 });
            WriteLine("Result : " + Solution.MaxLinkedListSum(nodes));

            ReadKey();
        }

    }



    class Solution
    {

        public static ListNode ToListNode(int[] input)
        {
            // Now convert that list into linked list
            ListNode dummyRoot = new ListNode(0);
            ListNode ptr = dummyRoot;
            foreach (int item in input)
            {
                ptr.next = new ListNode(item);
                ptr = ptr.next;
            }
            return dummyRoot.next;

        }




        /// <summary>
        /// 1 Encontre o meio usando ponteiro lento e rápido.
        /// 2 Inverta a segunda metade da lista a partir do próximo do meio. A lista vai ficar assim finalmente (1,2,3,11,9,4)
        /// 3 Agora calcule a soma do par com o primeiro ponteiro apontando para o primeiro nó e o segundo ponteiro apontando para o próximo do meio.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int MaxLinkedListSum(ListNode list)
        {
            // verfica a integridadde da list
            if (list == null) return 0;
            if (list.next == null) return list.val;


            // inicializo os ponteiros 
            ListNode slow = list;
            ListNode fast = list;

            // verifico se ainda existe ponteiros a serem listados
            while (fast != null && fast.next != null)
            {
                // a idéia é partir na metade a lista
                slow = slow.next;
                fast = fast.next.next;
            }

            //obtem o ponteiro esquerdo.
            ListNode first = list;

            // Aqui é realizado o inversao para otimização do loop, sendo assim mantemos a complexidade como O(1)
            ListNode prev = null;
            while (slow != null)
            {
                ListNode nextNode = slow.next;
                slow.next = prev;
                prev = slow;
                slow = nextNode;
            }
            int maxSum = 0;
            while (first != null && prev != null)
            {
                // realiza a soma do ponteiros paralelos
                maxSum = Math.Max(maxSum, first.val + prev.val);
                first = first.next;
                prev = prev.next;
            }
            return maxSum;
        }
        public static int MaxPairList(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            ListNode current = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            slow = reverse(slow);
            int max = int.MinValue;
            while (slow != null)
            {
                int sum = slow.val + current.val;
                if (max < sum)
                {
                    max = sum;
                }
                slow = slow.next;
                current = current.next;
            }
            return max;
        }


        public static int MaximumPages(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            ListNode current = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            slow = reverse(slow);
            int max = int.MinValue;
            while (slow != null)
            {
                int sum = slow.val + current.val;
                if (max < sum)
                {
                    max = sum;
                }
                slow = slow.next;
                current = current.next;
            }
            return max;
        }

        public static ListNode reverse(ListNode head)
        {

            ListNode prev = null;
            ListNode next = head;
            ListNode current = head;

            while (current != null)
            {
                next = next.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }


        /// <summary>
        /// Definition for singly-linked list.
        /// </summary>
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) => this.val = x;

        }

    }





}