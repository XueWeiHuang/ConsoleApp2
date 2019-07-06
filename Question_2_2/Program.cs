using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_2
{
    class Program
    {
        //Return Kth to Last: Implement an algorithm to find the kth to last element of a singly linked list.
        //we have defined k such that passing in k = 1 would return the last element, k
//2 would return to the second to last element, and so on.It is equally acceptable to define k such that k
//= e would return the last element.
        static void Main(string[] args)
        {
        }
        //basic wthout recursive
        public static LinkedListNode<int> FindKToLast(LinkedListNode<int> head, int k)
        {

            //second pointer starts k steps after first pointer, 
            //and when first pointer hits end second is on kth node before last
            int i = 0;
            var first = head;
            var second = head;
            //if first keeps going until end, folloing command will execute
            while(first!=null)
            {
                //only when it comes to the k element, it starts to let seond node starts from node while first node keeps going until the end of list
                if (i > k)
                    second = second.Next; 
                //when i<k, it keeps going assigning first to next node
                first = first.Next;
                i++;
            }
            //return 2nd will let ou know the kth element to last elment of linked list
            return second;

        }
    }
}
