using static System.Console;

namespace AmazonTest
{
    /*
     * 
     * https://app.codesignal.com/interview-practice/task/pMvymcahZ8dY4g75q/description     * 
     */
    public static class Program
    {
        static void Main(string[] args)
        {
            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("First Duplicate " + "[  2, 1, 3, 5, 3, 2 ] Esperado => 3 ");
            WriteLine("---------------------------------------");

            WriteLine("Result : " + Solution.FirstDuplicatePrimeiraSolucao(new int[] { 2, 1, 3, 5, 3, 2 }));
            WriteLine("Result : " + Solution.FirstDuplicateSegundaSolucao(new int[] { 2, 1, 3, 5, 3, 2 }));

            ReadKey();
        }
    }


    class Solution
    {
        public static int FirstDuplicatePrimeiraSolucaoRuim(int[] v)
        {
            var duplication = new List<int>();
            for (int i = 0; i < v.Length; i++)
            {
                for (int x = i + 1; x < v.Length; x++)
                {
                    if (v[i] == v[x])
                    {
                        duplication.Add(v[x]);

                    }
                }

            }

            return -1;
        }

        public static int FirstDuplicatePrimeiraSolucao(int[] v)
        {
            int menor_segundo_indice = -1;

            for (int i = 0; i < v.Length; i++) // o(n^2)
                for (int j = i + 1; j < v.Length; j++) // O(N)
                    if (v[i] == v[j])
                        if (menor_segundo_indice == -1 || j < menor_segundo_indice)
                            menor_segundo_indice = j; // aqui o menor valor recebe o J pois sempre será o segundo indice.                       



            if (menor_segundo_indice == -1)
                return -1;
            else
                return v[menor_segundo_indice];


        }


        public static int FirstDuplicateSegundaSolucao(int[] v) // O(N)
        {
            HashSet<int> ja_apareceram = new();

            for (int i = 0; i < v.Length; i++)
            {
                if (ja_apareceram.Contains(v[i]))
                    return v[i];
                ja_apareceram.Add(v[i]);
            }
            return -1;
        }


    }
}