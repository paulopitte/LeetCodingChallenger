using static System.Console;

namespace AmazonTest
{
    /*
     

              Dado um array de inteiros e um valor, determine se existem dois inteiros no array cuja soma seja igual ao valor dado. Retorna true se a soma existir e retornar false se não existir.

            Complexidade do tempo de execução
            A complexidade de tempo de execução desta solução é linear, O(n).

            Complexidade da Memória
            A complexidade de memória desta solução é linear, O(n).


            Detalhamento da Solução
            Nesta solução, você pode usar o algoritmo a seguir para encontrar um par que se soma ao destino (digamos val).

            Digitalize todo o array uma vez e armazene os elementos visitados em um conjunto de hash.
            Durante a varredura, para cada elemento ena matriz, verificamos se val- eestá presente no conjunto de hash, ou seja, val- ejá foi visitado.
            Se val- efor encontrado no conjunto de hash, significa que há um par ( e, val- e) no array cuja soma é igual ao dado val.
            Se esgotamos todos os elementos do array e não encontramos nenhum desses pares, a função retornará false.
    
     */


    public static class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 7, 1, 2, 8, 4, 3 };

            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("Find the missing number in the array ");

            WriteLine("---------------------------------------");
            WriteLine("Result : " + Solution.FindSumOfTwo(arr, 9));

            ReadKey();
        }
    }


    class Solution
    {

        public static bool FindSumOfTwo(int[] arr, int target)
        {
            HashSet<int> found = new();
            for (int i = 0; i < arr.Length; i++)
            {
                if (found.Contains(target - arr[i]))
                    return true;

                found.Add(arr[i]);
            }
            return false;
        }

    }


}