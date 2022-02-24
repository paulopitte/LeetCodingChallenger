namespace AddDigits
{
    using System;

    //https://leetcode.com/problems/add-digits/

    /*
     * Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.
    Example 1:

    Input: num = 38
    Output: 2
    Explanation: The process is
    38 --> 3 + 8 --> 11
    11 --> 1 + 1 --> 2 
    Since 2 has only one digit, return it.
    Example 2:

    Input: num = 0
    Output: 0
     *      
     */

   internal sealed class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add Digits!");
            
            
            //return 11-- > 1 + 1-- > 2
            var returnAddDigits = AddDigits(38);
        }



        private static int AddDigits(int num)
        {
            while (num > 9)
            {
                int result = 0;
                while (num > 0)
                {
                    result += num % 10;
                    num /= 10;
                }
                num = result;
            }
            return num;
        }
    }
}



