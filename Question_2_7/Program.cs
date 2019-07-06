using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_7
{
    class Program
    {
        //        Intersection: Given two(singly) linked lists, determine if the two lists intersect.Return the
        //intersecting node.Note that the intersection is defined based on reference, not value. That is, if the
        //kth node of the first linked list is the exact same node (by reference) as the jth node of the second
        //linked list, then they are intersecting.


        //1. Run through each linked list to get the lengths and the tails.
        //2. Compare the tails.If they are different (by reference, not by value), return immediately.There is no intersection.
        //3. Set two pointers to the start of each linked list.
        //4. On the longer linked list, advance its pointer by the difference in lengths.
        //5. Now, traverse on each linked list until the pointers are the same.

        static void Main(string[] args)
        {
           
        }

        public LinkedListNode<int> IntersectedNode (LinkedListNode<int> input1, LinkedListNode<int> input2)
        {
            var node1 = input1;
            var node2 = input2;
            if (input1 == null || input2 == null)
                throw new Exception("inputs shouldnt be null");
            //they must be non-nullable
            var input1Length = ListLength(input1);
            var input2Length = ListLength(input2);
            if (input1Length>input2Length)
            {
                for (int i=0; i<input1Length-input2Length; i++)
                {
                    input1 = input1.Next;
                }
            }
            else
            {
                for (int i = 0; i < input2Length - input1Length; i++)
                    input2 = input2.Next;
      
            }
            while (input1!=null)
            {
                //go through from same index after adjustment until the end, to find there is any different, if it finds equal, return that node 
                //which is the intersection
                if (ReferenceEquals(input1, input2))
                {
                    return input1;
                }
                input1 = input1.Next;
                input2 = input2.Next;
            }
            return null;
        }

        public static int ListLength (LinkedListNode<int> input)
        {
            if (input == null)
                throw new Exception("meanless");
            var length = 0;
            while(input!=null)
            {
                length++;
                input = input.Next;
            }
            return length;
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
