using static System.Console;

namespace amazonTest
{
    internal class Program
    {
        /*
         * 
         * Given a string password, find the strength of that password. The strength of a password, consisting only lowercase english letters only, is calculated as the sum of the number of distinct characters present in all possible substrings of that password.
        Example:- password = "good"
        possible sub string and count of distinct characters are
        g = 1
        o = 1
        o = 1
        d = 1
        go = 2
        oo = 1
        od = 2
        goo = 2
        ood = 2
        good = 3
        1+1+1+1+2+1+2+2+2+3 = 16

        Example:- password: "test"
        Output: 19
        Example:- password: "abc"
        Output: 10

        Given a function description:
        public static long findPasswordStrength(String password);

        https://leetcode.com/discuss/interview-question/1526418/Count-strength-of-pa%20%20ssword-or-amazon

        */
        static void Main(string[] args)
        {
            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("Count strength of password | amazon");
            WriteLine("---------------------------------------");

            WriteLine("Result : " + Solution.FindPasswordStrength("abc"));

            ReadKey();
        }
    }





    static class Solution
    {
        public static long FindPasswordStrength(String password)    // O(n^2) and space O(n)
        {
            if (password == null || password.Length == 0) return 0;

            long response = 0L;
            for (int indexPass = 1; indexPass <= password.Length; indexPass++) // O(N)
            {
                List<string> charPass = new();
                var duplicate = 0;
                for (int indexChar = indexPass - 1; indexChar >= 0; indexChar--) // O(N)
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
    }







}
