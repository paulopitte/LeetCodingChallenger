using System;
using System.Collections.Generic;

namespace AmazonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amazon Test Step 2 process!");

            var resultValues = CountChars("good");

            var resultPages = MaximumPages(new SinglyLinkedListNode(4));


            string[] repo = new[] { "Carro", "Caro", "Carripa", "Mouse", "Teclado", "Tech", "Tecla" };


            string query = Console.ReadLine();
            searchSuggestions(repo, query);
        }



        private static long CountChars(String password)
        {
            if (password == null || password.Length == 0) return 0;

            long response = 0L;
            for (int indexPass = 1; indexPass <= password.Length; indexPass++)
            {
                List<string> charPass = new();
                var duplicate = 0;
                for (int indexChar = indexPass - 1; indexChar >= 0; indexChar--)
                {
                    var unitChar = password[indexChar].ToString();
                    if (charPass.Contains(unitChar))
                        duplicate++;

                    charPass.Add(unitChar);
                    response += (indexPass - indexChar - duplicate);
                }
            }
            return response;
        }

        public static int MaximumPages(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode fast = head;
            SinglyLinkedListNode slow = head;
            SinglyLinkedListNode current = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            slow = reverse(slow);
            int max = int.MinValue;
            while (slow != null)
            {
                int sum = slow.data + current.data;
                if (max < sum)
                {
                    max = sum;
                }
                slow = slow.next;
                current = current.next;
            }
            return max;
        }

        public static SinglyLinkedListNode reverse(SinglyLinkedListNode head)
        {

            SinglyLinkedListNode prev = null;
            SinglyLinkedListNode next = head;
            SinglyLinkedListNode current = head;

            while (current != null)
            {
                next = next.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
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
