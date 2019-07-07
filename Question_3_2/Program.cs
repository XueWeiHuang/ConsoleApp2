using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3_2
{
    class Program
    { 
//    {
//        Stack Min: How would you design a stack which, in addition to push and pop, has a function min
//which returns the minimum element? Push, pop and min should all operate in 0(1) time.
        static void Main(string[] args)
        {
        }
        Stack<int> stack = new Stack<int>();
        Stack<int> minStack = new Stack<int>();
        public void Push(int value)
        {
            if (minStack.Count == 0 || value <= minStack.Peek()) ;
            minStack.Push(value);
            stack.Push(value);
        }
        public int Pop()
        {
            var value = stack.Pop();
            if (value <= minStack.Peek())
            {
                minStack.Pop();
            }
            return value;
        }
        public int GetMin()
        {
            return minStack.Peek();
        }
    }
}
