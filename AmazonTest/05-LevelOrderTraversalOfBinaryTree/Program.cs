using static System.Console;
namespace Amazon
{
    public static class Program
    {
        /*
         * Dada a raiz de uma árvore binária, exiba os valores dos nós em cada nível. Os valores dos nós para todos os níveis devem ser exibidos em linhas separadas. Vamos dar uma olhada na árvore binária abaixo.
         * A passagem de ordem de nível para esta árvore deve se parecer com:

          *  100
          *  50, 200
          *  25, 75, 350
         */
        public static void Main(string[] args)
        {
            var root = new Node(1);


            root = new Node(100);
            root.Left = new Node(50);
            root.Right = new Node(200);
            root.Left.Left = new Node(25);
            root.Left.Right = new Node(75);
            root.Right.Right = new Node(350);


            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("Level Order Binary Tree Traversal ");

            WriteLine("---------------------------------------");
            Solution.PrintLevelOrder(root);

            ReadKey();
        }
    }


    class Solution
    {
        public static void PrintLevelOrder(Node root)
        {
            Queue<Node> queue = new();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                Node tempNode = queue.Dequeue();
                Write(tempNode.data + " ");

                if (tempNode.Left != null)
                    queue.Enqueue(tempNode.Left);


                if (tempNode.Right != null)
                    queue.Enqueue(tempNode.Right);
            }
        }
    }

    public class Node
    {

        public int data { get; set; }
        public Node Left, Right;

        public Node(int item = 0, Node left = null, Node right = null)
        {
            data = item;
            Left = left;
            Right = right;
        }


    }


}