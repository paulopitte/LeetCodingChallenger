using static System.Console;

namespace AmazonTest
{
    /*
     
            Você recebe uma matriz de números positivos de 1to n, de modo que todos os números de 1to nestejam presentes, exceto um número x. 
            Você tem que encontrar x. A matriz de entrada não está classificada. Olhe para a matriz abaixo e experimente antes de verificar a solução.    
            
            Complexidade do tempo de execução: linear) O( n )

            Complexidade da Memória: Constante, O(1)  

            Uma solução ingênua é simplesmente procurar por cada inteiro entre 1e nna matriz de entrada, interrompendo a pesquisa assim que houver um número ausente. Mas nós podemos fazer melhor. Aqui é linear,Sobre)O ( n ), solução que usa a fórmula da soma da série aritmética. Aqui estão as etapas para encontrar o número ausente:

            Encontre a soma sum_of_elementsde todos os números na matriz. Isso exigiria uma varredura linear,Sobre)O ( n ).
            Em seguida, encontre a soma expected_sumdos primeiros nnúmeros usando a fórmula da soma da série aritmética
            A diferença entre eles, ou seja expected_sum - sum_of_elements, é o número ausente na matriz.
    
     
     */


    public static class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3,7,1,2,8,4,5,6 };

            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("Find the missing number in the array ");

            WriteLine("---------------------------------------");
            WriteLine("Result : " + Solution.Find_Missing(arr));

            ReadKey();
        }
    }


    class Solution
    {

        public static int Find_Missing(int[] input)
        {
            // in input list
            int sum_of_elements = 0;
           foreach(int element in input)
            {
                sum_of_elements += element;
            }

            // There is exactly 1 number missing 
            int n = input.Length + 1;
            int actual_sum = (n * (n + 1)) / 2;
            return actual_sum - sum_of_elements;
        }

    }


}