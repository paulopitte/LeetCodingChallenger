namespace TwoSum
{
    using System.IO;
    using System;

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            data = nodeData;
            next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
            }

            tail = node;
        }
    }

    class SinglyLinkedListPrintHelepr
    {
        public static void PrintList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }
    }


    class Result
    {

        /*
         * Complete the 'maximumPages' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_SINGLY_LINKED_LIST head as parameter.
         */

        /*
         * For your reference:
         *
         * SinglyLinkedListNode
         * {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */

        public static int maximumPages(SinglyLinkedListNode head)
        {


            return 7;
        }

    }
    class Solution
    {
        public static void Start(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            SinglyLinkedList head = new SinglyLinkedList();

            int headCount = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < headCount; i++)
            {
                int headItem = Convert.ToInt32(Console.ReadLine().Trim());
                head.InsertNode(headItem);
            }

            int result = Result.maximumPages(head.head);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
