using System;
using System.Text;
using static System.Console;
namespace StringEncodingSumDuplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WriteLine("");
            WriteLine("+++++++++++++++++++++++++++++++++++++++");
            WriteLine("String Encoding Sum Duplication");
            WriteLine("---------------------------------------");

            WriteLine(Solution.Encode("aabbbccccAB"));

            ReadKey();
        }
    }


    public static class Solution
    {
        public static string Encode(string input)
        {
            //check for null input
            if (string.IsNullOrEmpty(input))
                return string.Empty;


            StringBuilder sb = new();

            char[] inputChars = input.ToCharArray();
            char prevChar = inputChars[0];
            int counter = 0;


            foreach (var c in inputChars)
            {
                if (prevChar == c)
                    counter++;
                else if(prevChar != c)
                {
                    sb.Append(counter).Append(prevChar);
                    prevChar = c; 
                    counter = 1;
                }
            }

            sb.Append(counter).Append(prevChar);
            return sb.ToString();



        }
    }
}
