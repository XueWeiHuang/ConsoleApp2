using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_5_Redo
{
    class Program
    {
        //        Sum Lists: You have two numbers represented by a linked list, where each node contains a single
        //digit.The digits are stored in reverse order, such that the 1 's digit is at the head of the list. Write a
        //function that adds the two numbers and returns the sum as a linked list.
        //EXAMPLE
        //Input: (7-> 1 -> 6) + (5 -> 9 -> 2) .Thatis,617 + 295.
        //Output: 2 - > 1 - > 9. That is, 912.
        //FOLLOW UP
        //Suppose the digits are stored in forward order.Repeat the above problem.
        //Input: (6 -> 1 -> 7) + (2 -> 9 -> 5).Thatis,617 + 295.
        //Output: 9 - > 1 - > 2. That is, 912.
        static void Main(string[] args)
        {
        }
        public static LinkedListNode<int>  SumUpNode(LinkedListNode<int>node1, LinkedListNode<int>node2)
        {
            LinkedListNode<int> resultHead = null;
            LinkedListNode<int> previouResultNode = null;
            var node1Copy = node1;
            var node2Copy = node2;
            int sumUpCarry = 0;
            while (node1Copy!=null && node2Copy!=null)
            {
                var valueSumUp = node1Copy.Value + node2Copy.Value + sumUpCarry;
                sumUpCarry = 0;
                if (valueSumUp >= 10)
                {
                    sumUpCarry = 1;
                    valueSumUp -= 10;
                }
                if (resultHead==null)
                {
                    resultHead = new LinkedListNode<int>();
                    resultHead.Value = valueSumUp;
                    previouResultNode = resultHead;
                }
                else
                {
                    var resultNode = new LinkedListNode<int>();
                    resultNode.Value = valueSumUp;
                    previouResultNode.Next = resultNode;
                    previouResultNode = resultNode;

                }
                node1Copy = node1Copy.Next;
                node2Copy = node2Copy.Next;
            }
            //when node1 and node2 copy reaches end will be null for both, while having carry 1, means we need to add a new element to the sum up list 90+20=110
            if (sumUpCarry==1 && node2Copy==null && node1Copy==null)
            {
                var resultNode = new LinkedListNode<int>();
                resultNode.Value = 1;
                previouResultNode.Next = resultNode;
                previouResultNode = resultNode;
            }
            //then find out which list is longer after literating through above steps
            var longerList = new LinkedListNode<int>();
            if (node1Copy == null && node2Copy != null)
            {
                longerList = node2Copy;
            }
            else if (node1Copy != null && node2Copy == null)
            {
                longerList = node1Copy;
            }
            //longer list has values left should be added into result list
            while(longerList!=null)
            {
                var valueWithCarry = longerList.Value + sumUpCarry;
                sumUpCarry = 0;
                if (valueWithCarry>=10)
                {
                    valueWithCarry -= 10;
                    sumUpCarry = 1;
                }
                var resultNode = new LinkedListNode<int>();
                resultNode.Value = valueWithCarry;
                previouResultNode.Next = resultNode;
                previouResultNode = resultNode;
            }
            return resultHead;


        }

        //what if a non reversed list passed in this is method to reserve a linked list
        public static LinkedListNode<int> ReverseList (LinkedListNode<int> input)
        {
            if (input==null)
            {
                throw new Exception("fuck off");
            }
            LinkedListNode<int> reservedBack = null;
            LinkedListNode<int> crrentNode = input;
            while (crrentNode!=null)
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


        //now combine reserved linkedlist and resserve method-genius
        public static LinkedListNode<int> AddNonReserve (LinkedListNode<int> node1, LinkedListNode<int> node2)
        {
            node1 = ReverseList(node1);
            node2 = ReverseList(node2);
            var newResult = SumUpNode(node1, node2);
            return ReverseList(newResult);
        }


        //
        // Summary:
        //     Represents a node in a System.Collections.Generic.LinkedList`1. This class cannot
        //     be inherited.
        //
        // Type parameters:
        //   T:
        //     Specifies the element type of the linked list.
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
