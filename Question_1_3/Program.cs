using System;

namespace Question_1_3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("please enter the word");
            var input = Console.ReadLine().ToCharArray();
            Console.WriteLine("enter the length");
            var length = int.Parse(Console.ReadLine().ToString());
            urlify(input, length);
            Console.WriteLine(input);


        }

        public static void urlify (char[] input, int length)
        {


            var spaceNum = 0;
            for (int i = 0; i < length; i++)
            {
                if (input[i] == ' ')
                    spaceNum++;
            }

            var newlength = length + 2 * spaceNum;
            while(length!=0)
            {//go from backwards because las non space c still be last c
                if (input[length - 1] != ' ')
                {
                    input[length - 1 + 2 * spaceNum] = input[length - 1];
                    length--;
                }
                //if the
                else
                {
                    input[length - 1 + 2 * spaceNum - 2] = '%';
                    input[length - 1 + 2 * spaceNum - 1] = '2';
                    input[length - 1 + 2 * spaceNum] = '0';
                    spaceNum--;
                    length--;
                }
            }
            ////cuz replace space with %20 needs 2 extra space
            //var newLength = spaceNum*2 + length;
            //var offset = spaceNum * 2;
            ////input = input.ToCharArray();


            ////now strat replace from the end of string
            //for (int i=length-1; i>=0; i--)
            //{
            //    if (input[i] == ' ')
            //    {
            //        input[i + offset] = '0';
            //        input[i + offset - 1] = '2';
            //        input[i + offset - 2] = '%';

            //    }
            //    else
            //    {
            //        input[i + offset] = input[i];

            //    }
        

        }
    }
}
