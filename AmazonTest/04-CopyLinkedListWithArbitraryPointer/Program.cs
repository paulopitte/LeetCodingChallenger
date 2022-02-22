using static System.Console;

namespace AmazonTest
{
    /*
     
        Você recebe uma lista vinculada onde o nó tem dois ponteiros. nextO primeiro é o ponteiro regular . O segundo ponteiro é chamado arbitrary_pointere pode apontar para qualquer nó na lista encadeada. Seu trabalho é escrever código para fazer uma cópia profunda da lista vinculada fornecida. Aqui, cópia profunda significa que quaisquer operações na lista original (inserção, modificação e remoção) não devem afetar a lista copiada.

        Aqui está um exemplo de uma lista encadeada com ponteiros arbitrários conectados.
    
        Complexidade do tempo de execução
        Linear, O(n).

        Complexidade da Memória
        Linear, O(n).


        Detalhamento da Solução
        Essa abordagem usa um mapa para rastrear nós arbitrários apontados pela lista original. Você criará uma cópia profunda da lista vinculada original (digamos list_orig) em duas passagens.

        Na primeira passagem, crie uma cópia da lista vinculada original. Ao criar esta cópia, use os mesmos valores para dados e arbitrary_pointerna nova lista. Além disso, continue atualizando o mapa com entradas onde a chave é o endereço do nó antigo e o valor é o endereço do novo nó.
        Depois que a cópia for criada, faça outra passagem na lista vinculada copiada e atualize ponteiros arbitrários para o novo endereço usando o mapa criado na primeira passagem.
     */


    public static class Program
    {
        static void Main(string[] args)
        {
            var arr = Solution.ToLinkedListNode(new int[] { 3, 2, 1, 0 });

            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("Copy Linked List with Arbitrary Pointer ");

            WriteLine("---------------------------------------");
            WriteLine("Result : " + Solution.Deep_Copy_Arbitrary_Pointer(arr));

            ReadKey();
        }
    }


    class Solution
    {

        public static LinkedListNode Deep_Copy_Arbitrary_Pointer(LinkedListNode head)
        {

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