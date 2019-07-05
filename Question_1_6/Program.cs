using System;

namespace Question_1_6
{
    class Program
    {
        //String Compression: Implement a method to perform basic string compression using the counts
        //        of repeated characters.For example, the string aabcccccaaa would become a2blc5a3.If the
        //"compressed" string would not become smaller than the original string, your method should return
        //the original string. You can assume the string has only uppercase and lowercase letters(a - z).
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input = Console.ReadLine().ToString();
            Console.WriteLine(CompressedString(input));
        }
        public static string CompressedString (string input)
        {
           
            var charToCheck = input[0];
            var charCount = 1;
            var result = "";
            for (int i=0; i<input.Length;i++)
            {
                if (input[i]==charToCheck)
                {
                    charCount++;
                }
                else
                {
                    result += charToCheck;
                    result += charCount.ToString();
                    charToCheck = input[i];
                    charCount = 1;
                }
            }
            //after for loop, there will be last character and count need to put into string
            result += charToCheck;
            result += charCount;
            return input.Length > result.Length ? result : input;
        }
    }
}
