using System;
using System.Collections.Generic;
using static System.Console;

namespace _217_ContainsDuplicate
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/contains-duplicate/
         *
         *
         *  Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct. 

            Example 1:

            Input: nums = [1,2,3,1]
            Output: true
            Example 2:

            Input: nums = [1,2,3,4]
            Output: false
            Example 3:

            Input: nums = [1,1,1,3,3,4,3,2,4,2]
            Output: true
 
         */


        static void Main(string[] args)
        {
            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("217 - Contains Duplicate");
            WriteLine("---------------------------------------");

            var array = new int[] { 3, 7, 1, 2, 8, 4, 5, 3 };
            var result = Solution.ContainsDuplicate(array);

            WriteLine("return => " + result);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public static bool ContainsDuplicate(int[] nums) =>
             new HashSet<int>(nums).Count < nums.Length;

    }
}
