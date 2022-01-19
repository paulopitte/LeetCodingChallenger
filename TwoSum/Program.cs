using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two Sum!");

            var ret = TwoSum(new int[] { 7, 2, 13, 11 }, 9);


            string[] repo = new[] { "Carro", "Caro", "Carripa", "Mouse", "Teclado", "Tech", "Tecla" };


            string query = Console.ReadLine();
            searchSuggestions(repo, query);
        }





        private static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[j] + nums[i] == target)
                        return new int[] { i, j };

            return null;
        }




        public static void searchSuggestions(string[] repository, string customerQuery)
        {

            #region teste1

            string search_char = customerQuery.Substring(0, 1).ToUpper();
            List<string> match = new();
            for (int i = 0; i < repository.Length; i++)
            {
                string query = repository[i];
                if (query.Substring(0, 1).ToUpper() == search_char)
                    match.Add(query);
            }
            #endregion


            #region teste2
            string start_char = customerQuery.Substring(0, 1).ToUpper();
            int start_index = Array.BinarySearch(repository, start_char);

            List<string> match_words = new();
            for (int i = start_index + 1; i < repository.Length; i++)
            {
                string test_word = repository[i];
                if (test_word.Substring(0, 1).ToUpper() != start_char)
                    break;
                int max_length = Math.Min(test_word.Length, customerQuery.Length);
                string short_word = test_word.Substring(0, max_length);


                match_words.Add(test_word);
            }

            #endregion
        }





    }




}
