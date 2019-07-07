using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool ExistsRoute(Node from, Node to)
        {
            var visitedSet = new HashSet<Node>();
            var queue = new Queue<Node>();
            queue.Enqueue(from);
            while(queue.Count!=0)
            {
                //after adding from into que, remove first node means it has been visted, for connections in the from node,  add them into node and determine they are connected to the to point.
                var node = queue.Dequeue();
                if (node == to)
                    return true;
                visitedSet.Add(node);

                foreach (var connection in node.Connections)
                    queue.Enqueue(connection);
            }
            return false;
        }

        public class Node
        {
            public string Name { get; set; }
            public List<Node> Connections { get; set; }
            public Node (string name)
            {
                Name = name;
                Connections = new List<Node>();
            }
        }
    }
}
