using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3_3
{
    class Program
    {
        //        Stack of Plates: Imagine a(literal) stack of plates.If the stack gets too high, it might topple.
        //Therefore, in real life, we would likely start a new stack when the previous stack exceeds some
        //threshold.Implement a data structure SetOfStacks that mimics this. SetOfStacks should be
        //composed of several stacks and should create a new stack once the previous one exceeds capacity.
        //SetOfStacks.push() and SetOfStacks.pop() should behave identically to a single stack
        //(that is, pop ( ) should return the same values as it would if there were just a single stack).
        //FOLLOW UP
        //Implement a function popAt(int index) which performs a pop operation on a specific substack.
        //pg99
        static void Main(string[] args)
        {

        }
        public class StackSets
        {
            List<Stack<int>> StackList = new List<Stack<int>>();
            public void Push(int input)
            {
                var last = getLastStack();
                if (last != null)
                    last.Push(input);
                else
            }
            public Stack<int> getLastStack()
            {
                if (StackList.Count == 0)
                    return null;
                return StackList[StackList.Count - 1];


            }
        }
    }
}
