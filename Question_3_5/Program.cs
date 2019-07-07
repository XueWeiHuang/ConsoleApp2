using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3_5
{
    class Program
    {
        //        Sort Stack: Write a program to sort a stack such that the smallest items are on the top.You can use
        //an additional temporary stack, but you may not copy the elements into any other data structure
        //(such as an array). The stack supports the following operations: push, pop, peek, and isEmpty.
        static void Main(string[] args)
        {
        }
        public static void SortStack (Stack<int> toBeSorted)
        {
            if (toBeSorted==null)
            {
                throw new Exception("hello world");
            }
            var additionalStack = new Stack<int>();
            while(toBeSorted.Count!=0)
            {
                var topStackItem = toBeSorted.Pop();
                //if the new value is smaller than what it has in the addtional stack, pop that in the additional stack and push back to original stack
                //push the new value to the addtional value, this ensure always largest on the op
                while(additionalStack.Count!=0 && topStackItem<additionalStack.Peek())
                {
                    toBeSorted.Push(additionalStack.Pop());
                }
                additionalStack.Push(topStackItem);
            }
            //push value in addtional stack back to original stack, always has smallest on top  
            while (additionalStack.Count()!=0)
            {
                toBeSorted.Push(additionalStack.Pop());
            }
        }
    }
}
