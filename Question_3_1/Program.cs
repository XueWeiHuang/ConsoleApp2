using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //Three in One: Describe how you could use a single array to implement three stacks.

    }

    public class ThreeStacks
    {
        readonly int stacksize;
        int[] array;
        int[] stackTopIndex = new int[3];

        public ThreeStacks(int stacksize)
        {
            this.stacksize = stacksize;
            //this array represent all values 
            array = new int[stacksize * 3];
            for (int stackIndex=0; stackIndex<3; stackIndex++)
            {
                //this define each stack's top index
                //e.g stockTopIndex[1]=1*3
                //e.g stockTopIndex[2]=2*3
                //this means in the big array, the position of last elment going into the stack

                stackTopIndex[stackIndex] = stackIndex * stacksize;
            }
        }

        public void Push(int value, int stackIndex)
        {
            //stack index here mean to access which typical stack
            if (stackIndex < 0 || stackIndex > 2)
                throw new Exception("out of boundary");
            if (stackTopIndex[stackIndex] == ((stackIndex + 1) * stacksize))
           
                throw new Exception("capacity is reached");
            //move to typical stackIndex position;
            var stackPostion = stackTopIndex[stackIndex];
            array[stackPostion] = value;
            //also stack size will increase by 1
            //as we added one new vaue, top index will increase 1
            stackTopIndex[stackIndex] = stackPostion + 1;


        }
        public int pop (int stackIndex)
        {
            if (stackIndex < 0 || stackIndex > 2)
                throw new Exception("") ;
            var stackPosition = stackTopIndex[stackIndex];
            stackPosition--;
            stackTopIndex[stackIndex] = stackPosition;
            return array[stackPosition];

        }

    }
}
