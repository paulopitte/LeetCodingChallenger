using System;
using System.Collections;
using System.Collections.Generic;

namespace _3_LongestSubstringWithoutRepeatingChars
{
    internal sealed class Program
    {

        /*
         * Referencia
         * https://leetcode.com/problems/longest-substring-without-repeating-characters/
         * 
         * Given a string s, find the length of the longest substring without repeating characters.

 

            Example 1:

            Input: s = "abcabcbb"
            Output: 3
            Explanation: The answer is "abc", with the length of 3.
            Example 2:

            Input: s = "bbbbb"
            Output: 1
            Explanation: The answer is "b", with the length of 1.
            Example 3:

            Input: s = "pwwkew"
            Output: 3
            Explanation: The answer is "wke", with the length of 3.
            Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

            Constraints:

            0 <= s.length <= 5 * 104
            s consists of English letters, digits, symbols and spaces.
         * 
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("3. Longest Substring Without Repeating Characters!");

            // Output: 3 // wke
            var result = LengthOfLongestSubstring("abcabcbb");

        }

        private static int LengthOfLongestSubstring(String s)
        {
            int forward = 0;     
            int last = 0;         
            int size = 0;
            HashSet<char> hash = new();

            while (forward < s.Length)
            {
                if (!hash.Contains(s[forward]))
                {
                    hash.Add(s[forward]);
                    forward++;
                    size = Math.Max(size, hash.Count);
                }
                else
                {
                    hash.Remove(s[last]);
                    last++;
                }
            }
            return size;
        }
    }
}
