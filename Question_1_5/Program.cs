using System;

namespace Question_1_5
{
    class Program
    {

        ///One Away: There are three types of edits that can be performed on strings: insert a character,
        //remove a character, or replace a character.Given two strings, write a function to check if they are
        //one edit (or zero edits) away.
        //EXAMPLE
        //pale, ple -) true
        //pales, pale -) true
        //pale, bale -) true
        //pale, bae -) false
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter 1 strings");
            var input1 = Console.ReadLine().ToString();
            Console.WriteLine("enter 1 strings");
            var input2 = Console.ReadLine().ToString();
            Console.WriteLine("one away or not " + OneAway(input1, input2));

        }


        public static bool OneAway(string input1, string input2)
        {
            var longgerString = input1.Length > input2.Length ? input1 : input2;
            var shorterString = input1.Length <= input2.Length ? input1 : input2;
            var longgerIndex = 0;
            var shorterIndex = 0;
            var onlyOneEditAway = false;
            if (longgerString.Length - shorterString.Length > 1)
                return false;
            if (longgerString.Length==shorterString.Length)
            {
                for (int i=0; i<shorterString.Length;i++)
                {
                    if (shorterString[i]!=longgerString[i])
                    {
                        //if a different character already found, 2nd time when a different character is found, means not one edit away
                        if (onlyOneEditAway)
                        {
                            return false;
                        }
                        onlyOneEditAway = true;
                    }
                }
                return onlyOneEditAway;
            }
            else if (longgerString.Length-shorterString.Length==1)
            {
                while(longgerIndex<longgerString.Length && shorterIndex<shorterString.Length)
                {
                    if (shorterString[shorterIndex]!=longgerString[longgerIndex])
                    {
                        //if a difference is found, that means one insert/delete away, next time means this two strings are not one insert/delete away
                        if (shorterIndex != longgerIndex)
                            return false;
                        longgerIndex++;
                    }
                    else
                    {
                        longgerIndex++;
                        shorterIndex++;
                    }
                }
            }
            return true;


        }
    }
}
