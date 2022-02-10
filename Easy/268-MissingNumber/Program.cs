using System;
using System.Linq;
using static System.Console;
namespace _268_MissingNumber
{
    internal class Program
    {
        /*
         * https://leetcode.com/problems/missing-number/
         * 
         * Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array. 

            Example 1:

            Input: nums = [3,0,1]
            Output: 2
            Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.
            Example 2:

            Input: nums = [0,1]
            Output: 2
            Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.
            Example 3:

            Input: nums = [9,6,4,2,3,5,7,0,1]
            Output: 8
            Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.
 

            Constraints:

            n == nums.length
            1 <= n <= 104
            0 <= nums[i] <= n
            All the numbers of nums are unique.
 

            Follow up: Could you implement a solution using only O(1) extra space complexity and O(n) runtime complexity?
         * 
         * 
         */


        static void Main(string[] args)
        {
            WriteLine("");
            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("Find Missing Number");
            WriteLine("---------------------------------------");

            var random_array = new int[] { 3, 7, 1, 2, 8,  4, 5 };
            var result = Solution.MissingNumber(random_array);

            WriteLine("actual missing is " + result);
            Console.ReadKey();

        }
    }



    internal static class Solution
    {
        public static int MissingNumber(int[] numbers)
        {
            if (numbers.Length == 0 || numbers == null || !numbers.Any(x => x < 1))
                return 0;

            int missing = 0;

            for (int index = 0; index < numbers.Length; index++)
                missing += (numbers.Length - index - numbers[index]);

            return missing;
        }
    }
}
