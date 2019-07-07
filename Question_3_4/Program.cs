using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3_4
{
    class Program
    {
        //Queue via Stacks: Implement a MyQueue class which implements a queue using two stacks.
        static void Main(string[] args)
        {
        }
        public class QueueWithStacks
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> reversedStack = new Stack<int>();
            public QueueWithStacks()
            {
                stack = new Stack<int>();
                reversedStack = new Stack<int>();
            }
            public void EnableQueue(int value)
            {
                stack.Push(value);
            }
            public int DeQueue()
            {
                if (stack.Count == 0)
                    throw new Exception("there is no item in queue");
                while(stack.Count!=0)
                {
                    //get the top of stack and push into reversed stack
                    reversedStack.Push(stack.Pop());

                }
                var lastElement= reversedStack.Peek();
                while (reversedStack.Count != 0)
                    stack.Push(reversedStack.Pop());
                return lastElement;
            }
        }
    }
}
