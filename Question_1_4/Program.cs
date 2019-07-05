using System;
using System.Collections.Generic;

namespace Question_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input = Console.ReadLine().ToString();
            Console.WriteLine(IsPalindromePermutation(input));
        }

        public static bool IsPalindromePermutation(string input)
        {
            //is string a permutation of a palindrome

            //check number of each char, all should be even for even length string, only one char count can be odd for odd length string
            var oddCount = 0;
            var frequencyTable = new int[26];
            foreach (var c in input)
            {
                var charNumber = CharNumber(c);
                if (charNumber!=-1)
                {
                    frequencyTable[charNumber]++;
                    //this will cause odd count to below 0 if there is no replicated number which is no palindrome
                    if (frequencyTable[charNumber] % 2 == 1)
                        oddCount++;
                    else
                        oddCount--;

                }
            }
            return oddCount <= 1;


        }

        public static int CharNumber (char c)
        {
            var value = char.ToLower(c) - 'a';
            if (value >= 0 && value <= 25)
            {
                return value;
            }
            return -1;
        }



    }
}
