using System;

namespace UsefullStuffLibrary
{
    public class Matrixes
    {

        // method for making square matrix where numbers are powers of X
        public static int[,] MakeSqrMatrixPow(int n, int pow)
        {
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int x = i;

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (int)Math.Pow(pow, x);

                    x++;
                }
            }

            return matrix;
        }

        // method for making square matrix basic
        public static int[,] MakeSqrMatrix(int n)
        {
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            return matrix;
        }

        // method for making rectangle matrix basic
        public static int[,] MakeRecMatrix(int height, int length)
        {
            int[,] matrix = new int[height, length];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            return matrix;
        }

        // method for printing matrix
        public static void PrintMatrix(int[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write($"{input[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }




    }
}
