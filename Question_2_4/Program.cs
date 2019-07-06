using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_4
{
    class Program
    {
        //        Partition: Write code to partition a linked list around a value x, such that all nodes less than x come
        //before all nodes greater than or equal to x.If x is contained within the list, the values of x only need
        //to be after the elements less than x(see below). The partition element x can appear anywhere in the
        //"right partition"; it does not need to appear between the left and right partitions.
        //EXAMPLE
        //Input: 3 -) 5 -) 8 -) 5 -) 113 -) 2 -) 1 [partition = 5]
        //        Output: 3 -) 1 -) 2 -) 113 -) 5 -) 5 -) 8
        //We iterate through the linked list, inserting elements into our before list or our after list. Once we reach
        //the end of the linked list and have completed this splitting, we merge the two lists.
        static void Main(string[] args)
        {
        }
        public static LinkedList<int> newSortedLinkedList (LinkedListNode<int> originalNode, int partitionValue)
        {
            //define two new list node which happens at left and right for the value
            LinkedListNode<int> leftHead = null;
            LinkedListNode<int> previousLeftNode = null;
            LinkedListNode<int> rightHead = null;
            LinkedListNode<int> previousRightNode = null;
            var returnList = new LinkedList<int>();

            var newNode = originalNode;
            
            //partition the list
            if (originalNode == null)
                return null;
            while(newNode!=null)
            {
                if (newNode.Value<partitionValue)
                {
                    //if the head is null, assign the head with current node
                    if (leftHead==null)
                    {
                        leftHead = newNode;
                        previousLeftNode = newNode;
                    }
                    else
                    //assign next node to the current node and assgin left node to current node
                    {
                        previousLeftNode.Next = newNode;
                        previousLeftNode = newNode;
                    }
                    
                }
                else
                {
                    if (rightHead==null)
                    {
                        rightHead = newNode;
                        previousRightNode = newNode;
                    }
                    else
                    {
                        previousRightNode.Next = newNode;
                        previousRightNode = newNode;
                    }
                }
                newNode = newNode.Next;

            }
            //combine two nodes intolist
            returnList.AddFirst(previousLeftNode);
            returnList.AddAfter(previousLeftNode, previousRightNode);
            return returnList;
        }

    }
}
