using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_8
{
    class Program
    {

        //        Loop Detection: Given a circular linked list, implement an algorithm that returns the node at the
        //beginning of the loop.
        //DEFINITION
        //Circular linked list: A(corrupt) linked list in which a node's next pointer points to an earlier node, so
        //as to make a loop in the linked list.
        //EXAMPLE
        //Input: A -> B -> C - > D -> E -> C[the same C as earlier)
        //Output: C

        //        To summarize, we move FastPointer twice as fast as SlowPointer.When SlowPointer enters
        //the loop, after k nodes, FastPointer is k nodes into the loop.This means that FastPointer and
        //SlowPointer are LOOP_SIZE - k nodes away from each other.
        //Next, if FastPointer moves two nodes for each node that SlowPointer moves, they move one node
        //closer to each other on each turn.Therefore, they will meet after LOOP_SIZE - k turns. Both will be k
        //nodes from the front of the loop.
        //The head of the linked list is also k nodes from the front of the loop.So, if we keep one pointer where it is,
        //and move the other pointer to the head of the linked list. then they will meet at the front of the loop.
        //Our algorithm is derived directly from parts 1, 2 and 3.
        //1. Create two pointers, FastPointer and SlowPointer.
        //2. Move FastPointer at a rate of 2 steps and SlowPointer at a rate of 1 step.
        //3. When they collide, move SlowPointer to LinkedListHead. Keep FastPointer where it is.
        //4. Move SlowPointer and FastPointer at a·rate of one step. Return the new collision point.
        static void Main(string[] args)
        {
        }
        //        SlowRunner is 0 steps into the loop.
        //2. FastRunner is K steps into the loop.
        //3. SlowRunner is K steps behind FastRunner.
        //4. FastRunner is LOOP_SIZE - K steps behind SlowRunner.
        //5. FastRunner catches up to SlowRunner at a rate of 1 step per unit of time.
        //So, when do they meet? Well, if FastRunner is LOOP_SIZE - K steps behind SlowRunner, and
        //FastRunner catches up at a rate of 1 step per unit oftime, then they meet after LOOP_SIZE - K steps.
        //At this point, they will be K steps before the head of the loop.Let's call this point CollisionS pot.
        public static LinkedListNode<int> LoopPoint (LinkedListNode<int> input)
        {
            //use fast runner/slower runner approach
            var slow = input;
            var fast = input;
            //find the meeting point;
            while(fast!=null && slow!=null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast)
                    break;
            }
            if (fast == null || slow == null)
                return null;
            //now we put slow back to start point, moving same pace will let fast and slow node meet some at the node start point
            slow = input;
            while (slow !=fast)
            {

                slow = slow.Next;
                fast = fast.Next;
            }
            return slow;
        }

    }
}
