using static System.Console;

namespace AmazonTest
{

    /*
     * 
     * 
     * Given an unsorted array A of size N that contains only non-negative integers, find a continuous sub-array which adds to a given number S.
     * 
     * Example 1:

        Input:
        N = 5, S = 12
        A[] = {1,2,3,7,5}
        Output: 2 4
        Explanation: The sum of elements 
        from 2nd position to 4th position 
        is 12.


       Example 2:

        Input:
        N = 10, S = 15
        A[] = {1,2,3,4,5,6,7,8,9,10}
        Output: 1 5
        Explanation: The sum of elements 
        from 1st position to 5th position
        is 15.
 

        Your Task:
        You don't need to read input or print anything. 
        The task is to complete the function subarraySum() which takes arr, N and S as input parameters and returns a list containing the starting and ending 
        positions of the first such occurring subarray from the left where sum equals to S. The two indexes in the list should be according to 1-based indexing. 
        If no such subarray is found, return an array consisting only one element that is -1.

        Expected Time Complexity: O(N)
        Expected Auxiliary Space: O(1)

 

        Constraints:
        1 <= N <= 105
        1 <= Ai <= 109

     * */

    public static class Program
    {
        static void Main(string[] args)
        {
            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("Subarray with given sum" + "[  1, 2, 3, 7, 5 ] Esperado = 12 ");
            WriteLine("---------------------------------------");

            // WriteLine("Result : " + Solution.SubarraySum_SOLUCTION_ONE(new int[] { 1, 2, 3, 7, 5 },  12));
            // WriteLine("Result : " + Solution.SubarraySum_SOLUCTION_TWO(new int[] { 1, 2, 3, 7, 5 }, 12));
             WriteLine("Result : " + Solution.SubarraySum_SOLUCTION_THREE(new int[] { 4, 2, 3, 7, 2, 4, 2 }, 13));
            WriteLine("Result : " + Solution.SubarraySum_SOLUCTION_FOUR(new int[] { 4, 2, 3, 7, 2, 4, 2 }, 13));

            ReadKey();
        }
    }

    class Solution
    {

        //Solução 1 menos performática classificada como complexidade O(N^3)
        public static bool SubarraySum_SOLUCTION_ONE(int[] arr, int s)
        {

            for (int i = 0; i < arr.Length; i++) // O(N)
            {
                WriteLine(" Level 1 =>  " + arr[i]);

                for (int j = i; j < arr.Length; j++) // O(N)
                {
                    int soma_atual = 0;
                    WriteLine(" Level 2 =>  " + arr[j]);

                    for (int k = i; k <= j; k++)// O(N)
                    {
                        soma_atual += arr[k];
                        WriteLine(" Level 3 =>  " + arr[k] + "SOMA =>" + soma_atual);
                        if (soma_atual == s)
                        {
                            WriteLine(i++ + "" + j++);
                            return true;

                        }
                    }
                }
            }
            return false;
        }


        //Solução 2 menos performática classificada como complexidade O(N^2)
        public static bool SubarraySum_SOLUCTION_TWO(int[] arr, int s)
        {
            for (int i = 0; i < arr.Length; i++)// O(N)
            {
                int soma_atual = 0;
                WriteLine(" Valor 1 =>  " + arr[i]);
                for (int j = i; j < arr.Length; j++)// O(N)
                {
                    WriteLine(" Valor 2 =>  " + arr[j]);

                    soma_atual += arr[j];
                    WriteLine(" Valor 3 =>  " + arr[j] + " SOMA => " + soma_atual);
                    if (soma_atual == s)
                    {
                        WriteLine(i++ + "" + j++);
                        return true;
                    }
                }
            }
            return false;
        }


        // SOLUÇÃO 3 - APLICANDO TECNICA DE (SLIDING WINDON) OU (TWO POINTERS) PARA OBTER UMA MELHOR PERFORMATICA O(N) LINERAR
        // A GRANDE SACADA É MOVER OS PONTEIROS FRIST E END JUNTAMENTE CONFORME A REGRA PROPOSTA.
        public static bool SubarraySum_SOLUCTION_THREE(int[] arr, int s)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int soma_atual = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    soma_atual += arr[j];

                    if (soma_atual == s)
                    {
                        WriteLine("posição 1: " + i++ + " => posição 2: " + j++);
                        return true;
                    }
                    else if (soma_atual > s)
                        break;
                }
            }
            return false;
        }


        public static bool SubarraySum_SOLUCTION_FOUR(int[] arr, int s)
        {
            int soma_atual = 0; // O(2N) == o(n)
            int inicio = 0; 

            for (int fim = 0; fim < arr.Length; fim++) // o(N)
            {
                soma_atual += arr[fim]; // Constante

                while (soma_atual > s && inicio < fim) //  Constante pois temos inicio e fim setando 
                {
                    soma_atual -= arr[inicio];
                    inicio++;
                }

                if (soma_atual == s)
                {
                    WriteLine("posição 1: " + inicio++ + " => posição 2: " + fim++);
                    return true;
                }

            }

            return false;
        }

    }
}