using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_3
{
    class Program
    {
        //        Delete Middle Node: Implement an algorithm to delete a node in the middle(Le., any node but
        //the fi rst and last node, not necessarily the exact middle) of a singly linked list, given only access to
        //that node.
        //Input: the node c from the linked list a - >b- >c - >d - >e- >f
        //Result: nothing is returned, but the new linked list looks like a->b->d->e->f
        //simply to copy the data from the next node over to the current node, and then to delete the next node
        //simply to copy the data from the next node over to the current node, and then to delete the next node
        //simply to copy the data from the next node over to the current node, and then to delete the next node
        //simply to copy the data from the next node over to the current node, and then to delete the next node
        //simply to copy the data from the next node over to the current node, and then to delete the next node
        //simply to copy the data from the next node over to the current node, and then to delete the next node
        //simply to copy the data from the next node over to the current node, and then to delete the next node

        static void Main(string[] args)
        {
        }
        public static bool DeleteMiddleNode(LinkedListNode<int> middleNode)
        {
            //if the node is the head or the last node of element , it is wrong
            if (middleNode == null || middleNode.Next == null)
                return false;
            //find the next node after middle node
            var nextAfterMiddle= middleNode.Next;
            var beforeMiddle = middleNode.Previous;
            var newList = new LinkedList<int>();
            newList.AddFirst(beforeMiddle);
            //newList.AddFirst(beforeMiddle);
            //newList.AddAfter(beforeMiddle, nextAfterMiddle);
            newList.AddFirst(nextAfterMiddle);
            //this will return a new list which contains the node before midlle, and node right after middle;
            //https://stackoverflow.com/questions/17496864/c-sharp-how-to-link-2-linkedlistnode
            //copy next data to current node
            //middleNode.Value = nextAfterMiddle.Value;
            //middleNode.add  = nextAfterMiddle.Next;

            return true;
        }
    }
}
