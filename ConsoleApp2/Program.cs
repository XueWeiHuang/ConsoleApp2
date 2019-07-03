using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            test2();
            Console.WriteLine("enter your word to check");

            var input = Console.ReadLine().ToString();
            Console.WriteLine(UniqueWithAdditionalMemory(input));
            Console.WriteLine("now is without memory");
            var input2 = Console.ReadLine().ToString();
            Console.WriteLine(UniqueWoMemory(input2));
            Console.WriteLine("Question 1-2 Check permutation");
            Console.WriteLine(PermuteOrNot("apple", "papel"));

        }

        //this method is o(N) cuz extracting c one by one
        static bool UniqueWithAdditionalMemory(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;
            //extract every character in the string
            var characterstring = new HashSet<char>();
            foreach (char c in input)
            {
                //if the character is not unique, it cannt be added into hashset
                if (!characterstring.Add(c))
                    return false;
            }

            return true;

        }
        //O(N^2)
        public static bool UniqueWoMemory(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;
            //this gives two loops that taking one c from i, and them compare with rest in j, if find any is false
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                        return false;
                }
            }
            return true;
        }




        static public void test2()
        {
            bool IsUniqueChars(string str)
            {
                if (str.Length > 256)
                {
                    return false;
                }

                var checker = 0;
                for (var i = 0; i < str.Length; i++)
                {
                    var val = str[i] - 'a';

                    if ((checker & (1 << val)) > 0)
                    {
                        return false;
                    }
                    checker |= (1 << val);
                }

                return true;
            }

            bool IsUniqueChars2(String str)
            {
                var hashset = new HashSet<char>();
                foreach (var c in str)
                {
                    if (hashset.Contains(c)) return false;
                    hashset.Add(c);
                }

                return true;
            }


            string[] words = { "abcde", "hello", "apple", "kite", "padle" };

            foreach (var word in words)
            {
                Console.WriteLine(word + ": " + IsUniqueChars(word) + " " + IsUniqueChars2(word));
            }

        }
        //check permuation Question 1-2
        public static bool PermuteOrNot(string original, string totest)
        {
            if (original.Length != totest.Length)
                return false;
            var originalArray = original.ToCharArray();
            var totestArray = totest.ToCharArray();
            Array.Sort(originalArray);
            Array.Sort(totestArray);
            original = originalArray.ToString();
            totest = totestArray.ToString();
            return original.Equals(totest);


        }




    }
}




