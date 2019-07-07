using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4_2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        //        1. Insert into the tree the middle element of the array.
        //2. Insert (into the left subtree) the left subarray elements.
        //3. Insert (into the right subtree) the right subarray elements.
        //4. Recurse.

        public static BinaryTreeNode BalancedBinaryTree (int[] array)
        {
            Array.Sort(array);
            return CreatedFromSortedArray(array, 0, array.Length - 1);
        }
        public static BinaryTreeNode CreatedFromSortedArray(int[] arr, int startInd, int endInd)
        {
            if (startInd == endInd)
                return new BinaryTreeNode(arr[startInd]);
            if (startInd > endInd)
                return null;
            //still return as integer as .......it just does
            var middleIndex = (startInd + 1 + endInd) / 2;
            //finding middle element of the array
            var middleElement = arr[middleIndex];
            //putting middle element as root into the node
            var node = new BinaryTreeNode(middleElement);
            //setting left subarry starting point and end point excluding the one element has been placed in the middle; do the sameting for right subarray
            var leftSubArraryStartIndex = startInd;
            var lefSubArrayEndIndex = middleIndex - 1;
            var rightSubArrayStartIndex = middleIndex + 1;
            var rightSubArrayEndIndex = endInd;
            //recursive function to assign
            node.Left = CreatedFromSortedArray(arr, leftSubArraryStartIndex, lefSubArrayEndIndex);
            node.Right = CreatedFromSortedArray(arr, rightSubArrayStartIndex, rightSubArrayEndIndex);

            return node;
        }
        public class BinaryTreeNode
        {
            public int Value { get; set; }
            public BinaryTreeNode Left { get; set; }
            public BinaryTreeNode Right { get; set; }
            public BinaryTreeNode(int value)
            {
                Value = value;
            }
        }
    }
}
