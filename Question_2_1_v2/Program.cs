using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Question_2_1_v2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public  void RemoveDup(LinkedListNode<int> node)
        {
            var table = new Dictionary<int, bool>();
            LinkedListNode<int> previous = null; //record the last node
            while (node !=null)
            {
                if (table.ContainsKey(node.Value))
                {
                    //if we find the value is already there and previous node is not empty that means it is
                    //duplicate, move previous node directly to next and skip current node and move to next
                    //node, 
                    //steps below will set node to next
                    if (previous != null)
                        previous.Next = node.Next;
                }
                else
                //first add node value to dictionary with value
                {
                    table.Add(node.Value, true);
                    previous = node;
                }
                //move to next node
                node = node.Next;
            }
        }
      
    }
}
