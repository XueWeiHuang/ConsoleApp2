using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_6
{
    class Program
    {
        //Palindrome: Implement a function to check if a linked list is a palindrome.
        //so to reverse the list, itthey should be the same
        static void Main(string[] args)
        {
        }

        public static LinkedListNode<int> ReverseList(LinkedListNode<int> input)
        {
            if (input == null)
            {
                throw new Exception("fuck off");
            }
            LinkedListNode<int> reservedBack = null;
            LinkedListNode<int> crrentNode = input;
            while (crrentNode != null)
            {
                //extract node from current node
                var nodeExtract = crrentNode.Next;
                //assign current node's next node to reserved back node
                crrentNode.Next = reservedBack;
                //reserved back is set to current node with has next node set to reserved
                reservedBack = crrentNode;
                //set current node back to original current node
                crrentNode = nodeExtract;
            }
            return reservedBack;
        }

        public static bool Palindrome(LinkedListNode<int> input)
        {
            var reversedInput = ReverseList(input);
            while(input!=null && reversedInput!=null)
            {
                if (input.Value != reversedInput.Value)
                    return false;
                input = input.Next;
                reversedInput = reversedInput.Next;

            }
            return reversedInput == null && input == null;

        }


        [ComVisible(false)]
        public sealed class LinkedListNode<T>
        {
            //
            // Summary:
            //     Initializes a new instance of the System.Collections.Generic.LinkedListNode`1
            //     class, containing the specified value.
            //
            // Parameters:
            //   value:
            //     The value to contain in the System.Collections.Generic.LinkedListNode`1.
            // public LinkedListNode(T value);

            //
            // Summary:
            //     Gets the System.Collections.Generic.LinkedList`1 that the System.Collections.Generic.LinkedListNode`1
            //     belongs to.
            //
            // Returns:
            //     A reference to the System.Collections.Generic.LinkedList`1 that the System.Collections.Generic.LinkedListNode`1
            //     belongs to, or null if the System.Collections.Generic.LinkedListNode`1 is not
            //     linked.
            public LinkedList<T> List { get; }
            //
            // Summary:
            //     Gets the next node in the System.Collections.Generic.LinkedList`1.
            //
            // Returns:
            //     A reference to the next node in the System.Collections.Generic.LinkedList`1,
            //     or null if the current node is the last element (System.Collections.Generic.LinkedList`1.Last)
            //     of the System.Collections.Generic.LinkedList`1.
            public LinkedListNode<T> Next { get; set; }
            //
            // Summary:
            //     Gets the previous node in the System.Collections.Generic.LinkedList`1.
            //
            // Returns:
            //     A reference to the previous node in the System.Collections.Generic.LinkedList`1,
            //     or null if the current node is the first element (System.Collections.Generic.LinkedList`1.First)
            //     of the System.Collections.Generic.LinkedList`1.
            public LinkedListNode<T> Previous { get; }
            //
            // Summary:
            //     Gets the value contained in the node.
            //
            // Returns:
            //     The value contained in the node.
            public T Value { get; set; }
        }
    }
}
