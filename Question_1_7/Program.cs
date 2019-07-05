using System;

namespace Question_1_7
{
    class Program
    {
        //Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4
       // bytes, write a method to rotate the image by 90 degrees.Can you do this in place?
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[,] RotateMatrix(int[,] matrix)
        {
            var size = matrix.GetLength(0);
            var newMatrix = new int[size, size];
            for (int i=0; i<size; i++)
            {
                for (int j=0; j<size;j++)
                {
                    //basically it doest make 
                        
                        //1
                        //2
                        //3
                        //4
                        //to 
                        //1 2 3 4
                    newMatrix[j, size - 1 - i] = matrix[i, j];

                }

            }
            return newMatrix;
        }
    }
}
