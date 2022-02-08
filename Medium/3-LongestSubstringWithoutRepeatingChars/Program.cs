using System;
using System.Collections;
using System.Collections.Generic;

namespace _3_LongestSubstringWithoutRepeatingChars
{
  internal sealed  class Program
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

            // Output: 3
            var result = LengthOfLongestSubstring("abcabcbbx");

        }


        private static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 0)            
                return 0;

            Dictionary<char, int> map = new();

            int duplicationIndex = -1;
            int maxSize = 0;

            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char v = chars[i];
                int lastIndex = map.GetValueOrDefault(v);

                if (duplicationIndex < lastIndex)               
                    duplicationIndex = lastIndex;

                if (!map.ContainsKey(v))               
                    maxSize = Math.Max(maxSize, i - duplicationIndex);
                    map.Add(chars[i], i);
                
            }

            return map.Count;
        }
    }
}
