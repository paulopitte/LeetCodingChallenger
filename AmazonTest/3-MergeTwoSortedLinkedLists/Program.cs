using static System.Console;

namespace AmazonTest
{
    /*
     * Problem Statement
        Given two sorted linked lists, merge them so that the resulting linked list is also sorted.
        Consider two sorted linked lists as an example.
         
            Runtime Complexity: Linear, O(m + n)O(m+n) where m and n are lengths of both linked lists

            Memory Complexity: Constant, O(1)O(1)

            Maintain a head and a tail pointer on the merged linked list. Then choose the head of the merged linked list by comparing the first node of both linked lists. For all subsequent nodes in both lists, you choose the smaller current node and link it to the tail of the merged list, and moving the current pointer of that list one step forward.

            Continue this while there are some remaining elements in both the lists. If there are still some elements in only one of the lists, you link this remaining list to the tail of the merged list. Initially, the merged linked list is NULL.

            Compare the value of the first two nodes and make the node with the smaller value the head node of the merged linked list. In this example, it is 4 from head1. Since it’s the first and only node in the merged list, it will also be the tail. Then move head1 one step forward.
     */
    public static class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Solution.ToLinkedListNode(new int[] { 1, 3, 5, 6 });
            var arr2 = Solution.ToLinkedListNode(new int[] { 2, 4, 20, 34 });

            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("Merge Two Sorted Linked Lists ");
            WriteLine("Original 1 " + "[ 1, 3, 5, 6 ]  ");
            WriteLine("Original 2 " + "[ 2, 4, 6, 20, 34 ]  ");

            WriteLine("---------------------------------------");
            WriteLine("Mergiado : [1,2,3,4,5,6,20,34] " + Solution.Merge_Sorted(arr1, arr2));

            ReadKey();
        }
    }


    class Solution
    {

        public static LinkedListNode Merge_Sorted(LinkedListNode head1, LinkedListNode head2)
        {
            // Verifico a integridade da lista
            if (head1 == null) return head2;
            else if (head2 == null) return head1;

            // starto meu processo de verificação iniciando o valor mais baixo
            LinkedListNode mergedHead = null;
            if (head1.data <= head2.data)
            {
                mergedHead = head1;
                head1 = head1.next;
            }
            else
            {
                mergedHead = head2;
                head2.next = head1.next;
            }

            LinkedListNode mergedTail = mergedHead;

            while (head1 != null && head2 != null)
            {
                LinkedListNode temp = null;
                if (head1.data <= head2.data)
                {
                    temp = head1;
                    head1 = head1.next;
                }
                else
                {
                    temp = head2;
                    head2 = head2.next;
                }

                mergedTail.next = temp;
                mergedTail = temp;
            }

            if (head1 != null)
            {
                mergedTail.next = head1;
            }
            else if (head2 != null)
            {
                mergedTail.next = head2;
            }


            return mergedHead;
        }

        public static LinkedListNode ToLinkedListNode(int[] input)
        {
            LinkedListNode root = new(0);
            LinkedListNode ptr = root;
            foreach (int item in input)
            {
                ptr.next = new LinkedListNode(item);
                ptr = ptr.next;
            }
            return root.next;
        }
    }

    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class LinkedListNode
    {

        public int data { get; set; }
        public LinkedListNode next { get; set; }

        public LinkedListNode(int value) => data = value;


    }

}